// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder.Providers
{
    /// <summary>
    /// Defines a service for mapping between CLR types and OData <see cref="IEdmType"/> representations.
    /// Implementations provide bidirectional conversion: from CLR types to Edm primitive types,
    /// and from Edm type references back to CLR types.
    /// </summary>
    public interface IEdmTypeMappingProvider
    {
        /// <summary>
        /// Attempts to resolve a CLR type to its corresponding Edm primitive type.
        /// </summary>
        /// <param name="clrType">The CLR type to map.</param>
        /// <param name="primitiveType">
        /// When this method returns <c>true</c>, contains the associated <see cref="IEdmPrimitiveType"/>; 
        /// otherwise <c>null</c>.
        /// </param>
        /// <returns>
        /// <c>true</c> if the CLR type has a corresponding Edm primitive type; otherwise <c>false</c>.
        /// </returns>
        /// <remarks>
        /// This method currently targets Edm primitive types only. A future evolution could return an
        /// <see cref="IEdmTypeReference"/> to support non-primitive mappings.
        /// </remarks>
        bool TryGetEdmType(Type clrType, out IEdmPrimitiveType primitiveType);

        /// <summary>
        /// Attempts to resolve an Edm type reference to its corresponding CLR type.
        /// </summary>
        /// <param name="edmTypeReference">The Edm type reference to map.</param>
        /// <param name="clrType">
        /// When this method returns <c>true</c>, contains the associated CLR <see cref="Type"/>; 
        /// otherwise <c>null</c>.
        /// </param>
        /// <returns>
        /// <c>true</c> if the Edm type reference has a corresponding CLR type; otherwise <c>false</c>.
        /// </returns>
        bool TryGetClrType(IEdmTypeReference edmTypeReference, out Type clrType);
    }
}