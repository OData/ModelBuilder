// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm.Vocabularies;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// Represents an <see cref="IEdmTerm"/> that can be built using <see cref="ODataModelBuilder"/>.
    /// </summary>
    public class TermConfiguration<TType>
    {
        private TermConfiguration _configuration;

        internal TermConfiguration(TermConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Gets or sets a value that is <c>true</c> if the type's name or namespace was set by the user; <c>false</c> if it was inferred through conventions.
        /// </summary>
        /// <remarks>The default value is <c>false</c>.</remarks>
        public bool AddedExplicitly { get; set; }

        /// <summary>
        /// The <see cref="ODataModelBuilder"/>.
        /// </summary>
        public virtual ODataModelBuilder ModelBuilder { get; private set; }

    }
}
