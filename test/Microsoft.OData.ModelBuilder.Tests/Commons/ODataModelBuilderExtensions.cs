// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder.Tests.TestModels;

namespace Microsoft.OData.ModelBuilder.Tests.Commons
{
    public static class ODataModelBuilderExtensions
    {
        public static IEdmModel GetServiceModel(this ODataModelBuilder builder)
        {
            return EdmModelHelperMethods.BuildEdmModel(builder);
        }

        public static ODataModelBuilder Add_Customer_EntityType(this ODataModelBuilder builder)
        {
            var customer = builder.EntityType<Customer>();
            customer.HasKey(c => c.CustomerId);
            customer.Property(c => c.CustomerId);
            customer.Property(c => c.Name).IsConcurrencyToken();
            customer.Property(c => c.Website);
            customer.Property(c => c.SharePrice);
            customer.Property(c => c.ShareSymbol);
            customer.Property(c => c.StartDate);
            return builder;
        }

        public static ODataModelBuilder Add_Order_EntityType(this ODataModelBuilder builder)
        {
            var order = builder.EntityType<Order>();
            order.HasKey(o => o.OrderId);
            order.Property(o => o.OrderDate);
            order.Property(o => o.Price);
            order.Property(o => o.OrderDate);
            order.Property(o => o.DeliveryDate);
            order.Ignore(o => o.Cost);
            return builder;
        }

        public static ODataModelBuilder Add_Customers_EntitySet(this ODataModelBuilder builder)
        {
            builder.Add_Customer_EntityType().EntitySet<Customer>("Customers");
            return builder;
        }

        public static ODataModelBuilder Add_CustomerOrders_Relationship(this ODataModelBuilder builder)
        {
            builder.EntityType<Customer>().HasMany(c => c.Orders);
            return builder;
        }

        public static ODataModelBuilder Add_CustomerOrders_Binding(this ODataModelBuilder builder)
        {
            builder.EntitySet<Customer>("Customers").HasManyBinding(c => c.Orders, "Orders");
            return builder;
        }

        public static ODataModelBuilder Add_Company_EntityType(this ODataModelBuilder builder)
        {
            var company = builder.EntityType<Company>();
            company.HasKey(c => c.CompanyId);
            company.Property(c => c.CompanyName).IsConcurrencyToken();
            company.Property(c => c.Website);
            return builder;
        }

        public static ODataModelBuilder Add_Employee_EntityType(this ODataModelBuilder builder)
        {
            var employee = builder.EntityType<Employee>();
            employee.HasKey(c => c.EmployeeID);
            employee.Property(c => c.EmployeeName).IsConcurrencyToken();
            employee.Property(c => c.BaseSalary);
            return builder;
        }

        public static ODataModelBuilder Add_CompanyEmployees_Relationship(this ODataModelBuilder builder)
        {
            builder.EntityType<Company>().HasMany(c => c.ComplanyEmployees);
            builder.EntityType<Company>().HasRequired(c => c.CEO, (company, employee) => company.CEOID == employee.EmployeeID, employee => employee.IsCeoOf);
            return builder;
        }
    }
}
