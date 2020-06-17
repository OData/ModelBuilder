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
	public partial class SortRestrictionsConfiguration : VocabularyConfiguration
	{
		private bool? _sortable;
		private readonly HashSet<EdmPropertyPathExpression> _ascendingOnlyProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmPropertyPathExpression> _descendingOnlyProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmPropertyPathExpression> _nonSortableProperties = new HashSet<EdmPropertyPathExpression>();

        /// <summary>
        /// Creates a new instance of <see cref="SortRestrictionsConfiguration"/>
        /// </summary>
		public SortRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.SortRestrictions")
		{
		}

		/// <summary>
		/// $orderby is supported
		/// </summary>
		/// <param name="sortable">The value to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration HasSortable(bool sortable)
		{
			_sortable = sortable;
			return this;
		}

		/// <summary>
		/// These properties can only be used for sorting in Ascending order
		/// </summary>
		/// <param name="ascendingOnlyProperties">The value(s) to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration AddAscendingOnlyProperties(params EdmPropertyPathExpression[] ascendingOnlyProperties)
		{
			foreach (var item in ascendingOnlyProperties)
			{
				_ = _ascendingOnlyProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// These properties can only be used for sorting in Descending order
		/// </summary>
		/// <param name="descendingOnlyProperties">The value(s) to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration AddDescendingOnlyProperties(params EdmPropertyPathExpression[] descendingOnlyProperties)
		{
			foreach (var item in descendingOnlyProperties)
			{
				_ = _descendingOnlyProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// These structural properties cannot be used in orderby expressions
		/// </summary>
		/// <param name="nonSortableProperties">The value(s) to set</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public SortRestrictionsConfiguration AddNonSortableProperties(params EdmPropertyPathExpression[] nonSortableProperties)
		{
			foreach (var item in nonSortableProperties)
			{
				_ = _nonSortableProperties.Add(item);
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
