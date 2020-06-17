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
	/// Support for $select and nested query options within $select
	/// </summary>
	public partial class SelectSupportConfiguration : VocabularyConfiguration
	{
		private bool? _supported;
		private bool? _instanceAnnotationsSupported;
		private bool? _expandable;
		private bool? _filterable;
		private bool? _searchable;
		private bool? _topSupported;
		private bool? _skipSupported;
		private bool? _computeSupported;
		private bool? _countable;
		private bool? _sortable;

        /// <summary>
        /// Creates a new instance of <see cref="SelectSupportConfiguration"/>
        /// </summary>
		public SelectSupportConfiguration()
			: base("Org.OData.Capabilities.V1.SelectSupport")
		{
		}

		/// <summary>
		/// Supports $select
		/// </summary>
		/// <param name="supported">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasSupported(bool supported)
		{
			_supported = supported;
			return this;
		}

		/// <summary>
		/// Supports instance annotations in $select list
		/// </summary>
		/// <param name="instanceAnnotationsSupported">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasInstanceAnnotationsSupported(bool instanceAnnotationsSupported)
		{
			_instanceAnnotationsSupported = instanceAnnotationsSupported;
			return this;
		}

		/// <summary>
		/// $expand within $select is supported
		/// </summary>
		/// <param name="expandable">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasExpandable(bool expandable)
		{
			_expandable = expandable;
			return this;
		}

		/// <summary>
		/// $filter within $select is supported
		/// </summary>
		/// <param name="filterable">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasFilterable(bool filterable)
		{
			_filterable = filterable;
			return this;
		}

		/// <summary>
		/// $search within $select is supported
		/// </summary>
		/// <param name="searchable">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasSearchable(bool searchable)
		{
			_searchable = searchable;
			return this;
		}

		/// <summary>
		/// $top within $select is supported
		/// </summary>
		/// <param name="topSupported">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasTopSupported(bool topSupported)
		{
			_topSupported = topSupported;
			return this;
		}

		/// <summary>
		/// $skip within $select is supported
		/// </summary>
		/// <param name="skipSupported">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasSkipSupported(bool skipSupported)
		{
			_skipSupported = skipSupported;
			return this;
		}

		/// <summary>
		/// $compute within $select is supported
		/// </summary>
		/// <param name="computeSupported">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasComputeSupported(bool computeSupported)
		{
			_computeSupported = computeSupported;
			return this;
		}

		/// <summary>
		/// $count within $select is supported
		/// </summary>
		/// <param name="countable">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasCountable(bool countable)
		{
			_countable = countable;
			return this;
		}

		/// <summary>
		/// $orderby within $select is supported
		/// </summary>
		/// <param name="sortable">The value to set</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public SelectSupportConfiguration HasSortable(bool sortable)
		{
			_sortable = sortable;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
