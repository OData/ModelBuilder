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
    /// The media type of a binary resource
    /// </summary>
    public partial class MediaTypeConfiguration : VocabularyTermConfiguration
    {
        private string _mediaType;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.MediaType";

        /// <summary>
        /// The media type of a binary resource
        /// </summary>
        /// <param name="mediaType">The value to set</param>
        /// <returns><see cref="MediaTypeConfiguration"/></returns>
        public MediaTypeConfiguration HasMediaType(string mediaType)
        {
            _mediaType = mediaType;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            return new EdmStringConstant(_mediaType);
        }
    }
}
