// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Microsoft.OData.ModelBuilder.Tests.Commons
{
    public sealed class MockAssemblyResolver : IAssemblyResolver
    {
        private Assembly[] _mockAssemblies;

        public MockAssemblyResolver(params Assembly[] assemblies)
        {
            _mockAssemblies = assemblies;
        }

        public IEnumerable<Assembly> Assemblies
        {
            get
            {
                if (_mockAssemblies != null)
                {
                    return _mockAssemblies;
                }

                return AppDomain.CurrentDomain.GetAssemblies().Distinct();
            }
        }
    }
}
