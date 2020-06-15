// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm.Vocabularies;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Restrictions on delete operations
    /// </summary>
    public class DeleteRestrictionsType : IRecord
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

        /// <inheritdoc/>
        public EdmRecordExpression ToEdmRecordExpression()
        {
            if (!Deletable.HasValue)
            {
                return null;
            }

            var properties = new List<IEdmPropertyConstructor>();
            properties.Add(new EdmPropertyConstructor(nameof(Deletable), new EdmBooleanConstant(Deletable.Value)));

            if (!String.IsNullOrWhiteSpace(Description))
            {
                properties.Add(new EdmPropertyConstructor(nameof(Description), new EdmStringConstant(Description)));
            }

            if (!String.IsNullOrWhiteSpace(LongDescription))
            {
                properties.Add(new EdmPropertyConstructor(nameof(LongDescription), new EdmStringConstant(LongDescription)));
            }

            properties.Add(new EdmPropertyConstructor(nameof(Permissions), new EdmCollectionExpression(Permissions.Select(p => p.ToEdmRecordExpression()))));

            return new EdmRecordExpression(properties);
        }
    }
}
