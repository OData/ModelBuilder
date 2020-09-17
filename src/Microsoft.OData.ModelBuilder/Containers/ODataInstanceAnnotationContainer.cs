// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Default implementation for <see cref="IODataInstanceAnnotationContainer"/>
    /// </summary>
    public class ODataInstanceAnnotationContainer : IODataInstanceAnnotationContainer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataInstanceAnnotationContainer"/> class.
        /// </summary>
        public ODataInstanceAnnotationContainer()
        {
            InstanceAnnotations = new Dictionary<string, IDictionary<string, object>>();
        }

        /// <summary>
        /// Gets the instance annotations
        /// </summary>
        public IDictionary<string, IDictionary<string, object>> InstanceAnnotations { get; }
    }
}
