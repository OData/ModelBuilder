using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder.Capabilities.V1;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Microsoft.OData.ModelBuilder.Tests.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Vocabularies.Capabilities
{
    public class OperationRestrictionsConfigurationTests
    {
        private const string Description = "A brief description";
        private const string LongDescription = "A very long description";
        private const string SchemeName = "Delegated";
        private const string CustomerReadWriteAllScope = "Customers.ReadWrite.All";

        [Fact]
        public void OperationRestrictionsChainsToSameInstance()
        {
            // Arrange
            var modelBuilder = new ODataModelBuilder();
            var actionConfiguration = modelBuilder.Action("MyAction");

            var builder1 = actionConfiguration.HasOperationRestrictions();
            var builder2 = builder1.IsFilterSegmentSupported(false);

            Assert.Same(builder1, builder2);
        }

        [Fact]
        public void AnnotationsAreAddedToModelOnBuild()
        {
            var modelBuilder = new ODataModelBuilder();
            var actionConfiguration = modelBuilder.Action("MyAction");

            var operationRestrictionsBuilder = actionConfiguration
                .HasOperationRestrictions()
                .IsFilterSegmentSupported(true);

            var model = modelBuilder.GetServiceModel();
            var action = model.SchemaElements.OfType<IEdmAction>().Single();

            var term = model.FindTerm("Org.OData.Capabilities.V1.OperationRestrictions");
            var annotation = action.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var annotationValue = annotation.Value as EdmRecordExpression;
            Assert.NotNull(annotationValue);

            var filterSegmentSupportedValue = GetRecordValue<EdmBooleanConstant>(annotationValue, "FilterSegmentSupported");
            Assert.True(filterSegmentSupportedValue.Value);
        }

        [Fact]
        public void PermissionsCanBeAddedToOperation()
        {
            var modelBuilder = new ODataModelBuilder();
            var actionConfiguration = modelBuilder.Action("MyAction");

            var operationRestrictionsBuilder = actionConfiguration
                .HasOperationRestrictions()
                .IsFilterSegmentSupported(true)
                .AddPermissions(
                    new PermissionTypeConfiguration()
                        .HasSchemeName(SchemeName)
                        .AddScopes(
                            new ScopeTypeConfiguration()
                                .HasScope(CustomerReadWriteAllScope)
                                .HasRestrictedProperties("*")));

            var model = modelBuilder.GetServiceModel();
            var action = model.SchemaElements.OfType<IEdmAction>().Single();

            var term = model.FindTerm("Org.OData.Capabilities.V1.OperationRestrictions");
            var annotation = action.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
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
