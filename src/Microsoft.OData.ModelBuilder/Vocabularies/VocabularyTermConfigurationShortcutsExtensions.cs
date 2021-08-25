// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Linq;
using Microsoft.OData.ModelBuilder.Capabilities.V1;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// Shortcuts for common configurations to be extended in here.
    /// </summary>
    public static class VocabularyTermConfigurationShortcutsExtensions
    {
        /// <summary>
        /// List of scopes that can provide access to the resource
        /// </summary>
        /// <param name="permissionTypeConfiguration"><see cref="PermissionTypeConfiguration"/></param>
        /// <param name="scopeNames">The value(s) to set</param>
        /// <returns></returns>
        public static PermissionTypeConfiguration HasScopes(this PermissionTypeConfiguration permissionTypeConfiguration, params string[] scopeNames)
            => permissionTypeConfiguration?.HasScopes(scopeNames.Select(scope => new ScopeTypeConfiguration().HasScope(scope)).ToArray());

    }
}