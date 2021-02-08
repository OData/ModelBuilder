// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Microsoft.OData.ModelBuilder.Tests.TestModels.NonNullable
{
#nullable enable
    //
    // Most of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //     IsCeoOf         Nullable by annotation
    //     VacationAddress NonNullable by RequiredAttribute
    //
    // NullableContextAttribute{1}
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; } = string.Empty;
        public Decimal BaseSalary { get; set; }
        public DateTimeOffset Birthday { get; set; }
        // NullableAttribute{2,1}
        public IList<Company>? IsCeoOf { get; set; }
        public int WorkCompanyId { get; set; }
        public Company WorkCompany { get; set; } = new Company();
        [Singleton]
        public Employee Boss { get; set; } = new Employee();
        public Address HomeAddress { get; set; } = new Address();
#nullable disable
        [Required]
        public Address VacationAddress { get; set; } = new Address();
#nullable enable
        // NullableAttribute{2,1}
        public IList<Employee>? DirectReports { get; set; }
    }

    //
    // Most of the properties in this class will be set to Nullable through the NullableContextAttribute
    //     ExtraDraw       NonNullable as Value type
    //     ExtraOffice     Nullable by annotaion
    //
    // NullableContextAttribute{2}
    public class Manager : Employee
    {
        public Decimal ExtraDraw;
        public Address? ExtraOffice { get; set; }
    }

    //
    // All of the properties in this class will be set to NonNullable as they are Value types
    //
    // No NullableContextAttribute, no NullableAttribute
    public class Engineer : Employee
    {
        public int Level { get; set; }
        public Decimal YearEndBonus { get; set; }
    }

    //
    // All of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //
    // NullableContextAttribute{1}
    public class SalesPerson : Employee
    {
        public Decimal Bonus { get; set; }
        public IList<Customer> Customers { get; set; } = new List<Customer>();
    }
#nullable restore
}
