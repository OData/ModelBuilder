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
	/// Custom headers that are supported/required for the annotated resource
	/// </summary>
	public partial class CustomHeadersConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="CustomHeadersConfiguration"/>
        /// </summary>
		public CustomHeadersConfiguration()
			: base("Org.OData.Capabilities.V1.CustomHeaders")
		{
		}

		/// <summary>
		/// Custom headers that are supported/required for the annotated resource
		/// </summary>
		/// <param name="customHeaders">The value(s) to set</param>
		/// <returns><see cref="CustomHeadersConfiguration"/></returns>
		public CustomHeadersConfiguration AddCustomHeaders(params CustomParameterConfiguration[] customHeaders)
		{
			foreach (var item in customHeaders)
			{
				_ = _customHeaders.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_customHeaders.Any())
			{
				var collection = _customHeaders.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("CustomHeaders", new EdmCollectionExpression(collection)));
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
