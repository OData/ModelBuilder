// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Restrictions for function or action operation.
    /// </summary>
    public class OperationRestrictionsType
    {
        /// <summary>
        /// Initialize new <see cref="OperationRestrictionsType"/>
        /// </summary>
        public OperationRestrictionsType()
        {
            Permissions = new List<PermissionType>();
        }

        /// <summary>
        /// Bound action or function can be invoked on a collection-valued binding parameter path with a /$filter(...) segment
        /// </summary>
        public bool? FilterSegmentSupported { get; set; }

        /// <summary>
        /// Required permissions. One of the specified sets of scopes is required to invoke an action or function.
        /// </summary>
        public List<PermissionType> Permissions { get; }
    }
}
