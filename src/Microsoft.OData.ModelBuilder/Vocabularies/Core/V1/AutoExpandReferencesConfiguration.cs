// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.
// <auto-generated />

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Core.V1
{
    /// <summary>
    /// The service will automatically expand this navigation property as entity references even if not requested with $expand=.../$ref
    /// </summary>
    public partial class AutoExpandReferencesConfiguration : VocabularyTermConfiguration
    {
        private bool? _autoExpandReferences;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.AutoExpandReferences";

        /// <summary>
        /// The service will automatically expand this navigation property as entity references even if not requested with $expand=.../$ref
        /// </summary>
        /// <param name="autoExpandReferences">The value to set</param>
        /// <returns><see cref="AutoExpandReferencesConfiguration"/></returns>
        public AutoExpandReferencesConfiguration IsAutoExpandReferences(bool autoExpandReferences)
        {
            _autoExpandReferences = autoExpandReferences;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            return _autoExpandReferences.HasValue ? new EdmBooleanConstant(_autoExpandReferences.Value) : null;
        }
    }
}
