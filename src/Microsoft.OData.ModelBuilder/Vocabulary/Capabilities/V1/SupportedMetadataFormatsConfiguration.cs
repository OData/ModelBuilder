// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Capabilities.V1
{
	/// <summary>
	/// Media types of supported formats for $metadata, including format parameters
	/// </summary>
	public partial class SupportedMetadataFormatsConfiguration : VocabularyConfiguration
	{
		private readonly HashSet<string> _supportedMetadataFormats = new HashSet<string>();

        /// <summary>
        /// Creates a new instance of <see cref="SupportedMetadataFormatsConfiguration"/>
        /// </summary>
		public SupportedMetadataFormatsConfiguration()
			: base("Org.OData.Capabilities.V1.SupportedMetadataFormats")
		{
		}

		/// <summary>
		/// Media types of supported formats for $metadata, including format parameters
		/// </summary>
		/// <param name="supportedMetadataFormats">The value(s) to set</param>
		/// <returns><see cref="SupportedMetadataFormatsConfiguration"/></returns>
		public SupportedMetadataFormatsConfiguration AddSupportedMetadataFormats(params string[] supportedMetadataFormats)
		{
			foreach (var item in supportedMetadataFormats)
			{
				_ = _supportedMetadataFormats.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
