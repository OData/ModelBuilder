// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.ModelBuilder.Tests.Commons;
using Moq;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Property
{
    public class UntypedPropertyConfigurationTest
    {
        [Fact]
        public void Ctor_Throws_ArgumentNull_Property()
        {
            // Arrange & Act & Assert
            ExceptionAssert.ThrowsArgumentNull(
                () => new UntypedPropertyConfiguration(property: null, declaringType: new EntityTypeConfiguration()),
                "property");
        }

        [Fact]
        public void Ctor_Throws_ArgumentMustBeUntypedProperty_Property()
        {
            // Arrange & Act
            MockPropertyInfo propertyInfo = new MockPropertyInfo(typeof(int), "data");

            // Assert
            ExceptionAssert.ThrowsArgument(
                () => new UntypedPropertyConfiguration(propertyInfo, declaringType: new EntityTypeConfiguration()),
                "property",
                "The property 'data' on type 'System.Object' must be a System.Object property");
        }


        [Fact]
        public void Property_DeclaringType_Returns_DeclaredType()
        {
            // Arrange
            MockPropertyInfo propertyInfo = new MockPropertyInfo(typeof(object), "data");
            Mock<EntityTypeConfiguration> mockDeclaringType = new Mock<EntityTypeConfiguration>();

            // Act
            UntypedPropertyConfiguration navigationProperty = new UntypedPropertyConfiguration(propertyInfo, mockDeclaringType.Object);

            // Assert
            Assert.Equal(mockDeclaringType.Object, navigationProperty.DeclaringType);
        }
    }
}
