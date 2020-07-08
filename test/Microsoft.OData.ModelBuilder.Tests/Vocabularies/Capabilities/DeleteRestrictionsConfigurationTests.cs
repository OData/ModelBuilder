// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder.Capabilities.V1;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Microsoft.OData.ModelBuilder.Tests.TestModels;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Vocabularies.Capabilities
{
    public class DeleteRestrictionsConfigurationTests
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
        public void ModelBuilderHasNoCapabilitiesAnnotationsUnlessExplicitlyAdded()
        {
            var modelBuilder = new ODataModelBuilder().Add_Customers_EntitySet();
            var entitySetConfiguration = modelBuilder.EntitySet<Customer>("Customers");

            var model1 = modelBuilder.GetEdmModel();
            var entityContainer1 = model1.SchemaElements.OfType<IEdmEntityContainer>().SingleOrDefault();
            var customers1 = entityContainer1.EntitySets().SingleOrDefault();
            var term1 = model1.FindTerm("Org.OData.Capabilities.V1.DeleteRestrictions");
            var annotations1 = customers1.VocabularyAnnotations(model1).Where(a => a.Term == term1);

            Assert.Empty(annotations1);

            // Add annotations
            _ = modelBuilder.EntitySet<Customer>("Customers").HasDeleteRestrictions().IsDeletable(false);
            var model2 = modelBuilder.GetEdmModel();
            var entityContainer2 = model2.SchemaElements.OfType<IEdmEntityContainer>().SingleOrDefault();
            var customers2 = entityContainer2.EntitySets().SingleOrDefault();
            var term2 = model2.FindTerm("Org.OData.Capabilities.V1.DeleteRestrictions");
            var annotations2 = customers2.VocabularyAnnotations(model2).Where(a => a.Term == term2);

            _ = Assert.Single(annotations2);
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

            var descriptionValue = GetRecordValue<EdmStringConstant>(annotationValue, "Description");
            Assert.Equal(Description, descriptionValue.Value);
        }

        [Fact]
        public void PermissionsCanBeAddedToEntitySet()
        {
            var modelBuilder = new ODataModelBuilder().Add_Customer_EntityType().Add_Customers_EntitySet();


            var deleteRestrictionsBuilder = modelBuilder
                .EntitySet<Customer>("Customers")
                .HasDeleteRestrictions()
                .IsDeletable(false)
                .HasDescription(Description)
                .AddPermissions(
                    new PermissionTypeConfiguration()
                        .HasSchemeName(SchemeName)
                        .AddScopes(
                            new ScopeTypeConfiguration()
                                .HasScope(CustomerReadWriteAllScope)
                                .HasRestrictedProperties("*")))
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
