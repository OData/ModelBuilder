// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// A scopes that can provide access to a resource.
    /// </summary>
    public class ScopeType
    {
        /// <summary>
        /// Name of the scope.
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Comma-separated string value of all properties that will be included or excluded when using the scope.<br/>
        /// Possible string value identifiers when specifying properties are<br/>
        /// *, PropertyName, -PropertyName.<br/>
        /// * denotes all properties are accessible.<br/>
        /// -PropertyName excludes that specific property.<br/>
        /// PropertyName explicitly provides access to the specific property.<br/>
        /// The absence of RestrictedProperties denotes all properties are accessible using that scope.
        /// </summary>
        public string RestrictedProperties { get; set; }
    }
}
