﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Tests.TestModels
{
    public class MySpecialOrder : MyOrder
    {
        public bool IsGift { get; set; }

        [Contained]
        public virtual Gift Gift { get; set; }
    }
}
