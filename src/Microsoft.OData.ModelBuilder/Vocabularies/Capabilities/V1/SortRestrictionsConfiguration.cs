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
	/// Restrictions on orderby expressions
	/// </summary>
	public partial class SortRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private bool? _sortable;
		private readonly HashSet<EdmPropertyPathExpression> _ascendingOnlyProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmPropertyPathExpression> _descendingOnlyProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmPropertyPathExpression> _nonSortableProperties = new HashSet<EdmPropertyPathExpression>();

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.SortRestrictions";

		/// <summary>
		/// $orderby is supported
		/// </summary>
		/// <param name="sortable">The value to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration IsSortable(bool sortable)
		{
			_sortable = sortable;
			return this;
		}

		/// <summary>
		/// These properties can only be used for sorting in Ascending order
		/// </summary>
		/// <param name="ascendingOnlyProperties">The value(s) to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration HasAscendingOnlyProperties(params EdmPropertyPathExpression[] ascendingOnlyProperties)
		{
			_ascendingOnlyProperties.UnionWith(ascendingOnlyProperties);
			return this;
		}

		/// <summary>
		/// These properties can only be used for sorting in Descending order
		/// </summary>
		/// <param name="descendingOnlyProperties">The value(s) to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration HasDescendingOnlyProperties(params EdmPropertyPathExpression[] descendingOnlyProperties)
		{
			_descendingOnlyProperties.UnionWith(descendingOnlyProperties);
			return this;
		}

		/// <summary>
		/// These structural properties cannot be used in orderby expressions
		/// </summary>
		/// <param name="nonSortableProperties">The value(s) to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration HasNonSortableProperties(params EdmPropertyPathExpression[] nonSortableProperties)
		{
			_nonSortableProperties.UnionWith(nonSortableProperties);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_sortable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Sortable", new EdmBooleanConstant(_sortable.Value)));
			}

			if (_ascendingOnlyProperties.Any())
			{
				var collection = _ascendingOnlyProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("AscendingOnlyProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_descendingOnlyProperties.Any())
			{
				var collection = _descendingOnlyProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("DescendingOnlyProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_nonSortableProperties.Any())
			{
				var collection = _nonSortableProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("NonSortableProperties", new EdmCollectionExpression(collection)));
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
