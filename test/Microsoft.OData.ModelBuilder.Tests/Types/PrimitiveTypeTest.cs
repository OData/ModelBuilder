// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.IO;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Types
{
    public class PrimitiveTypeTest
    {
        [Fact]
        public void CreateByteArrayPrimitiveProperty()
        {
            ODataModelBuilder builder = new ODataModelBuilder();
            var file = builder.EntityType<PrimitiveFile>();
            var data = file.Property(f => f.Data);

            var model = builder.GetServiceModel();
            var fileType = model.SchemaElements.OfType<IEdmEntityType>().Single();
            var dataProperty = fileType.DeclaredProperties.SingleOrDefault(p => p.Name == "Data");

            Assert.Equal(PropertyKind.Primitive, data.Kind);

            Assert.NotNull(dataProperty);
            Assert.Equal("Edm.Binary", dataProperty.Type.FullName());
        }

        [Fact]
        public void CreateStreamPrimitiveProperty()
        {
            ODataModelBuilder builder = new ODataModelBuilder();
            var file = builder.EntityType<PrimitiveFile>();
            var data = file.Property(f => f.StreamData);

            var model = builder.GetServiceModel();
            var fileType = model.SchemaElements.OfType<IEdmEntityType>().Single();
            var streamProperty = fileType.DeclaredProperties.SingleOrDefault(p => p.Name == "StreamData");

            Assert.Equal(PropertyKind.Primitive, data.Kind);

            Assert.NotNull(streamProperty);
            Assert.Equal("Edm.Stream", streamProperty.Type.FullName());
        }

        [Fact]
        public void CreateDatePrimitiveProperty()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();
            PrimitivePropertyConfiguration date = file.Property(f => f.DateProperty);

            // Act
            IEdmModel model = builder.GetServiceModel();

            // Assert
            Assert.Equal(PropertyKind.Primitive, date.Kind);

            IEdmEntityType fileType = Assert.Single(model.SchemaElements.OfType<IEdmEntityType>());

            IEdmProperty dateProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "DateProperty"));
            Assert.NotNull(dateProperty);
            Assert.Equal("Edm.Date", dateProperty.Type.FullName());
        }

        [Fact]
        public void CreateDatePrimitiveProperty_FromDateTime()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();
            file.Property(f => f.Birthday).AsDate();
            file.Property(f => f.PublishDay).AsDate();

            // Act
            IEdmModel model = builder.GetServiceModel();

            // Assert
            IEdmEntityType fileType = Assert.Single(model.SchemaElements.OfType<IEdmEntityType>());

            IEdmProperty birthdayProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "Birthday"));
            Assert.NotNull(birthdayProperty);
            Assert.False(birthdayProperty.Type.IsNullable);
            Assert.Equal("Edm.Date", birthdayProperty.Type.FullName());

            IEdmProperty publishDayProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "PublishDay"));
            Assert.NotNull(publishDayProperty);
            Assert.True(publishDayProperty.Type.IsNullable);
            Assert.Equal("Edm.Date", publishDayProperty.Type.FullName());
        }

#if NET6_0_OR_GREATER
        [Fact]
        public void CreateDatePrimitiveProperty_FromDateOnly()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();
            file.Property(f => f.EditedDay).AsDate();
            file.Property(f => f.RevisionDay).AsDate();

            // Act
            IEdmModel model = builder.GetServiceModel();

            // Assert
            IEdmEntityType fileType = Assert.Single(model.SchemaElements.OfType<IEdmEntityType>());

            IEdmProperty editedDayProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "EditedDay"));
            Assert.NotNull(editedDayProperty);
            Assert.False(editedDayProperty.Type.IsNullable);
            Assert.Equal("Edm.Date", editedDayProperty.Type.FullName());

            IEdmProperty revisionDayProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "RevisionDay"));
            Assert.NotNull(revisionDayProperty);
            Assert.True(revisionDayProperty.Type.IsNullable);
            Assert.Equal("Edm.Date", revisionDayProperty.Type.FullName());
        }
#endif

        [Fact]
        public void CreateDatePrimitiveProperty_FromBadDate()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();

            // Act & Assert   
            ExceptionAssert.Throws<ArgumentException>(() => file.Property(f => f.StreamData).AsDate(),
#if NET6_0_OR_GREATER
                "The property 'StreamData' on type 'Microsoft.OData.ModelBuilder.Tests.Types.PrimitiveFile' must be a System.DateTime or System.DateOnly property. (Parameter 'property')");
