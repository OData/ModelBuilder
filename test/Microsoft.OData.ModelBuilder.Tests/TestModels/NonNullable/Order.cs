// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;

namespace Microsoft.OData.ModelBuilder.Tests.TestModels.NonNullable
{
    //
    // Most of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //     DeliveryDate    Nullable by annotation
    //
    // NullableContextAttribute{1}
    public class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public Decimal Cost { get; set; }
        public Decimal Price { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset? DeliveryDate { get; set; }
    }
}
