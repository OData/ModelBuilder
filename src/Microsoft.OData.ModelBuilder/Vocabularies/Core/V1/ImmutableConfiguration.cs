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
    /// A value for this non-key property can be provided by the client on insert and remains unchanged on update
    /// </summary>
    public partial class ImmutableConfiguration : VocabularyTermConfiguration
    {
        private bool? _immutable;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.Immutable";

        /// <summary>
        /// A value for this non-key property can be provided by the client on insert and remains unchanged on update
        /// </summary>
        /// <param name="immutable">The value to set</param>
        /// <returns><see cref="ImmutableConfiguration"/></returns>
        public ImmutableConfiguration IsImmutable(bool immutable)
        {
            _immutable = immutable;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            return _immutable.HasValue ? new EdmBooleanConstant(_immutable.Value) : null;
        }
    }
}
