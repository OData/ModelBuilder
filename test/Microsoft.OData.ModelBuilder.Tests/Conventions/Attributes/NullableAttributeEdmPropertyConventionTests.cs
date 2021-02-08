// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder.Conventions.Attributes;
using Microsoft.OData.ModelBuilder.Tests.Commons;
using Microsoft.OData.ModelBuilder.Tests.TestModels;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests.Conventions.Attributes
{
    public class NullableAttributeEdmPropertyConventionTests
    {
        //
        // The NullableAttribute is a compiler generated attribute that has no public specification
        // and is injected into code. Additionally the compiler may optimize the NullableAttribute
        // into a NullableContextAttribute. Thus it would be extremely difficult to Mock the inputs.
        //

        [Fact]
        public void Empty_Ctor_DoesnotThrow()
            => ExceptionAssert.DoesNotThrow(() => new NullableAttributeEdmPropertyConvention());

        [Fact]
        public void NullableAttributeEdmPropertyConvention_ConfiguresSimpleTypeWithNullable()
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Employee>("Employees");

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet("Employees", typeof(Employee));

            var employeeEntity = model.AssertHasEntityType(typeof(Employee));
            employeeEntity.AssertHasPrimitiveProperty(model, "EmployeeName", EdmPrimitiveTypeKind.String, isNullable: true);
            employeeEntity.AssertHasNavigationProperty(model, "IsCeoOf", typeof(Company), isNullable: true, EdmMultiplicity.Many);
            employeeEntity.AssertHasNavigationProperty(model, "WorkCompany", typeof(Company), isNullable: true, EdmMultiplicity.ZeroOrOne);
            employeeEntity.AssertHasNavigationProperty(model, "Boss", typeof(Employee), isNullable: true, EdmMultiplicity.ZeroOrOne);
            employeeEntity.AssertHasComplexProperty(model, "HomeAddress", typeof(Address), isNullable: true);
            employeeEntity.AssertHasNavigationProperty(model, "DirectReports", typeof(Employee), isNullable: true, EdmMultiplicity.Many);

            var addressEntity = model.AssertHasComplexType(typeof(Address));
            addressEntity.AssertHasPrimitiveProperty(model, "Street", EdmPrimitiveTypeKind.String, isNullable: true);
            addressEntity.AssertHasPrimitiveProperty(model, "City", EdmPrimitiveTypeKind.String, isNullable: true);
            addressEntity.AssertHasPrimitiveProperty(model, "State", EdmPrimitiveTypeKind.String, isNullable: true);
            addressEntity.AssertHasComplexProperty(model, "ZipCode", typeof(ZipCode), isNullable: true);
            addressEntity.AssertHasPrimitiveProperty(model, "IgnoreThis", EdmPrimitiveTypeKind.String, isNullable: true);

            var zipCodeEntity = model.AssertHasComplexType(typeof(ZipCode));
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part1", EdmPrimitiveTypeKind.String, isNullable: true);
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part1", EdmPrimitiveTypeKind.String, isNullable: true);
        }

        [Fact]
        public void NullableAttributeEdmPropertyConvention_ConfiguresSimpleTypeWithNonNullable()
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<TestModels.NonNullable.Employee>("Employees");

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet("Employees", typeof(TestModels.NonNullable.Employee));

            var employeeEntity = model.AssertHasEntityType(typeof(TestModels.NonNullable.Employee));
            employeeEntity.AssertHasPrimitiveProperty(model, "EmployeeName", EdmPrimitiveTypeKind.String, isNullable: false);
            employeeEntity.AssertHasNavigationProperty(model, "IsCeoOf", typeof(TestModels.NonNullable.Company), isNullable: true, EdmMultiplicity.Many);
            employeeEntity.AssertHasNavigationProperty(model, "WorkCompany", typeof(TestModels.NonNullable.Company), isNullable: false, EdmMultiplicity.One);
            employeeEntity.AssertHasNavigationProperty(model, "Boss", typeof(TestModels.NonNullable.Employee), isNullable: false, EdmMultiplicity.One);
            employeeEntity.AssertHasComplexProperty(model, "HomeAddress", typeof(TestModels.NonNullable.Address), isNullable: false);
            employeeEntity.AssertHasComplexProperty(model, "VacationAddress", typeof(TestModels.NonNullable.Address), isNullable: false);
            employeeEntity.AssertHasNavigationProperty(model, "DirectReports", typeof(TestModels.NonNullable.Employee), isNullable: true, EdmMultiplicity.Many);

            var addressEntity = model.AssertHasComplexType(typeof(TestModels.NonNullable.Address));
            addressEntity.AssertHasPrimitiveProperty(model, "Street", EdmPrimitiveTypeKind.String, isNullable: false);
            addressEntity.AssertHasPrimitiveProperty(model, "City", EdmPrimitiveTypeKind.String, isNullable: false);
            addressEntity.AssertHasPrimitiveProperty(model, "State", EdmPrimitiveTypeKind.String, isNullable: false);
            addressEntity.AssertHasComplexProperty(model, "ZipCode", typeof(TestModels.NonNullable.ZipCode), isNullable: false);
            addressEntity.AssertHasPrimitiveProperty(model, "IgnoreThis", EdmPrimitiveTypeKind.String, isNullable: false);

            var zipCodeEntity = model.AssertHasComplexType(typeof(TestModels.NonNullable.ZipCode));
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part1", EdmPrimitiveTypeKind.String, isNullable: false);
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part2", EdmPrimitiveTypeKind.String, isNullable: true);
        }

        [Fact]
        public void NullableAttributeEdmPropertyConvention_ConfiguresInheritedTypeWithNullable()
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Manager>("Managers");

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet("Managers", typeof(Manager));

            var managerEntity = model.AssertHasEntityType(typeof(Manager));
            managerEntity.AssertHasComplexProperty(model, "ExtraOffice", typeof(Address), isNullable: true);
            managerEntity.AssertHasPrimitiveProperty(model, "EmployeeName", EdmPrimitiveTypeKind.String, isNullable: true);
            managerEntity.AssertHasNavigationProperty(model, "IsCeoOf", typeof(Company), isNullable: true, EdmMultiplicity.Many);
            managerEntity.AssertHasNavigationProperty(model, "WorkCompany", typeof(Company), isNullable: true, EdmMultiplicity.ZeroOrOne);
            managerEntity.AssertHasNavigationProperty(model, "Boss", typeof(Employee), isNullable: true, EdmMultiplicity.ZeroOrOne);
            managerEntity.AssertHasComplexProperty(model, "HomeAddress", typeof(Address), isNullable: true);
            managerEntity.AssertHasNavigationProperty(model, "DirectReports", typeof(Employee), isNullable: true, EdmMultiplicity.Many);

            var addressEntity = model.AssertHasComplexType(typeof(Address));
            addressEntity.AssertHasPrimitiveProperty(model, "Street", EdmPrimitiveTypeKind.String, isNullable: true);
            addressEntity.AssertHasPrimitiveProperty(model, "City", EdmPrimitiveTypeKind.String, isNullable: true);
            addressEntity.AssertHasPrimitiveProperty(model, "State", EdmPrimitiveTypeKind.String, isNullable: true);
            addressEntity.AssertHasComplexProperty(model, "ZipCode", typeof(ZipCode), isNullable: true);
            addressEntity.AssertHasPrimitiveProperty(model, "IgnoreThis", EdmPrimitiveTypeKind.String, isNullable: true);

            var zipCodeEntity = model.AssertHasComplexType(typeof(ZipCode));
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part1", EdmPrimitiveTypeKind.String, isNullable: true);
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part1", EdmPrimitiveTypeKind.String, isNullable: true);
        }

        [Fact]
        public void NullableAttributeEdmPropertyConvention_ConfiguresInheritedTypeWithNonNullable()
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<TestModels.NonNullable.Manager>("Managers");

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet("Managers", typeof(TestModels.NonNullable.Manager));

            var managerEntity = model.AssertHasEntityType(typeof(TestModels.NonNullable.Manager));
            managerEntity.AssertHasComplexProperty(model, "ExtraOffice", typeof(TestModels.NonNullable.Address), isNullable: true);
            managerEntity.AssertHasPrimitiveProperty(model, "EmployeeName", EdmPrimitiveTypeKind.String, isNullable: false);
            managerEntity.AssertHasNavigationProperty(model, "IsCeoOf", typeof(TestModels.NonNullable.Company), isNullable: true, EdmMultiplicity.Many);
            managerEntity.AssertHasNavigationProperty(model, "WorkCompany", typeof(TestModels.NonNullable.Company), isNullable: false, EdmMultiplicity.One);
            managerEntity.AssertHasNavigationProperty(model, "Boss", typeof(TestModels.NonNullable.Employee), isNullable: false, EdmMultiplicity.One);
            managerEntity.AssertHasComplexProperty(model, "HomeAddress", typeof(TestModels.NonNullable.Address), isNullable: false);
            managerEntity.AssertHasComplexProperty(model, "VacationAddress", typeof(TestModels.NonNullable.Address), isNullable: false);
            managerEntity.AssertHasNavigationProperty(model, "DirectReports", typeof(TestModels.NonNullable.Employee), isNullable: true, EdmMultiplicity.Many);

            var addressEntity = model.AssertHasComplexType(typeof(TestModels.NonNullable.Address));
            addressEntity.AssertHasPrimitiveProperty(model, "Street", EdmPrimitiveTypeKind.String, isNullable: false);
            addressEntity.AssertHasPrimitiveProperty(model, "City", EdmPrimitiveTypeKind.String, isNullable: false);
            addressEntity.AssertHasPrimitiveProperty(model, "State", EdmPrimitiveTypeKind.String, isNullable: false);
            addressEntity.AssertHasComplexProperty(model, "ZipCode", typeof(TestModels.NonNullable.ZipCode), isNullable: false);
            addressEntity.AssertHasPrimitiveProperty(model, "IgnoreThis", EdmPrimitiveTypeKind.String, isNullable: false);

            var zipCodeEntity = model.AssertHasComplexType(typeof(TestModels.NonNullable.ZipCode));
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part1", EdmPrimitiveTypeKind.String, isNullable: false);
            zipCodeEntity.AssertHasPrimitiveProperty(model, "Part2", EdmPrimitiveTypeKind.String, isNullable: true);
        }

        [Fact]
        public void NullableAttributeEdmPropertyConvention_ConfiguresValueTypeWithNullable()
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<Customer>("Customers");

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet("Customers", typeof(Customer));

            var customerEntity = model.AssertHasEntityType(typeof(Customer));
            customerEntity.AssertHasPrimitiveProperty(model, "Name", EdmPrimitiveTypeKind.String, isNullable: true);
            customerEntity.AssertHasPrimitiveProperty(model, "SharePrice", EdmPrimitiveTypeKind.Decimal, isNullable: true);
        }

        [Fact]
        public void NullableAttributeEdmPropertyConvention_ConfiguresValueTypeWithNonNullable()
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<TestModels.NonNullable.Customer>("Customers");

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet("Customers", typeof(TestModels.NonNullable.Customer));

            var customerEntity = model.AssertHasEntityType(typeof(TestModels.NonNullable.Customer));
            customerEntity.AssertHasPrimitiveProperty(model, "Name", EdmPrimitiveTypeKind.String, isNullable: false);
            customerEntity.AssertHasPrimitiveProperty(model, "SharePrice", EdmPrimitiveTypeKind.Decimal, isNullable: true);
        }

        [Fact]
        public void NullableAttributeEdmPropertyConvention_ConfiguresDictionaryTypeWithNonNullable()
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            builder.EntitySet<TestModels.NonNullable.Customer>("Customers");

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet("Customers", typeof(TestModels.NonNullable.Customer));

            var customerEntity = model.AssertHasEntityType(typeof(TestModels.NonNullable.Customer));
            customerEntity.AssertHasPrimitiveProperty(model, "Name", EdmPrimitiveTypeKind.String, isNullable: false);
            customerEntity.AssertHasPrimitiveProperty(model, "SharePrice", EdmPrimitiveTypeKind.Decimal, isNullable: true);
        }

        [Theory]
        [InlineData(nameof(TestClassNullable.NonNullable), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(TestClassNullable.Nullable), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullable.NonNullablePropertyMaybeNull), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullable.NonNullablePropertyAllowNull), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(TestClassNullable.NullablePropertyNotNull), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullable.NullablePropertyDisallowNull), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullable.RequiredAndNullable), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(TestClassNullable.NullObliviousNonNullable), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullable.NullObliviousNullable), EdmPrimitiveTypeKind.String, true)]
        public void Reference_nullability_sets_is_nullable_correctly(string propertyName, EdmPrimitiveTypeKind edmType, bool expectedNullable)
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            var entitySetName = nameof(TestClassNullable) + "s";
            var type = typeof(TestClassNullable);
            builder.EntitySet<TestClassNullable>(entitySetName);

            ActAndAssertPropertyNullability(propertyName, edmType, expectedNullable, builder, entitySetName, type);
        }

        [Theory]
        [InlineData(nameof(TestClassNullableContext.NonNullable), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(TestClassNullableContext.Nullable), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullableContext.NonNullablePropertyMaybeNull), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullableContext.NonNullablePropertyAllowNull), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(TestClassNullableContext.NullablePropertyNotNull), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullableContext.NullablePropertyDisallowNull), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullableContext.RequiredAndNullable), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(TestClassNullableContext.NullObliviousNonNullable), EdmPrimitiveTypeKind.String, true)]
        [InlineData(nameof(TestClassNullableContext.NullObliviousNullable), EdmPrimitiveTypeKind.String, true)]
        public void Reference_nullability_with_context_sets_is_nullable_correctly(string propertyName, EdmPrimitiveTypeKind edmType, bool expectedNullable)
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            var entitySetName = nameof(TestClassNullableContext) + "s";
            var type = typeof(TestClassNullableContext);
            builder.EntitySet<TestClassNullableContext>(entitySetName);

            ActAndAssertPropertyNullability(propertyName, edmType, expectedNullable, builder, entitySetName, type);
        }

        [Theory]
        [InlineData(nameof(B.NonNullableValueType), EdmPrimitiveTypeKind.Guid, false)]
        [InlineData(nameof(B.NullableValueType), EdmPrimitiveTypeKind.Guid, true)]
        [InlineData(nameof(B.NonNullableRefType), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(B.NullableRefType), EdmPrimitiveTypeKind.String, true)]
        public void Value_ref_nullability_sets_is_nullable_correctly(string propertyName, EdmPrimitiveTypeKind edmType, bool expectedNullable)
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            var entitySetName = nameof(B) + "s";
            var type = typeof(B);
            builder.EntitySet<B>(entitySetName);

            ActAndAssertPropertyNullability(propertyName, edmType, expectedNullable, builder, entitySetName, type);
        }

        [Theory]
        [InlineData(nameof(DerivedClass.NonNullable), EdmPrimitiveTypeKind.String, false)]
        [InlineData(nameof(DerivedClass.Nullable), EdmPrimitiveTypeKind.String, true)]
        public void Reference_nullability_sets_is_nullable_correctlyDerivedClass(string propertyName, EdmPrimitiveTypeKind edmType, bool expectedNullable)
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            var entitySetName = nameof(DerivedClass) + "s";
            var type = typeof(DerivedClass);
            builder.EntitySet<DerivedClass>(entitySetName);

            ActAndAssertPropertyNullability(propertyName, edmType, expectedNullable, builder, entitySetName, type);
        }

        [Theory]
        [InlineData(nameof(DerivedClass.Nullable), EdmPrimitiveTypeKind.String, true)]
        public void Reference_nullability_sets_is_nullable_correctlyBaseClass(string propertyName, EdmPrimitiveTypeKind edmType, bool expectedNullable)
        {
            // Arrange         
            var builder = new ODataConventionModelBuilder();
            var entitySetName = nameof(BaseClass) + "s";
            var type = typeof(BaseClass);
            builder.EntitySet<BaseClass>(entitySetName);

            ActAndAssertPropertyNullability(propertyName, edmType, expectedNullable, builder, entitySetName, type);
        }

        private static void ActAndAssertPropertyNullability(string propertyName, EdmPrimitiveTypeKind edmType, bool expectedNullable, ODataConventionModelBuilder builder, string entitySetName, Type type)
        {

            // Act
            var model = builder.GetEdmModel();

            // Assert
            model.AssertHasEntitySet(entitySetName, type);

            var propertyEntity = model.AssertHasEntityType(type);
            propertyEntity.AssertHasPrimitiveProperty(model, propertyName, edmType, isNullable: expectedNullable);
        }

        // Subset of tests used by EF Core
        //     Field tests are not used by OData
        //     Properties must have setter
        // NullableContextAttribute(2)
        // NullableAttribute(0)
        private class TestClassNullable
        {
            public int Id { get; set; }

#nullable enable
            // NullableAttribute(1)
            public string NonNullable { get; set; } = "";
            public string? Nullable { get; set; }

            // NullableAttribute(1)
            [MaybeNull]
            public string NonNullablePropertyMaybeNull { get; set; } = "";

            // NullableAttribute(1)
            [AllowNull]
            public string NonNullablePropertyAllowNull { get; set; } = "";

            [NotNull]
            public string? NullablePropertyNotNull { get; set; } = "";

            [DisallowNull]
            public string? NullablePropertyDisallowNull { get; set; } = "";

            [Required]
            public string? RequiredAndNullable { get; set; }
#nullable disable

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' context.
            // NullableAttribute(0)
            public string NullObliviousNonNullable { get; set; }
            public string? NullObliviousNullable { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' context.
        }

        //
        // Same as previous class TestClassNullable but add extra NonNullables to change the NullableContextAttribute
        //
        // NullableContextAttribute(1)
        // NullableAttribute(0)
        private class TestClassNullableContext
        {
            public int Id { get; set; }

#nullable enable
            public string NonNullable { get; set; } = "";
            // NullableAttribute(2)
            public string? Nullable { get; set; }

            [MaybeNull]
            public string NonNullablePropertyMaybeNull { get; set; } = "";

            [AllowNull]
            public string NonNullablePropertyAllowNull { get; set; } = "";

            // NullableAttribute(2)
            [NotNull]
            public string? NullablePropertyNotNull { get; set; } = "";

            // NullableAttribute(2)
            [DisallowNull]
            public string? NullablePropertyDisallowNull { get; set; } = "";

            // NullableAttribute(2)
            [Required]
            public string? RequiredAndNullable { get; set; }

            public string NonNullableProperty1 { get; set; } = "";
            public string NonNullableProperty2 { get; set; } = "";

#nullable disable

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' context.
            // NullableAttribute(0)
            public string NullObliviousNonNullable { get; set; }
            // NullableAttribute(2)
            public string? NullObliviousNullable { get; set; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' context.
        }

#nullable enable
        public class B
        {
            [Key]
            public Guid NonNullableValueType { get; set; }

            public Guid? NullableValueType { get; set; }
            public string NonNullableRefType { get; set; } = "";
            public string? NullableRefType { get; set; }
        }

        public class DerivedClass : BaseClass
        {
            public string NonNullable { get; set; } = default!;
        }

        public class BaseClass
        {
            public int Id { get; set; }
            public string? Nullable { get; set; }
        }
#nullable disable
    }
}
