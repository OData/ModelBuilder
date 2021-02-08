// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Tests.TestModels.NonNullable
{
#nullable enable
    //
    // Most of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //     Website         Nullable by annotation
    //     Subsidiaries    Nullable by annotation
    //
    // NullableContextAttribute{1}
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        // NullableAttribute{2}
        public string? Website { get; set; }
        public Address HeadQuarterAddress { get; set; } = new Address();
        [Singleton]
        public Employee CEO { get; set; } = new Employee();
        public int CEOID { get; set; }
        public List<Employee> CompanyEmployees { get; set; } = new List<Employee>();
        public List<Customer> Customers { get; set; } = new List<Customer>();
        // NullableAttribute{2,1}
        public List<Address>? Subsidiaries { get; set; }
    }
#nullable restore
}
