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
	/// Restrictions on search expressions
	/// </summary>
	public partial class SearchRestrictionsConfiguration : VocabularyConfiguration
	{
		private bool? _searchable;
		private SearchExpressions _unsupportedExpressions;

        /// <summary>
        /// Creates a new instance of <see cref="SearchRestrictionsConfiguration"/>
        /// </summary>
		public SearchRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.SearchRestrictions")
		{
		}

		/// <summary>
		/// $search is supported
		/// </summary>
		/// <param name="searchable">The value to set</param>
		/// <returns><see cref="SearchRestrictionsConfiguration"/></returns>
		public SearchRestrictionsConfiguration HasSearchable(bool searchable)
		{
			_searchable = searchable;
			return this;
		}

		/// <summary>
		/// Expressions not supported in $search
		/// </summary>
		/// <param name="unsupportedExpressions">The value to set</param>
		/// <returns><see cref="SearchRestrictionsConfiguration"/></returns>
		public SearchRestrictionsConfiguration HasUnsupportedExpressions(SearchExpressions unsupportedExpressions)
		{
			_unsupportedExpressions = unsupportedExpressions;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
