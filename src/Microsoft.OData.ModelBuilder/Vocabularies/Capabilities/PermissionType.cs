// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm.Vocabularies;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Specified sets of scopes required to perform an action.
    /// </summary>
    public class PermissionType : IRecord
    {
        /// <summary>
        /// Initializes new <see cref="PermissionType"/>
        /// </summary>
        public PermissionType()
        {
            Scopes = new List<ScopeType>();
        }

        /// <summary>
        /// Authorization flow scheme name
        /// </summary>
        public string SchemeName { get; set; }

        /// <summary>
        /// List of scopes that can provide access to the resource
        /// </summary>
        public List<ScopeType> Scopes { get; }

        /// <inheritdoc/>
        public EdmRecordExpression ToEdmRecordExpression()
        {
            var properties = new[]
            {
                new EdmPropertyConstructor(nameof(SchemeName), new EdmStringConstant(SchemeName)),
                new EdmPropertyConstructor(nameof(Scopes), new EdmCollectionExpression(Scopes.Select(s => s.ToEdmRecordExpression())))
            };

            return new EdmRecordExpression(properties);
        }
    }
}
