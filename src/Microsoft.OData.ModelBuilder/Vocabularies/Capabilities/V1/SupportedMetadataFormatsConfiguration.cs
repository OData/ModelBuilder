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
	public partial class SupportedMetadataFormatsConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<string> _supportedMetadataFormats = new HashSet<string>();

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.SupportedMetadataFormats";

		/// <summary>
		/// Media types of supported formats for $metadata, including format parameters
		/// </summary>
		/// <param name="supportedMetadataFormats">The value(s) to set</param>
		/// <returns><see cref="SupportedMetadataFormatsConfiguration"/></returns>
		public SupportedMetadataFormatsConfiguration HasSupportedMetadataFormats(params string[] supportedMetadataFormats)
		{
			_supportedMetadataFormats.UnionWith(supportedMetadataFormats);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_supportedMetadataFormats.Any())
			{
				var collection = _supportedMetadataFormats.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("SupportedMetadataFormats", new EdmCollectionExpression(collection)));
				}
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
