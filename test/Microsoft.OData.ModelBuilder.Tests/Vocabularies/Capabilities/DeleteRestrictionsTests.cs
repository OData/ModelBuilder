using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Microsoft.OData.ModelBuilder.Tests.TestModels;
using Microsoft.OData.ModelBuilder.Vocabularies.Capabilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Vocabularies.Capabilities
{
    public class DeleteRestrictionsTests
    {
        private const string Description = "A brief description";
        private const string LongDescription = "A very long description";
        private const string SchemeName = "Delegated";
        private const string CustomerReadWriteAllScope = "Customers.ReadWrite.All";

        [Fact]
        public void DeleteRestrictionsChainsToSameInstance()
        {
            var modelBuilder = new ODataModelBuilder().Add_Customers_EntitySet();
            var entitySetConfiguration = modelBuilder.EntitySet<Customer>("Customers");

            var builder1 = entitySetConfiguration.HasDeleteRestrictions();
            var builder2 = builder1.IsDeletable(true);

            Assert.Same(builder1, builder2);
        }

        [Fact]
        public void AnnotationsAreAddedToModelOnBuild()
        {
            var modelBuilder = new ODataModelBuilder().Add_Customer_EntityType().Add_Customers_EntitySet();
            var entitySetConfiguration = modelBuilder.EntitySet<Customer>("Customers");

            var deleteRestrictionsBuilder = entitySetConfiguration
                .HasDeleteRestrictions()
                .IsDeletable(false)
                .HasDescription(Description);

            var model = modelBuilder.GetServiceModel();
            var container = model.SchemaElements.OfType<IEdmEntityContainer>().SingleOrDefault();
            var customers = container.EntitySets().SingleOrDefault(e => e.Name == "Customers");

            var term = model.FindTerm("Org.OData.Capabilities.V1.DeleteRestrictions");
            var annotation = customers.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var annotationValue = annotation.Value as EdmRecordExpression;
            Assert.NotNull(annotationValue);

            var descriptionProperty = annotationValue.FindProperty("Description");
            Assert.NotNull(descriptionProperty);

            var stringValue = descriptionProperty.Value as IEdmStringValue;
            Assert.NotNull(stringValue);

            Assert.Equal(Description, stringValue.Value);
        }

        [Fact]
        public void PermissionsCanBeAddedToEntitySet()
        {
            var modelBuilder = new ODataModelBuilder().Add_Customer_EntityType().Add_Customers_EntitySet();
            var entitySetConfiguration = modelBuilder.EntitySet<Customer>("Customers");

            var readWritePermission = new PermissionType { SchemeName = SchemeName };
            readWritePermission.Scopes.AddRange(new ScopeType[]
            {
                new ScopeType
                {
                    Scope = CustomerReadWriteAllScope,
                    RestrictedProperties = "*"
                }
            });

            var deleteRestrictionsBuilder = entitySetConfiguration
                .HasDeleteRestrictions()
                .IsDeletable(false)
                .HasDescription(Description)
                .HasPermissions(new[]
                {
                    readWritePermission
                })
                .HasLongDescription(LongDescription);

            var model = modelBuilder.GetServiceModel();
            var container = model.SchemaElements.OfType<IEdmEntityContainer>().SingleOrDefault();
            var customers = container.EntitySets().SingleOrDefault(e => e.Name == "Customers");

            var term = model.FindTerm("Org.OData.Capabilities.V1.DeleteRestrictions");
            var annotation = customers.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var annotationValue = annotation.Value as EdmRecordExpression;
            Assert.NotNull(annotationValue);

            var permissionsCollection = GetRecordValue<EdmCollectionExpression>(annotationValue, "Permissions");
            Assert.NotNull(permissionsCollection);

            var singlePermission = Assert.Single(permissionsCollection.Elements) as EdmRecordExpression;
            Assert.NotNull(singlePermission);

            var schemeNameValue = GetRecordValue<EdmStringConstant>(singlePermission, "SchemeName");
            Assert.NotNull(schemeNameValue);

            Assert.Equal(SchemeName, schemeNameValue.Value);

            var scopesProperty = GetRecordValue<EdmCollectionExpression>(singlePermission, "Scopes");
            Assert.NotNull(scopesProperty);

            var singleScope = Assert.Single(scopesProperty.Elements) as EdmRecordExpression;
            Assert.NotNull(singleScope);

            var scopeValue = GetRecordValue<EdmStringConstant>(singleScope, "Scope");
            Assert.Equal(CustomerReadWriteAllScope, scopeValue.Value);

            var restrictedPropertiesValue = GetRecordValue<EdmStringConstant>(singleScope, "RestrictedProperties");
            Assert.Equal("*", restrictedPropertiesValue.Value);
        }

        private T GetRecordValue<T>(EdmRecordExpression record, string name) where T : class
            => record.FindProperty(name)?.Value as T;
    }
}
