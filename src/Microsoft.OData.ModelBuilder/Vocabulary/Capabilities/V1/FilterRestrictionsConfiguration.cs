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
	/// Restrictions on filter expressions
	/// </summary>
	public partial class FilterRestrictionsConfiguration : VocabularyConfiguration
	{
		private bool? _filterable;
		private bool? _requiresFilter;
		private readonly HashSet<EdmPropertyPathExpression> _requiredProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmPropertyPathExpression> _nonFilterableProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<FilterExpressionRestrictionTypeConfiguration> _filterExpressionRestrictions = new HashSet<FilterExpressionRestrictionTypeConfiguration>();
		private int? _maxLevels;

        /// <summary>
        /// Creates a new instance of <see cref="FilterRestrictionsConfiguration"/>
        /// </summary>
		public FilterRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.FilterRestrictions")
		{
		}

		/// <summary>
		/// $filter is supported
		/// </summary>
		/// <param name="filterable">The value to set</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public FilterRestrictionsConfiguration HasFilterable(bool filterable)
		{
			_filterable = filterable;
			return this;
		}

		/// <summary>
		/// $filter is required
		/// </summary>
		/// <param name="requiresFilter">The value to set</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public FilterRestrictionsConfiguration HasRequiresFilter(bool requiresFilter)
		{
			_requiresFilter = requiresFilter;
			return this;
		}

		/// <summary>
		/// These properties must be specified in the $filter clause (properties of derived types are not allowed here)
		/// </summary>
		/// <param name="requiredProperties">The value(s) to set</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public FilterRestrictionsConfiguration AddRequiredProperties(params EdmPropertyPathExpression[] requiredProperties)
		{
			foreach (var item in requiredProperties)
			{
				_ = _requiredProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// These structural properties cannot be used in filter expressions
		/// </summary>
		/// <param name="nonFilterableProperties">The value(s) to set</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public FilterRestrictionsConfiguration AddNonFilterableProperties(params EdmPropertyPathExpression[] nonFilterableProperties)
		{
			foreach (var item in nonFilterableProperties)
			{
				_ = _nonFilterableProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// These properties only allow a subset of filter expressions. A valid filter expression for a single property can be enclosed in parentheses and combined by `and` with valid expressions for other properties.
		/// </summary>
		/// <param name="filterExpressionRestrictions">The value(s) to set</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public FilterRestrictionsConfiguration AddFilterExpressionRestrictions(params FilterExpressionRestrictionTypeConfiguration[] filterExpressionRestrictions)
		{
			foreach (var item in filterExpressionRestrictions)
			{
				_ = _filterExpressionRestrictions.Add(item);
			}

			return this;
		}

		/// <summary>
		/// The maximum number of levels (including recursion) that can be traversed in a filter expression. A value of -1 indicates there is no restriction.
		/// </summary>
		/// <param name="maxLevels">The value to set</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public FilterRestrictionsConfiguration HasMaxLevels(int maxLevels)
		{
			_maxLevels = maxLevels;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_filterable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Filterable", new EdmBooleanConstant(_filterable.Value)));
			}

			if (_requiresFilter.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("RequiresFilter", new EdmBooleanConstant(_requiresFilter.Value)));
			}

			if (_requiredProperties.Any())
			{
				var collection = _requiredProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("RequiredProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_nonFilterableProperties.Any())
			{
				var collection = _nonFilterableProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("NonFilterableProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_filterExpressionRestrictions.Any())
			{
				var collection = _filterExpressionRestrictions.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("FilterExpressionRestrictions", new EdmCollectionExpression(collection)));
				}
			}

			if (_maxLevels.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("MaxLevels", new EdmIntegerConstant(_maxLevels.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
