// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder.Core.V1;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Microsoft.OData.ModelBuilder.Tests.TestModels;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Vocabularies.Core
{
    public class RevisionsConfigurationTests
    {
        private const string Description = "Deprecated";
        private const string Version = "v2.1";
        private RevisionKind Kind = RevisionKind.Deprecated;
        private DateTimeOffset Date = new DateTimeOffset(new DateTime(2021, 12, 12), new TimeSpan(1,0,0));
        private DateTimeOffset RemovalDate = new DateTimeOffset(new DateTime(2022, 12, 12), new TimeSpan(1,0,0));

        [Fact]
        public void RevisionsCanBeAddedToEntitySet()
        {
            var modelBuilder = new ODataModelBuilder().Add_Customer_EntityType().Add_Customers_EntitySet();

            var revisionsBuilder = modelBuilder
                .EntitySet<Customer>("Customers")
                .HasRevisions(a=>a.HasKind(RevisionKind.Deprecated).HasDescription(Description).HasVersion(Version).HasDynamicProperty("Date", Date).HasDynamicProperty("RemovalDate", RemovalDate));

            var model = modelBuilder.GetServiceModel();
            var container = model.SchemaElements.OfType<IEdmEntityContainer>().SingleOrDefault();
            var customers = container.EntitySets().SingleOrDefault(e => e.Name == "Customers");

            var term = model.FindTerm("Org.OData.Core.V1.Revisions");
            var annotation = customers.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var revisionsProperties = GetAnnotationTermEdmRecordExpression(annotation);

            var descriptionNameValue = GetRecordValue<EdmStringConstant>(revisionsProperties, "Description");
            Assert.NotNull(descriptionNameValue);

            Assert.Equal(Description, descriptionNameValue.Value);

            var revisionKindValue = GetRecordValue<EdmEnumMemberExpression>(revisionsProperties, "Kind");
            Assert.NotNull(revisionKindValue);

            Assert.Equal(Kind.ToString(), revisionKindValue.EnumMembers.FirstOrDefault().Name);

        }

        [Fact]
        public void RevisionsCanBeAddedToEntityType()
        {
            var modelBuilder = new ODataModelBuilder();
            var entityTypeConfiguration = modelBuilder.Add_Customer_EntityType();

            var revisionsBuilder = modelBuilder
               .EntityType<Customer>()
               .HasRevisions(a => a.HasKind(RevisionKind.Deprecated).HasDescription(Description).HasVersion(Version));

            var model = modelBuilder.GetServiceModel();
            var entityType = model.SchemaElements.OfType<IEdmEntityType>().Single();

            var term = model.FindTerm("Org.OData.Core.V1.Revisions");
            var annotation = entityType.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var revisionsProperties = GetAnnotationTermEdmRecordExpression(annotation);

            var descriptionValue = GetRecordValue<EdmStringConstant>(revisionsProperties, "Description");
            Assert.NotNull(descriptionValue);

            Assert.Equal(Description, descriptionValue.Value);

            var revisionKindValue = GetRecordValue<EdmEnumMemberExpression>(revisionsProperties, "Kind");
            Assert.NotNull(revisionKindValue);

            Assert.Equal(Kind.ToString(), revisionKindValue.EnumMembers.FirstOrDefault().Name);
        }

        [Fact]
        public void RevisionsCanBeAddedToComplexTypes()
        {
            var modelBuilder = new ODataModelBuilder();
            var entityTypeConfiguration = modelBuilder.Add_Address_ComplexType();

            var revisionsBuilder = modelBuilder
               .ComplexType<Address>()
               .HasRevisions(a => a.HasKind(RevisionKind.Deprecated).HasDescription(Description).HasVersion(Version));

            var model = modelBuilder.GetServiceModel();
            var complexType = model.SchemaElements.OfType<IEdmComplexType>().Single();

            var term = model.FindTerm("Org.OData.Core.V1.Revisions");
            var annotation = complexType.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var revisionsProperties = GetAnnotationTermEdmRecordExpression(annotation);

            var versionValue = GetRecordValue<EdmStringConstant>(revisionsProperties, "Version");
            Assert.NotNull(versionValue);

            Assert.Equal(Version, versionValue.Value);

            var revisionKindValue = GetRecordValue<EdmEnumMemberExpression>(revisionsProperties, "Kind");
            Assert.NotNull(revisionKindValue);

            Assert.Equal(Kind.ToString(), revisionKindValue.EnumMembers.FirstOrDefault().Name);
        }

        [Fact]
        public void RevisionsCanBeAddedToProperties()
        {
            var modelBuilder = new ODataModelBuilder();
            var propertyConfiguration = modelBuilder.ComplexType<Address>().Property(a => a.HouseNumber);

            var revisionsBuilder = modelBuilder
               .ComplexType<Address>()
               .Property(a => a.HouseNumber)
               .HasRevisions(a => a.HasKind(RevisionKind.Deprecated).HasDescription(Description).HasVersion(Version).HasDynamicProperty("Date", Date).HasDynamicProperty("RemovalDate", RemovalDate));

            var model = modelBuilder.GetServiceModel();
            var property = model.SchemaElements.OfType<IEdmComplexType>().Single().DeclaredProperties.OfType<IEdmProperty>().FirstOrDefault(a => a.Name == "HouseNumber");

            var term = model.FindTerm("Org.OData.Core.V1.Revisions");
            var annotation = property.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var revisionsProperties = GetAnnotationTermEdmRecordExpression(annotation);

            var dateNameValue = GetRecordValue<EdmDateTimeOffsetConstant>(revisionsProperties, "Date");
            Assert.NotNull(dateNameValue);

            Assert.Equal(Date, dateNameValue.Value);

            var revisionKindValue = GetRecordValue<EdmEnumMemberExpression>(revisionsProperties, "Kind");
            Assert.NotNull(revisionKindValue);

            Assert.Equal(Kind.ToString(), revisionKindValue.EnumMembers.FirstOrDefault().Name);
        }

        [Fact]
        public void RevisionsCanBeAddedToOperation()
        {
            var modelBuilder = new ODataModelBuilder();
            var actionConfiguration = modelBuilder.Action("MyAction");

            var operationRestrictionsBuilder = actionConfiguration
                .HasRevisions(a => a.HasKind(RevisionKind.Deprecated).HasDescription(Description).HasVersion(Version).HasDynamicProperty("Date", Date).HasDynamicProperty("RemovalDate", RemovalDate));

            var model = modelBuilder.GetServiceModel();
            var action = model.SchemaElements.OfType<IEdmAction>().Single();

            var term = model.FindTerm("Org.OData.Core.V1.Revisions");
            var annotation = action.VocabularyAnnotations(model).FirstOrDefault(a => a.Term == term);
            Assert.NotNull(annotation);

            var revisionsProperties = GetAnnotationTermEdmRecordExpression(annotation);

            var dateNameValue = GetRecordValue<EdmDateTimeOffsetConstant>(revisionsProperties, "Date");
            Assert.NotNull(dateNameValue);

            Assert.Equal(Date, dateNameValue.Value);

            var revisionKindValue = GetRecordValue<EdmEnumMemberExpression>(revisionsProperties, "Kind");
            Assert.NotNull(revisionKindValue);

            Assert.Equal(Kind.ToString(), revisionKindValue.EnumMembers.FirstOrDefault().Name);
        }

        [Fact]
        public void ComputedCanBeAddedAsPrimitiveAnnotationToProperty()
        {
            // Arrange & Act
            var modelBuilder = new ODataModelBuilder();
            modelBuilder.EntityType<Customer>().Property(c => c.Name).HasComputed().IsComputed(false);

            var model = modelBuilder.GetServiceModel();

            // Assert
            var csdl = model.SerializeAsXml();

            Assert.Equal("<?xml version=\"1.0\" encoding=\"utf-16\"?>" +
            "<edmx:Edmx Version=\"4.0\" xmlns:edmx=\"http://docs.oasis-open.org/odata/ns/edmx\">" +
              "<edmx:DataServices>" +
                "<Schema Namespace=\"Microsoft.OData.ModelBuilder.Tests.TestModels\" xmlns=\"http://docs.oasis-open.org/odata/ns/edm\">" +
                  "<EntityType Name=\"Customer\">" +
                    "<Property Name=\"Name\" Type=\"Edm.String\" />" +
                  "</EntityType>" +
                  "<Annotations Target=\"Microsoft.OData.ModelBuilder.Tests.TestModels.Customer/Name\">" +
                    "<Annotation Term=\"Org.OData.Core.V1.Computed\" Bool=\"false\" />" +
                  "</Annotations>" +
                "</Schema>" +
                "<Schema Namespace=\"Default\" xmlns=\"http://docs.oasis-open.org/odata/ns/edm\">" +
                  "<EntityContainer Name=\"Container\" />" +
                "</Schema>" +
              "</edmx:DataServices>" +
            "</edmx:Edmx>", csdl);
        }

        private EdmRecordExpression GetAnnotationTermEdmRecordExpression(IEdmVocabularyAnnotation annotation)
        {
            EdmRecordExpression revisionsProperties = null;

            var annotationValue = annotation.Value as EdmCollectionExpression;
            Assert.NotNull(annotationValue);

            revisionsProperties = Assert.Single(annotationValue.Elements) as EdmRecordExpression;
            Assert.NotNull(revisionsProperties);

            return revisionsProperties;
        }

        private T GetRecordValue<T>(EdmRecordExpression record, string name) where T : class
            => record.FindProperty(name)?.Value as T;
    }
}
