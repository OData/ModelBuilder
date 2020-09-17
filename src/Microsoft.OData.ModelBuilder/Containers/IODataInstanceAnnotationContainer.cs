// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Interface to used as a Container for holding Instance Annotations, An default implementation is provided
    /// Customer can implement the interface and can have their own implementation.
    /// </summary>
    public interface IODataInstanceAnnotationContainer
    {
        /// <summary>
        /// Gets the instance annotation.
        /// If the key is null, it's for the CLR type instance annotations.
        /// If the key is not null, it's for the property instance annotations.
        /// </summary>
        IDictionary<string, IDictionary<string, object>> InstanceAnnotations { get; }
    }
}
