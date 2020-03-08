// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Tests.Containers
{
    public class BindingCustomer
    {
        public int Id { get; set; }

        public BindingAddress Location { get; set; }

        public BindingAddress Address { get; set; }

        public IList<BindingAddress> Addresses { get; set; }
    }

    public class BindingVipCustomer : BindingCustomer
    {
        public BindingAddress VipLocation { get; set; }

        public IList<BindingAddress> VipAddresses { get; set; }
    }

    public class BindingCity
    {
        public int Id { get; set; }
    }

    public class BindingAddress
    {
        public BindingCity City { get; set; }

        public IList<BindingCity> Cities { get; set; }
    }

    public class BindingUsAddress : BindingAddress
    {
        public BindingCity UsCity { get; set; }

        public ICollection<BindingCity> UsCities { get; set; }
    }
}
