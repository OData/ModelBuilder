// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Restrictions for retrieving a collection of entities, retrieving a singleton instance.
    /// </summary>
    public class ReadRestrictionsType : ReadRestrictionsBase
    {
        /// <summary>
        /// Restrictions for retrieving an entity by key.
        /// Only valid when applied to a collection.
        /// If a property of ReadByKeyRestrictions is not specified, the corresponding property value of ReadRestrictions applies.
        /// </summary>
        public ReadByKeyRestrictionsType ReadByKeyRestrictions { get; set; }
    }
}
