// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Tests.TestModels.NonNullable
{
#nullable enable
    //
    // All of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //
    // NullableContextAttribute{1}
    public class Address
    {
        public int HouseNumber { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public ZipCode ZipCode { get; set; } = new ZipCode();
        public string IgnoreThis { get; set; } = "IgnoreThis";
    }
#nullable restore
}
