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
	/// Supports $top
	/// </summary>
	public partial class TopSupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _topSupported;

        /// <summary>
        /// Creates a new instance of <see cref="TopSupportedConfiguration"/>
        /// </summary>
		public TopSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.TopSupported")
		{
		}

		/// <summary>
		/// Supports $top
		/// </summary>
		/// <param name="topSupported">The value to set</param>
		/// <returns><see cref="TopSupportedConfiguration"/></returns>
		public TopSupportedConfiguration IsTopSupported(bool topSupported)
		{
			_topSupported = topSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_topSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("TopSupported", new EdmBooleanConstant(_topSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
