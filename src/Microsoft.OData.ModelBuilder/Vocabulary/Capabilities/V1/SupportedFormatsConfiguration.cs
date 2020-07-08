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
	/// Media types of supported formats, including format parameters
	/// </summary>
	public partial class SupportedFormatsConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<string> _supportedFormats = new HashSet<string>();

        /// <summary>
        /// Creates a new instance of <see cref="SupportedFormatsConfiguration"/>
        /// </summary>
		public SupportedFormatsConfiguration()
			: base("Org.OData.Capabilities.V1.SupportedFormats")
		{
		}

		/// <summary>
		/// Media types of supported formats, including format parameters
		/// </summary>
		/// <param name="supportedFormats">The value(s) to set</param>
		/// <returns><see cref="SupportedFormatsConfiguration"/></returns>
		public SupportedFormatsConfiguration HasSupportedFormats(params string[] supportedFormats)
		{
			_supportedFormats.UnionWith(supportedFormats);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_supportedFormats.Any())
			{
				var collection = _supportedFormats.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("SupportedFormats", new EdmCollectionExpression(collection)));
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