#else
                "The property 'StreamData' on type 'Microsoft.OData.ModelBuilder.Tests.Types.PrimitiveFile' must be a System.DateTime property. (Parameter 'property')");
#endif
        }

        [Fact]
        public void CreateTimeOfDayPrimitiveProperty()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();
            PrimitivePropertyConfiguration timeOfDay = file.Property(f => f.TimeOfDayProperty);

            // Act
            IEdmModel model = builder.GetServiceModel();

            // Assert
            Assert.Equal(PropertyKind.Primitive, timeOfDay.Kind);

            IEdmEntityType fileType = Assert.Single(model.SchemaElements.OfType<IEdmEntityType>());

            IEdmProperty property = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "TimeOfDayProperty"));
            Assert.NotNull(property);
            Assert.Equal("Edm.TimeOfDay", property.Type.FullName());
        }

        [Fact]
        public void CreateTimeOfDayPrimitiveProperty_FromTimeSpan()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();
            file.Property(f => f.CreatedTime).AsTimeOfDay();
            file.Property(f => f.EndTime).AsTimeOfDay();

            // Act
            IEdmModel model = builder.GetServiceModel();

            // Assert
            IEdmEntityType fileType = Assert.Single(model.SchemaElements.OfType<IEdmEntityType>());

            IEdmProperty createProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "CreatedTime"));
            Assert.NotNull(createProperty);
            Assert.False(createProperty.Type.IsNullable);
            Assert.Equal("Edm.TimeOfDay", createProperty.Type.FullName());

            IEdmProperty endProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "EndTime"));
            Assert.NotNull(endProperty);
            Assert.True(endProperty.Type.IsNullable);
            Assert.Equal("Edm.TimeOfDay", endProperty.Type.FullName());
        }

#if NET6_0_OR_GREATER
        [Fact]
        public void CreateTimeOfDayPrimitiveProperty_FromTimeOnly()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();
            file.Property(f => f.ModifiedTime).AsTimeOfDay();
            file.Property(f => f.LastTime).AsTimeOfDay();

            // Act
            IEdmModel model = builder.GetServiceModel();

            // Assert
            IEdmEntityType fileType = Assert.Single(model.SchemaElements.OfType<IEdmEntityType>());

            IEdmProperty modifiedTimeProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "ModifiedTime"));
            Assert.NotNull(modifiedTimeProperty);
            Assert.False(modifiedTimeProperty.Type.IsNullable);
            Assert.Equal("Edm.TimeOfDay", modifiedTimeProperty.Type.FullName());

            IEdmProperty lastTimeProperty = Assert.Single(fileType.DeclaredProperties.Where(p => p.Name == "LastTime"));
            Assert.NotNull(lastTimeProperty);
            Assert.True(lastTimeProperty.Type.IsNullable);
            Assert.Equal("Edm.TimeOfDay", lastTimeProperty.Type.FullName());
        }
#endif

        [Fact]
        public void CreateTimeOfDayPrimitiveProperty_FromBadTime()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            EntityTypeConfiguration<PrimitiveFile> file = builder.EntityType<PrimitiveFile>();

            // Act & Assert   
            ExceptionAssert.Throws<ArgumentException>(() => file.Property(f => f.StreamData).AsTimeOfDay(),
#if NET6_0_OR_GREATER
                "The property 'StreamData' on type 'Microsoft.OData.ModelBuilder.Tests.Types.PrimitiveFile' must be a System.TimeSpan or System.TimeOnly property. (Parameter 'property')");
#else
                "The property 'StreamData' on type 'Microsoft.OData.ModelBuilder.Tests.Types.PrimitiveFile' must be a System.TimeSpan property. (Parameter 'property')");
#endif
        }
    }

    public class PrimitiveFile
    {
        public byte[] Data { get; set; }

        public Stream StreamData { get; set; }

        public Date DateProperty { get; set; }

        public TimeOfDay TimeOfDayProperty { get; set; }

        public DateTime Birthday { get; set; }
        public DateTime? PublishDay { get; set; }

        public TimeSpan CreatedTime { get; set; }
        public TimeSpan? EndTime { get; set; }

#if NET6_0_OR_GREATER
        public DateOnly EditedDay { get; set; }
        public DateOnly? RevisionDay { get; set; }

        public TimeOnly ModifiedTime { get; set; }
        public TimeOnly? LastTime { get; set; }
#endif
    }
}
