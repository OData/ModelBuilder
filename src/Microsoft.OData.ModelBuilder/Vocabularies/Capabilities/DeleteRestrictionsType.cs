// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Restrictions on delete operations
    /// </summary>
    public class DeleteRestrictionsType
    {
        /// <summary>
        /// Initialize new <see cref="DeleteRestrictionsType"/>
        /// </summary>
        public DeleteRestrictionsType()
        {
            Permissions = new List<PermissionType>();
        }

        /// <summary>
        /// Entities can be deleted.
        /// </summary>
        public bool? Deletable { get; set; }

        /// <summary>
        /// Required permissions. One of the specified sets of scopes is required to perform the delete.
        /// </summary>
        public List<PermissionType> Permissions { get; }

        /// <summary>
        /// A brief description of the request.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// A lengthy description of the request.
        /// </summary>
        public string LongDescription { get; set; }
    }
}
