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
    /// Properties and terms annotated with this term MUST contain a valid MIME type
    /// </summary>
    public partial class IsMediaTypeConfiguration : VocabularyTermConfiguration
    {
        private bool? _isMediaType;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.IsMediaType";

        /// <summary>
        /// Properties and terms annotated with this term MUST contain a valid MIME type
        /// </summary>
        /// <param name="isMediaType">The value to set</param>
        /// <returns><see cref="IsMediaTypeConfiguration"/></returns>
        public IsMediaTypeConfiguration IsIsMediaType(bool isMediaType)
        {
            _isMediaType = isMediaType;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            return new EdmBooleanConstant(_isMediaType ?? true);
        }
    }
}
