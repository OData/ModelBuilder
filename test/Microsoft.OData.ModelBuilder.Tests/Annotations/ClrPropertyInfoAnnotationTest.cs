// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Xunit;

namespace Microsoft.OData.ModelBuilder.Tests
{
    public class ClrPropertyInfoAnnotationTest
    {
        [Fact]
        public void Ctor_ThrowsForNullPropertyInfo()
        {
            Assert.Throws<ArgumentNullException>("clrPropertyInfo",
                () => new ClrPropertyInfoAnnotation(clrPropertyInfo: null));
        }
    }
}
