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
	/// Stream property supports update of its media edit URL and/or media read URL
	/// </summary>
	public partial class MediaLocationUpdateSupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _mediaLocationUpdateSupported;

        /// <summary>
        /// Creates a new instance of <see cref="MediaLocationUpdateSupportedConfiguration"/>
        /// </summary>
		public MediaLocationUpdateSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.MediaLocationUpdateSupported")
		{
		}

		/// <summary>
		/// Stream property supports update of its media edit URL and/or media read URL
		/// </summary>
		/// <param name="mediaLocationUpdateSupported">The value to set</param>
		/// <returns><see cref="MediaLocationUpdateSupportedConfiguration"/></returns>
		public MediaLocationUpdateSupportedConfiguration HasMediaLocationUpdateSupported(bool mediaLocationUpdateSupported)
		{
			_mediaLocationUpdateSupported = mediaLocationUpdateSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_mediaLocationUpdateSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("MediaLocationUpdateSupported", new EdmBooleanConstant(_mediaLocationUpdateSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
