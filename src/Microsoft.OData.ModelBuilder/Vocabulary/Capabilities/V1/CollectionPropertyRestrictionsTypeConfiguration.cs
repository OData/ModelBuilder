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
	/// Summary
/// 
	/// </summary>
	public partial class CollectionPropertyRestrictionsTypeConfiguration : IRecord
	{
		private EdmPropertyPathExpression _collectionProperty;
		private readonly HashSet<string> _filterFunctions = new HashSet<string>();
		private FilterRestrictionsConfiguration _filterRestrictions;
		private SearchRestrictionsConfiguration _searchRestrictions;
		private SortRestrictionsConfiguration _sortRestrictions;
		private bool? _topSupported;
		private bool? _skipSupported;
		private SelectSupportConfiguration _selectSupport;
		private bool? _insertable;
		private bool? _updatable;
		private bool? _deletable;

        /// <summary>
        /// Creates a new instance of <see cref="CollectionPropertyRestrictionsTypeConfiguration"/>
        /// </summary>
		public CollectionPropertyRestrictionsTypeConfiguration()
		{
		}

		/// <summary>
		/// Restricted Collection-valued property
		/// </summary>
		/// <param name="collectionProperty">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasCollectionProperty(EdmPropertyPathExpression collectionProperty)
		{
			_collectionProperty = collectionProperty;
			return this;
		}

		/// <summary>
		/// List of functions and operators supported in filter expressions.
		/// </summary>
		/// <param name="filterFunctions">The value(s) to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration AddFilterFunctions(params string[] filterFunctions)
		{
			foreach (var item in filterFunctions)
			{
				_ = _filterFunctions.Add(item);
			}

			return this;
		}

		/// <summary>
		/// Restrictions on filter expressions
		/// </summary>
		/// <param name="filterRestrictions">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasFilterRestrictions(FilterRestrictionsConfiguration filterRestrictions)
		{
			_filterRestrictions = filterRestrictions;
			return this;
		}

		/// <summary>
		/// Restrictions on search expressions
		/// </summary>
		/// <param name="searchRestrictions">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasSearchRestrictions(SearchRestrictionsConfiguration searchRestrictions)
		{
			_searchRestrictions = searchRestrictions;
			return this;
		}

		/// <summary>
		/// Restrictions on orderby expressions
		/// </summary>
		/// <param name="sortRestrictions">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasSortRestrictions(SortRestrictionsConfiguration sortRestrictions)
		{
			_sortRestrictions = sortRestrictions;
			return this;
		}

		/// <summary>
		/// Supports $top
		/// </summary>
		/// <param name="topSupported">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasTopSupported(bool topSupported)
		{
			_topSupported = topSupported;
			return this;
		}

		/// <summary>
		/// Supports $skip
		/// </summary>
		/// <param name="skipSupported">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasSkipSupported(bool skipSupported)
		{
			_skipSupported = skipSupported;
			return this;
		}

		/// <summary>
		/// Support for $select
		/// </summary>
		/// <param name="selectSupport">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasSelectSupport(SelectSupportConfiguration selectSupport)
		{
			_selectSupport = selectSupport;
			return this;
		}

		/// <summary>
		/// Members can be inserted into this collection
		/// </summary>
		/// <param name="insertable">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasInsertable(bool insertable)
		{
			_insertable = insertable;
			return this;
		}

		/// <summary>
		/// Members of this ordered collection can be updated by ordinal
		/// </summary>
		/// <param name="updatable">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasUpdatable(bool updatable)
		{
			_updatable = updatable;
			return this;
		}

		/// <summary>
		/// Members of this ordered collection can be deleted by ordinal
		/// </summary>
		/// <param name="deletable">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration HasDeletable(bool deletable)
		{
			_deletable = deletable;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
