using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Microsoft.OData.ModelBuilder.Tests.TestModels;
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
    }
}
