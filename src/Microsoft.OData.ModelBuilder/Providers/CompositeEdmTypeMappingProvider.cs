// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder.Providers
{
    public sealed class CompositeEdmTypeMappingProvider : IEdmTypeMappingProvider
    {
        private readonly IEnumerable<IEdmTypeMappingProvider> _providers;

        public CompositeEdmTypeMappingProvider(IEnumerable<IEdmTypeMappingProvider> providers)
        {
            if (providers == null || providers.Count() == 0)
            {
                // TODO: Use resource manager for error messages
                throw new ArgumentException("At least one provider must be specified.", nameof(providers));
            }

            _providers = providers;
        }

        // TODO: Consider making this public if needed
        internal IEnumerable<IEdmTypeMappingProvider> Providers => _providers;

        public bool TryGetEdmType(Type clrType, out IEdmPrimitiveType primitiveType)
        {
            foreach (IEdmTypeMappingProvider provider in _providers)
            {
                if (provider.TryGetEdmType(clrType, out primitiveType))
                {
                    return true;
                }
            }

            primitiveType = null;
            return false;
        }

        public bool TryGetClrType(IEdmTypeReference edmTypeReference, out Type clrType)
        {
            foreach (IEdmTypeMappingProvider provider in _providers)
            {
                if (provider.TryGetClrType(edmTypeReference, out clrType))
                {
                    return true;
                }
            }

            clrType = null;
            return false;
        }
    }
}
