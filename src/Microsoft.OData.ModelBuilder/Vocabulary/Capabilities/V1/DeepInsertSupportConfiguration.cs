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
	/// Deep Insert Support of the annotated resource (the whole service, an entity set, or a collection-valued resource)
	/// </summary>
	public partial class DeepInsertSupportConfiguration : VocabularyConfiguration
	{
		private bool? _supported;
		private bool? _contentIDSupported;

        /// <summary>
        /// Creates a new instance of <see cref="DeepInsertSupportConfiguration"/>
        /// </summary>
		public DeepInsertSupportConfiguration()
			: base("Org.OData.Capabilities.V1.DeepInsertSupport")
		{
		}

		/// <summary>
		/// Annotation target supports deep inserts
		/// </summary>
		/// <param name="supported">The value to set</param>
		/// <returns><see cref="DeepInsertSupportConfiguration"/></returns>
		public DeepInsertSupportConfiguration HasSupported(bool supported)
		{
			_supported = supported;
			return this;
		}

		/// <summary>
		/// Annotation target supports accepting and returning nested entities annotated with the `Core.ContentID` instance annotation.
		/// </summary>
		/// <param name="contentIDSupported">The value to set</param>
		/// <returns><see cref="DeepInsertSupportConfiguration"/></returns>
		public DeepInsertSupportConfiguration HasContentIDSupported(bool contentIDSupported)
		{
			_contentIDSupported = contentIDSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_supported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Supported", new EdmBooleanConstant(_supported.Value)));
			}

			if (_contentIDSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("ContentIDSupported", new EdmBooleanConstant(_contentIDSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
