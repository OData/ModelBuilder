// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Microsoft.OData.Extensions.Builder;
using Moq;
using Xunit;

namespace Microsoft.OData.Extensions.ModelBuilder.Tests
{
    public class ComplexTypeConfigurationTest
    {
        [Theory]
        [InlineData(typeof(DateTime))]
        [InlineData(typeof(DateTime?))]
        public void Ctor_DoesnotThrows_IfPropertyIsDateTime(Type type)
        {
            Exception ex = Record.Exception(() => new ComplexTypeConfiguration(Mock.Of<ODataModelBuilder>(), type));
            Assert.Null(ex);

            //ExceptionAssert.DoesNotThrow(() => new ComplexTypeConfiguration(Mock.Of<ODataModelBuilder>(), type));
        }
    }
}
