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
	/// Support for query options with modification requests (insert, update, action invocation)
	/// </summary>
	public partial class ModificationQueryOptionsConfiguration : VocabularyConfiguration
	{
		private bool? _expandSupported;
		private bool? _selectSupported;
		private bool? _computeSupported;
		private bool? _filterSupported;
		private bool? _searchSupported;
		private bool? _sortSupported;

        /// <summary>
        /// Creates a new instance of <see cref="ModificationQueryOptionsConfiguration"/>
        /// </summary>
		public ModificationQueryOptionsConfiguration()
			: base("Org.OData.Capabilities.V1.ModificationQueryOptions")
		{
		}

		/// <summary>
		/// Supports $expand with modification requests
		/// </summary>
		/// <param name="expandSupported">The value to set</param>
		/// <returns><see cref="ModificationQueryOptionsConfiguration"/></returns>
		public ModificationQueryOptionsConfiguration HasExpandSupported(bool expandSupported)
		{
			_expandSupported = expandSupported;
			return this;
		}

		/// <summary>
		/// Supports $select with modification requests
		/// </summary>
		/// <param name="selectSupported">The value to set</param>
		/// <returns><see cref="ModificationQueryOptionsConfiguration"/></returns>
		public ModificationQueryOptionsConfiguration HasSelectSupported(bool selectSupported)
		{
			_selectSupported = selectSupported;
			return this;
		}

		/// <summary>
		/// Supports $compute with modification requests
		/// </summary>
		/// <param name="computeSupported">The value to set</param>
		/// <returns><see cref="ModificationQueryOptionsConfiguration"/></returns>
		public ModificationQueryOptionsConfiguration HasComputeSupported(bool computeSupported)
		{
			_computeSupported = computeSupported;
			return this;
		}

		/// <summary>
		/// Supports $filter with modification requests
		/// </summary>
		/// <param name="filterSupported">The value to set</param>
		/// <returns><see cref="ModificationQueryOptionsConfiguration"/></returns>
		public ModificationQueryOptionsConfiguration HasFilterSupported(bool filterSupported)
		{
			_filterSupported = filterSupported;
			return this;
		}

		/// <summary>
		/// Supports $search with modification requests
		/// </summary>
		/// <param name="searchSupported">The value to set</param>
		/// <returns><see cref="ModificationQueryOptionsConfiguration"/></returns>
		public ModificationQueryOptionsConfiguration HasSearchSupported(bool searchSupported)
		{
			_searchSupported = searchSupported;
			return this;
		}

		/// <summary>
		/// Supports $orderby with modification requests
		/// </summary>
		/// <param name="sortSupported">The value to set</param>
		/// <returns><see cref="ModificationQueryOptionsConfiguration"/></returns>
		public ModificationQueryOptionsConfiguration HasSortSupported(bool sortSupported)
		{
			_sortSupported = sortSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_expandSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("ExpandSupported", new EdmBooleanConstant(_expandSupported.Value)));
			}

			if (_selectSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("SelectSupported", new EdmBooleanConstant(_selectSupported.Value)));
			}

			if (_computeSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("ComputeSupported", new EdmBooleanConstant(_computeSupported.Value)));
			}

			if (_filterSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("FilterSupported", new EdmBooleanConstant(_filterSupported.Value)));
			}

			if (_searchSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("SearchSupported", new EdmBooleanConstant(_searchSupported.Value)));
			}

			if (_sortSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("SortSupported", new EdmBooleanConstant(_sortSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
