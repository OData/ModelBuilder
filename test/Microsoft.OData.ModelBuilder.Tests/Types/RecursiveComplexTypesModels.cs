// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Tests.Types
{
    // Scenario 1: Direct reference (complex type points to itself)
    public class RecursiveAddress
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public RecursiveAddress PreviousAddress { get; set; }
    }

    // Scenario 2: Collection (complex type points to itself via a collection)
    public class Field
    {
        public string Name { get; set; }

        public string DataType { get; set; }

        public List<Field> SubFields { get; set; }
    }

    // Scenario 3: Composition (complex type points to itself via indirect recursion)
    public class RecursiveCustomer
    {
        public string Name { get; set; }

        public List<Account> Accounts { get; set; }
    }

    public class Account
    {
        public int Number { get; set; }

        public RecursiveCustomer Owner { get; set; }
    }

    // Scenario 4: Inheritance (complex type has sub-type that points back to the base type via a collection)
    public class File
    {
        public string Name { get; set; }

        public int Size { get; set; }
    }

    public class Directory : File
    {
        public List<File> Files { get; set; }
    }

    // Scenario 5: Hybrid of mutual recursion and inheritance.
    public class Base
    {
        public Derived Derived { get; set; }
    }

    public class Derived : Base
    {
        public Base Base { get; set; }
    }
}

