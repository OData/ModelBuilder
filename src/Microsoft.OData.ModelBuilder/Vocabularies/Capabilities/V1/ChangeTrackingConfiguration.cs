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
	/// Change tracking capabilities of this service or entity set
	/// </summary>
	public partial class ChangeTrackingConfiguration : VocabularyTermConfiguration
	{
		private bool? _supported;
		private readonly HashSet<EdmPropertyPathExpression> _filterableProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmNavigationPropertyPathExpression> _expandableProperties = new HashSet<EdmNavigationPropertyPathExpression>();

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.ChangeTracking";

		/// <summary>
		/// This entity set supports the odata.track-changes preference
		/// </summary>
		/// <param name="supported">The value to set</param>
		/// <returns><see cref="ChangeTrackingConfiguration"/></returns>
		public ChangeTrackingConfiguration IsSupported(bool supported)
		{
			_supported = supported;
			return this;
		}

		/// <summary>
		/// Change tracking supports filters on these properties
		/// If no properties are specified or FilterableProperties is omitted, clients cannot assume support for filtering on any properties in combination with change tracking.
		/// </summary>
		/// <param name="filterableProperties">The value(s) to set</param>
		/// <returns><see cref="ChangeTrackingConfiguration"/></returns>
		public ChangeTrackingConfiguration HasFilterableProperties(params EdmPropertyPathExpression[] filterableProperties)
		{
			_filterableProperties.UnionWith(filterableProperties);
			return this;
		}

		/// <summary>
		/// Change tracking supports these properties expanded
		/// If no properties are specified or ExpandableProperties is omitted, clients cannot assume support for expanding any properties in combination with change tracking.
		/// </summary>
		/// <param name="expandableProperties">The value(s) to set</param>
		/// <returns><see cref="ChangeTrackingConfiguration"/></returns>
		public ChangeTrackingConfiguration HasExpandableProperties(params EdmNavigationPropertyPathExpression[] expandableProperties)
		{
			_expandableProperties.UnionWith(expandableProperties);
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

			if (_filterableProperties.Any())
			{
				var collection = _filterableProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("FilterableProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_expandableProperties.Any())
			{
				var collection = _expandableProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("ExpandableProperties", new EdmCollectionExpression(collection)));
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
