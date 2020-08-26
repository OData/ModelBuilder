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
	public partial class SearchRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private bool? _searchable;
		private SearchExpressions? _unsupportedExpressions;

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.SearchRestrictions";

		/// <summary>
		/// $search is supported
		/// </summary>
		/// <param name="searchable">The value to set</param>
		/// <returns><see cref="SearchRestrictionsConfiguration"/></returns>
		public SearchRestrictionsConfiguration IsSearchable(bool searchable)
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
			var properties = new List<IEdmPropertyConstructor>();

			if (_searchable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Searchable", new EdmBooleanConstant(_searchable.Value)));
			}

			if (_unsupportedExpressions.HasValue)
			{
				// properties.Add(new EdmPropertyConstructor("UnsupportedExpressions", new EdmEnumValue(_unsupportedExpressions.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
