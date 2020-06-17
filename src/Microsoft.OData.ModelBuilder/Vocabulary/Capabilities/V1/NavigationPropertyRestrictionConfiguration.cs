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
	public partial class NavigationPropertyRestrictionConfiguration : IRecord
	{
		private EdmNavigationPropertyPathExpression _navigationProperty;
		private NavigationType _navigability;
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
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasNavigationProperty(EdmNavigationPropertyPathExpression navigationProperty)
		{
			_navigationProperty = navigationProperty;
			return this;
		}

		/// <summary>
		/// Supported navigability of this navigation property.
		/// </summary>
		/// <param name="navigability">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasNavigability(NavigationType navigability)
		{
			_navigability = navigability;
			return this;
		}

		/// <summary>
		/// List of functions and operators supported in filter expressions.
		/// </summary>
		/// <param name="filterFunctions">The value(s) to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction AddFilterFunctions(params string[] filterFunctions)
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
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasFilterRestrictions(FilterRestrictionsConfiguration filterRestrictions)
		{
			_filterRestrictions = filterRestrictions;
			return this;
		}

		/// <summary>
		/// Restrictions on search expressions
		/// </summary>
		/// <param name="searchRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasSearchRestrictions(SearchRestrictionsConfiguration searchRestrictions)
		{
			_searchRestrictions = searchRestrictions;
			return this;
		}

		/// <summary>
		/// Restrictions on orderby expressions
		/// </summary>
		/// <param name="sortRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasSortRestrictions(SortRestrictionsConfiguration sortRestrictions)
		{
			_sortRestrictions = sortRestrictions;
			return this;
		}

		/// <summary>
		/// Supports $top
		/// </summary>
		/// <param name="topSupported">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasTopSupported(bool topSupported)
		{
			_topSupported = topSupported;
			return this;
		}

		/// <summary>
		/// Supports $skip
		/// </summary>
		/// <param name="skipSupported">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasSkipSupported(bool skipSupported)
		{
			_skipSupported = skipSupported;
			return this;
		}

		/// <summary>
		/// Support for $select
		/// </summary>
		/// <param name="selectSupport">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasSelectSupport(SelectSupportConfiguration selectSupport)
		{
			_selectSupport = selectSupport;
			return this;
		}

		/// <summary>
		/// Supports key values according to OData URL conventions
		/// </summary>
		/// <param name="indexableByKey">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasIndexableByKey(bool indexableByKey)
		{
			_indexableByKey = indexableByKey;
			return this;
		}

		/// <summary>
		/// Restrictions on insert operations
		/// </summary>
		/// <param name="insertRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasInsertRestrictions(InsertRestrictionsConfiguration insertRestrictions)
		{
			_insertRestrictions = insertRestrictions;
			return this;
		}

		/// <summary>
		/// Deep Insert Support of the annotated resource (the whole service, an entity set, or a collection-valued resource)
		/// </summary>
		/// <param name="deepInsertSupport">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasDeepInsertSupport(DeepInsertSupportConfiguration deepInsertSupport)
		{
			_deepInsertSupport = deepInsertSupport;
			return this;
		}

		/// <summary>
		/// Restrictions on update operations
		/// </summary>
		/// <param name="updateRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasUpdateRestrictions(UpdateRestrictionsConfiguration updateRestrictions)
		{
			_updateRestrictions = updateRestrictions;
			return this;
		}

		/// <summary>
		/// Deep Update Support of the annotated resource (the whole service, an entity set, or a collection-valued resource)
		/// </summary>
		/// <param name="deepUpdateSupport">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasDeepUpdateSupport(DeepUpdateSupportConfiguration deepUpdateSupport)
		{
			_deepUpdateSupport = deepUpdateSupport;
			return this;
		}

		/// <summary>
		/// Restrictions on delete operations
		/// </summary>
		/// <param name="deleteRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasDeleteRestrictions(DeleteRestrictionsConfiguration deleteRestrictions)
		{
			_deleteRestrictions = deleteRestrictions;
			return this;
		}

		/// <summary>
		/// Data modification (including insert) along this navigation property requires the use of ETags
		/// </summary>
		/// <param name="optimisticConcurrencyControl">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasOptimisticConcurrencyControl(bool optimisticConcurrencyControl)
		{
			_optimisticConcurrencyControl = optimisticConcurrencyControl;
			return this;
		}

		/// <summary>
		/// Restrictions for retrieving entities
		/// </summary>
		/// <param name="readRestrictions">The value to set</param>
		/// <returns><see cref="NavigationPropertyRestriction"/></returns>
		public NavigationPropertyRestriction HasReadRestrictions(ReadRestrictionsConfiguration readRestrictions)
		{
			_readRestrictions = readRestrictions;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
