// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Extensions.Builder;
using Moq;
using Xunit;

namespace Microsoft.OData.Extensions.ModelBuilder.Tests
{
    public class StructuralTypeConfigurationTest
    {
        private StructuralTypeConfiguration _configuration;
    //    private string _name = "name";
   //     private string _namespace = "com.contoso";

        public StructuralTypeConfigurationTest()
        {
            Mock<StructuralTypeConfiguration> mockConfiguration = new Mock<StructuralTypeConfiguration> { CallBase = true };
            mockConfiguration.Object.Name = "Name";
            mockConfiguration.Object.Namespace = "Namespace";
            _configuration = mockConfiguration.Object;
        }
    }
}
