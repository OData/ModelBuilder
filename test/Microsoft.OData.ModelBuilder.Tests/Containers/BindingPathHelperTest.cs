﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Reflection;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Containers
{
    public class BindingPathHelperTest
    {
        [Fact]
        public void ConvertBindingPath_Throws()
        {
            // Arrange
            IList<MemberInfo> path = null;

            // Act & Assert
            ExceptionAssert.ThrowsArgumentNull(() => path.ConvertBindingPath(), "bindingPath");
        }

        [Fact]
        public void ConvertBindingPath_Returns()
        {
            // Arrange
            MockType type = new MockType("MockType");
            MockPropertyInfo propertyInfo = new MockPropertyInfo(typeof(object), "propertyName");

            // Act
            IList<MemberInfo> path = new List<MemberInfo> { type.Object, propertyInfo.Object };

            // Assert
            Assert.Equal("DefaultNamespace.MockType/propertyName", path.ConvertBindingPath());
        }
    }
}
