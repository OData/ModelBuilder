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
	/// Restrictions on expand expressions
	/// </summary>
	public partial class ExpandRestrictionsConfiguration : VocabularyConfiguration
	{
		private bool? _expandable;
		private bool? _streamsExpandable;
		private readonly HashSet<EdmNavigationPropertyPathExpression> _nonExpandableProperties = new HashSet<EdmNavigationPropertyPathExpression>();
		private int? _maxLevels;

        /// <summary>
        /// Creates a new instance of <see cref="ExpandRestrictionsConfiguration"/>
        /// </summary>
		public ExpandRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.ExpandRestrictions")
		{
		}

		/// <summary>
		/// $expand is supported
		/// </summary>
		/// <param name="expandable">The value to set</param>
		/// <returns><see cref="ExpandRestrictionsConfiguration"/></returns>
		public ExpandRestrictionsConfiguration HasExpandable(bool expandable)
		{
			_expandable = expandable;
			return this;
		}

		/// <summary>
		/// $expand is supported for stream properties and media resources
		/// </summary>
		/// <param name="streamsExpandable">The value to set</param>
		/// <returns><see cref="ExpandRestrictionsConfiguration"/></returns>
		public ExpandRestrictionsConfiguration HasStreamsExpandable(bool streamsExpandable)
		{
			_streamsExpandable = streamsExpandable;
			return this;
		}

		/// <summary>
		/// These properties cannot be used in expand expressions
		/// </summary>
		/// <param name="nonExpandableProperties">The value(s) to set</param>
		/// <returns><see cref="ExpandRestrictionsConfiguration"/></returns>
		public ExpandRestrictionsConfiguration AddNonExpandableProperties(params EdmNavigationPropertyPathExpression[] nonExpandableProperties)
		{
			foreach (var item in nonExpandableProperties)
			{
				_ = _nonExpandableProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// The maximum number of levels that can be expanded in a expand expression. A value of -1 indicates there is no restriction.
		/// </summary>
		/// <param name="maxLevels">The value to set</param>
		/// <returns><see cref="ExpandRestrictionsConfiguration"/></returns>
		public ExpandRestrictionsConfiguration HasMaxLevels(int maxLevels)
		{
			_maxLevels = maxLevels;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
