// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Restrictions on update operations
    /// </summary>
    public class UpdateRestrictionsType
    {
        /// <summary>
        /// Initialize new <see cref="UpdateRestrictionsType"/>
        /// </summary>
        public UpdateRestrictionsType()
        {
            Permissions = new List<PermissionType>();
        }

        /// <summary>
        /// Entities can be updated.
        /// </summary>
        public bool? Updatable { get; set; }

        /// <summary>
        /// Entities can be upserted.
        /// </summary>
        public bool? Upsertable{ get; set; }

        /// <summary>
        /// Required permissions. One of the specified sets of scopes is required to perform the update.
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
