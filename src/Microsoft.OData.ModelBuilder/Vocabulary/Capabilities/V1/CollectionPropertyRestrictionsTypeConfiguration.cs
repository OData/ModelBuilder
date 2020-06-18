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
	/// Org.OData.Capabilities.V1.CollectionPropertyRestrictionsType
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
		/// If not specified, null, or empty, all functions and operators may be attempted.
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
		public CollectionPropertyRestrictionsTypeConfiguration IsTopSupported(bool topSupported)
		{
			_topSupported = topSupported;
			return this;
		}

		/// <summary>
		/// Supports $skip
		/// </summary>
		/// <param name="skipSupported">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration IsSkipSupported(bool skipSupported)
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
		/// If additionally annotated with [Core.PositionalInsert](Org.OData.Core.V1.md#PositionalInsert), members can be inserted at a specific position
		/// </summary>
		/// <param name="insertable">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration IsInsertable(bool insertable)
		{
			_insertable = insertable;
			return this;
		}

		/// <summary>
		/// Members of this ordered collection can be updated by ordinal
		/// </summary>
		/// <param name="updatable">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration IsUpdatable(bool updatable)
		{
			_updatable = updatable;
			return this;
		}

		/// <summary>
		/// Members of this ordered collection can be deleted by ordinal
		/// </summary>
		/// <param name="deletable">The value to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsTypeConfiguration"/></returns>
		public CollectionPropertyRestrictionsTypeConfiguration IsDeletable(bool deletable)
		{
			_deletable = deletable;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_collectionProperty != null)
			{
				properties.Add(new EdmPropertyConstructor("CollectionProperty", _collectionProperty));
			}

			if (_filterFunctions.Any())
			{
				var collection = _filterFunctions.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("FilterFunctions", new EdmCollectionExpression(collection)));
				}
			}

			if (_filterRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("FilterRestrictions", _filterRestrictions.ToEdmExpression()));
			}

			if (_searchRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("SearchRestrictions", _searchRestrictions.ToEdmExpression()));
			}

			if (_sortRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("SortRestrictions", _sortRestrictions.ToEdmExpression()));
			}

			if (_topSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("TopSupported", new EdmBooleanConstant(_topSupported.Value)));
			}

			if (_skipSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("SkipSupported", new EdmBooleanConstant(_skipSupported.Value)));
			}

			if (_selectSupport != null)
			{
				properties.Add(new EdmPropertyConstructor("SelectSupport", _selectSupport.ToEdmExpression()));
			}

			if (_insertable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Insertable", new EdmBooleanConstant(_insertable.Value)));
			}

			if (_updatable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Updatable", new EdmBooleanConstant(_updatable.Value)));
			}

			if (_deletable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Deletable", new EdmBooleanConstant(_deletable.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
