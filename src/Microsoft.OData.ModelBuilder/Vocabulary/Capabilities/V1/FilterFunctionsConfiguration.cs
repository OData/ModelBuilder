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
	/// List of functions and operators supported in filter expressions.
	/// If not specified, null, or empty, all functions and operators may be attempted.
	/// </summary>
	public partial class FilterFunctionsConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<string> _filterFunctions = new HashSet<string>();

        /// <summary>
        /// Creates a new instance of <see cref="FilterFunctionsConfiguration"/>
        /// </summary>
		public FilterFunctionsConfiguration()
			: base("Org.OData.Capabilities.V1.FilterFunctions")
		{
		}

		/// <summary>
		/// List of functions and operators supported in filter expressions.
		/// If not specified, null, or empty, all functions and operators may be attempted.
		/// </summary>
		/// <param name="filterFunctions">The value(s) to set</param>
		/// <returns><see cref="FilterFunctionsConfiguration"/></returns>
		public FilterFunctionsConfiguration AddFilterFunctions(params string[] filterFunctions)
		{
			foreach (var item in filterFunctions)
			{
				_ = _filterFunctions.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_filterFunctions.Any())
			{
				var collection = _filterFunctions.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("FilterFunctions", new EdmCollectionExpression(collection)));
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
