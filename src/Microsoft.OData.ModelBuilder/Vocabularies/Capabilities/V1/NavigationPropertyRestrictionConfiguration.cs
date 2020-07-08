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
	/// Org.OData.Capabilities.V1.NavigationPropertyRestriction
	/// </summary>
	public partial class NavigationPropertyRestrictionConfiguration : IRecord
	{
		private EdmNavigationPropertyPathExpression _navigationProperty;
		private NavigationType? _navigability;
		private readonly HashSet<string> _filterFunctions = new HashSet<string>();
		private FilterRestrictionsConfiguration _filterRestrictions;
		private SearchRestrictionsConfiguration _searchRestrictions;
		private SortRestrictionsConfiguration _sortRestrictions;
		private bool? _topSupported;
		private bool? _skipSupported;
		private SelectSupportConfiguration _selectSupport;
		private bool? _indexableByKey;
		private InsertRestrictionsConfiguration _insertRestrictions;
		private DeepInsertSupportConfiguration _deepInsertSupport;
		private UpdateRestrictionsConfiguration _updateRestrictions;
		private DeepUpdateSupportConfiguration _deepUpdateSupport;
		private DeleteRestrictionsConfiguration _deleteRestrictions;
		private bool? _optimisticConcurrencyControl;
		private ReadRestrictionsConfiguration _readRestrictions;

        /// <summary>
        /// Creates a new instance of <see cref="NavigationPropertyRestrictionConfiguration"/>
        /// </summary>
		public NavigationPropertyRestrictionConfiguration()
		{
		}

		/// <summary>
		/// Navigation properties can be navigated
		/// </summary>
		/// <param name="navigationProperty">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasNavigationProperty(EdmNavigationPropertyPathExpression navigationProperty)
		{
			_navigationProperty = navigationProperty;
			return this;
		}

		/// <summary>
		/// Supported navigability of this navigation property.
		/// </summary>
		/// <param name="navigability">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasNavigability(NavigationType navigability)
		{
			_navigability = navigability;
			return this;
		}

		/// <summary>
		/// List of functions and operators supported in filter expressions.
		/// If not specified, null, or empty, all functions and operators may be attempted.
		/// </summary>
		/// <param name="filterFunctions">The value(s) to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasFilterFunctions(params string[] filterFunctions)
		{
			_filterFunctions.UnionWith(filterFunctions);
			return this;
		}

		/// <summary>
		/// Restrictions on filter expressions
		/// </summary>
		/// <param name="filterRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasFilterRestrictions(FilterRestrictionsConfiguration filterRestrictions)
		{
			_filterRestrictions = filterRestrictions;
			return this;
		}

		/// <summary>
		/// Restrictions on search expressions
		/// </summary>
		/// <param name="searchRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasSearchRestrictions(SearchRestrictionsConfiguration searchRestrictions)
		{
			_searchRestrictions = searchRestrictions;
			return this;
		}

		/// <summary>
		/// Restrictions on orderby expressions
		/// </summary>
		/// <param name="sortRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasSortRestrictions(SortRestrictionsConfiguration sortRestrictions)
		{
			_sortRestrictions = sortRestrictions;
			return this;
		}

		/// <summary>
		/// Supports $top
		/// </summary>
		/// <param name="topSupported">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration IsTopSupported(bool topSupported)
		{
			_topSupported = topSupported;
			return this;
		}

		/// <summary>
		/// Supports $skip
		/// </summary>
		/// <param name="skipSupported">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration IsSkipSupported(bool skipSupported)
		{
			_skipSupported = skipSupported;
			return this;
		}

		/// <summary>
		/// Support for $select
		/// </summary>
		/// <param name="selectSupport">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasSelectSupport(SelectSupportConfiguration selectSupport)
		{
			_selectSupport = selectSupport;
			return this;
		}

		/// <summary>
		/// Supports key values according to OData URL conventions
		/// </summary>
		/// <param name="indexableByKey">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration IsIndexableByKey(bool indexableByKey)
		{
			_indexableByKey = indexableByKey;
			return this;
		}

		/// <summary>
		/// Restrictions on insert operations
		/// </summary>
		/// <param name="insertRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasInsertRestrictions(InsertRestrictionsConfiguration insertRestrictions)
		{
			_insertRestrictions = insertRestrictions;
			return this;
		}

		/// <summary>
		/// Deep Insert Support of the annotated resource (the whole service, an entity set, or a collection-valued resource)
		/// </summary>
		/// <param name="deepInsertSupport">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasDeepInsertSupport(DeepInsertSupportConfiguration deepInsertSupport)
		{
			_deepInsertSupport = deepInsertSupport;
			return this;
		}

		/// <summary>
		/// Restrictions on update operations
		/// </summary>
		/// <param name="updateRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasUpdateRestrictions(UpdateRestrictionsConfiguration updateRestrictions)
		{
			_updateRestrictions = updateRestrictions;
			return this;
		}

		/// <summary>
		/// Deep Update Support of the annotated resource (the whole service, an entity set, or a collection-valued resource)
		/// </summary>
		/// <param name="deepUpdateSupport">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasDeepUpdateSupport(DeepUpdateSupportConfiguration deepUpdateSupport)
		{
			_deepUpdateSupport = deepUpdateSupport;
			return this;
		}

		/// <summary>
		/// Restrictions on delete operations
		/// </summary>
		/// <param name="deleteRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasDeleteRestrictions(DeleteRestrictionsConfiguration deleteRestrictions)
		{
			_deleteRestrictions = deleteRestrictions;
			return this;
		}

		/// <summary>
		/// Data modification (including insert) along this navigation property requires the use of ETags
		/// </summary>
		/// <param name="optimisticConcurrencyControl">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration IsOptimisticConcurrencyControl(bool optimisticConcurrencyControl)
		{
			_optimisticConcurrencyControl = optimisticConcurrencyControl;
			return this;
		}

		/// <summary>
		/// Restrictions for retrieving entities
		/// </summary>
		/// <param name="readRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestrictionConfiguration"/></returns>
		public NavigationPropertyRestrictionConfiguration HasReadRestrictions(ReadRestrictionsConfiguration readRestrictions)
		{
			_readRestrictions = readRestrictions;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_navigationProperty != null)
			{
				properties.Add(new EdmPropertyConstructor("NavigationProperty", _navigationProperty));
			}

			if (_navigability.HasValue)
			{
				// properties.Add(new EdmPropertyConstructor("Navigability", new EdmEnumValue(_navigability.Value)));
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

			if (_indexableByKey.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("IndexableByKey", new EdmBooleanConstant(_indexableByKey.Value)));
			}

			if (_insertRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("InsertRestrictions", _insertRestrictions.ToEdmExpression()));
			}

			if (_deepInsertSupport != null)
			{
				properties.Add(new EdmPropertyConstructor("DeepInsertSupport", _deepInsertSupport.ToEdmExpression()));
			}

			if (_updateRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("UpdateRestrictions", _updateRestrictions.ToEdmExpression()));
			}

			if (_deepUpdateSupport != null)
			{
				properties.Add(new EdmPropertyConstructor("DeepUpdateSupport", _deepUpdateSupport.ToEdmExpression()));
			}

			if (_deleteRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("DeleteRestrictions", _deleteRestrictions.ToEdmExpression()));
			}

			if (_optimisticConcurrencyControl.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("OptimisticConcurrencyControl", new EdmBooleanConstant(_optimisticConcurrencyControl.Value)));
			}

			if (_readRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("ReadRestrictions", _readRestrictions.ToEdmExpression()));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
