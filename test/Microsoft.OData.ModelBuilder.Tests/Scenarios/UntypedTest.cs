// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Scenarios
{
    public class UntypedTest
    {
        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void BuildEdmModel_WorksOnModelBuilder_ForUntypedProperty(bool convention)
        {
            // Arrange & Act
            IEdmModel model = null;
            if (convention)
            {
                ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
                builder.EntityType<UntypedEntity>();
                model = builder.GetEdmModel();
            }
            else
            {
                ODataModelBuilder builder = new ODataModelBuilder();
                var entity = builder.EntityType<UntypedEntity>();
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Value);
                entity.CollectionProperty(p => p.Data);
                entity.CollectionProperty(p => p.Infos);
                model = builder.GetEdmModel();
            }

            // Assert
            Assert.NotNull(model);
            IEdmEntityType edmEntityType = model.SchemaElements.OfType<IEdmEntityType>().First(c => c.Name == "UntypedEntity");

            IEdmProperty[] edmProperties = edmEntityType.Properties().ToArray();
            Assert.Equal(4, edmProperties.Length);

            // Value property
            IEdmProperty valueProperty = edmProperties.First(p => p.Name == "Value");
            Assert.True(valueProperty.Type.IsNullable); // always "true"?
            Assert.True(valueProperty.Type.IsUntyped());
            Assert.Same(EdmCoreModel.Instance.GetUntypedType(), valueProperty.Type.Definition);
            Assert.Equal("Edm.Untyped", valueProperty.Type.FullName());

            // Data collection property
            IEdmProperty dataProperty = edmProperties.First(p => p.Name == "Data");
            Assert.True(dataProperty.Type.IsNullable); // always "true"?
            Assert.True(dataProperty.Type.IsCollection());
            Assert.True(dataProperty.Type.AsCollection().ElementType().IsUntyped());
            Assert.Equal("Collection(Edm.Untyped)", dataProperty.Type.FullName());

            // Infos collection property
            IEdmProperty infosProperty = edmProperties.First(p => p.Name == "Infos");
            Assert.True(infosProperty.Type.IsNullable); // always "true"?
            Assert.True(infosProperty.Type.IsCollection());
            Assert.True(infosProperty.Type.AsCollection().ElementType().IsUntyped());
            Assert.Equal("Collection(Edm.Untyped)", infosProperty.Type.FullName());
        }
    }
    public class UntypedEntity
    {
        public int Id { get; set; }

        public object Value { get; set; }

        public object[] Data { get; set; }

        public IList<object> Infos { get; set; }
    }
}