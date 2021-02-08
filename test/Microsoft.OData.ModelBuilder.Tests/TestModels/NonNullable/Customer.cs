// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Tests.TestModels.NonNullable
{
#nullable enable
    //
    // Most of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //     SharePrice      Nullable by annotation
    //     StartDate       Nullable by annotation
    //
    // NullableContextAttribute{1}
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public Address Address { get; set; } = new Address();
        public Address WorkAddress { get; set; } = new Address();
        public string Website { get; set; } = string.Empty;
        public string ShareSymbol { get; set; } = string.Empty;
        public Decimal? SharePrice { get; set; }
        public Company Company { get; set; } = new Company();
        public List<Order> Orders { get; set; } = new List<Order>();
        public List<string> Aliases { get; set; } = new List<string>();
        public List<Address> Addresses { get; set; } = new List<Address>();
        public Dictionary<string, object> DynamicProperties { get; set; } = new Dictionary<string, object>();
        public DateTimeOffset? StartDate { get; set; }
    }
#nullable restore
}
