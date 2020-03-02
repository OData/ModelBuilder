// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Linq;
using Microsoft.OData.Extensions.Builder;
using Xunit;

namespace Microsoft.OData.Extensions.ModelBuilder.Tests
{
    public class FunctionConfigurationTest
    {
        [Fact]
        public void CanCreateFunctionWithNoArguments()
        {
            // Arrange
            // Act
            ODataModelBuilder builder = new ODataModelBuilder();
            builder.Namespace = "MyNamespace";
            builder.ContainerName = "MyContainer";
            FunctionConfiguration function = builder.Function("Format");
            ActionConfiguration functionII = builder.Action("FormatII");
            functionII.Namespace = "MyNamespaceII";

            // Assert
            Assert.Equal("Format", function.Name);
            Assert.Equal(OperationKind.Function, function.Kind);
            Assert.NotNull(function.Parameters);
            Assert.Empty(function.Parameters);
            Assert.Null(function.ReturnType);
            Assert.False(function.IsSideEffecting);
            Assert.False(function.IsComposable);
            Assert.False(function.IsBindable);
            Assert.False(function.SupportedInFilter);
            Assert.False(function.SupportedInOrderBy);
            Assert.Equal("MyNamespace", function.Namespace);
            Assert.Equal("MyNamespace.Format", function.FullyQualifiedName);
            Assert.Equal("MyNamespaceII", functionII.Namespace);
            Assert.Equal("MyNamespaceII.FormatII", functionII.FullyQualifiedName);
            Assert.NotNull(builder.Operations);
            Assert.Equal(2, builder.Operations.Count());
        }

        [Fact]
        public void AttemptToRemoveNonExistentEntityReturnsFalse()
        {
            // Arrange
            ODataModelBuilder builder = new ODataModelBuilder();
            ODataModelBuilder builder2 = new ODataModelBuilder();
            OperationConfiguration toRemove = builder2.Function("ToRemove");

            // Act
            bool removedByName = builder.RemoveOperation("ToRemove");
            bool removed = builder.RemoveOperation(toRemove);

            //Assert
            Assert.False(removedByName);
            Assert.False(removed);
        }

        [Fact]
        public void CanCreateFunctionWithPrimitiveReturnType()
        {
            // Arrange & Act
            ODataModelBuilder builder = new ODataModelBuilder();
            FunctionConfiguration function = builder.Function("CreateMessage");
            function.Returns<string>();

            // Assert
            Assert.NotNull(function.ReturnType);
            Assert.Equal("Edm.String", function.ReturnType.FullName);
        }

        [Fact]
        public void CanCreateFunctionWithPrimitiveCollectionReturnType()
        {
            // Arrange
            // Act
            ODataModelBuilder builder = new ODataModelBuilder();
            FunctionConfiguration function = builder.Function("CreateMessages");
            function.ReturnsCollection<string>();

            // Assert
            Assert.NotNull(function.ReturnType);
            Assert.Equal("Collection(Edm.String)", function.ReturnType.FullName);
        }

        [Fact]
        public void CanCreateFunctionWithComplexReturnType()
        {
            // Arrange & Act
            ODataModelBuilder builder = new ODataModelBuilder();

            FunctionConfiguration createAddress = builder.Function("CreateAddress").Returns<Address>();
            FunctionConfiguration createAddresses = builder.Function("CreateAddresses").ReturnsCollection<Address>();

            // Assert
            ComplexTypeConfiguration address = createAddress.ReturnType as ComplexTypeConfiguration;
            Assert.NotNull(address);
            Assert.Equal(typeof(Address).FullName, address.FullName);
            Assert.Null(createAddress.NavigationSource);

            CollectionTypeConfiguration addresses = createAddresses.ReturnType as CollectionTypeConfiguration;
            Assert.NotNull(addresses);
            Assert.Equal(string.Format("Collection({0})", typeof(Address).FullName), addresses.FullName);
            address = addresses.ElementType as ComplexTypeConfiguration;
            Assert.NotNull(address);
            Assert.Equal(typeof(Address).FullName, address.FullName);
            Assert.Null(createAddresses.NavigationSource);
        }

        [Fact]
        public void CanCreateFunctionWithEntityReturnType()
        {
            // Arrange & Act
            ODataModelBuilder builder = new ODataModelBuilder();

            FunctionConfiguration createGoodCustomer = builder.Function("CreateGoodCustomer").ReturnsFromEntitySet<Customer>("GoodCustomers");
            FunctionConfiguration createBadCustomers = builder.Function("CreateBadCustomers").ReturnsCollectionFromEntitySet<Customer>("BadCustomers");

            // Assert
            EntityTypeConfiguration customer = createGoodCustomer.ReturnType as EntityTypeConfiguration;
            Assert.NotNull(customer);
            Assert.Equal(typeof(Customer).FullName, customer.FullName);
            EntitySetConfiguration goodCustomers = builder.EntitySets.SingleOrDefault(s => s.Name == "GoodCustomers");
            Assert.NotNull(goodCustomers);
            Assert.Same(createGoodCustomer.NavigationSource, goodCustomers);

            CollectionTypeConfiguration customers = createBadCustomers.ReturnType as CollectionTypeConfiguration;
            Assert.NotNull(customers);
            customer = customers.ElementType as EntityTypeConfiguration;
            Assert.NotNull(customer);
            EntitySetConfiguration badCustomers = builder.EntitySets.SingleOrDefault(s => s.Name == "BadCustomers");
            Assert.NotNull(badCustomers);
            Assert.Same(createBadCustomers.NavigationSource, badCustomers);
        }
    }
}
