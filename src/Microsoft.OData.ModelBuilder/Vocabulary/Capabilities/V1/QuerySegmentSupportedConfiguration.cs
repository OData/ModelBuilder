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
	/// Supports [passing query options in the request body](http://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_PassingQueryOptionsintheRequestBody)
	/// </summary>
	public partial class QuerySegmentSupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _querySegmentSupported;

        /// <summary>
        /// Creates a new instance of <see cref="QuerySegmentSupportedConfiguration"/>
        /// </summary>
		public QuerySegmentSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.QuerySegmentSupported")
		{
		}

		/// <summary>
		/// Supports [passing query options in the request body](http://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_PassingQueryOptionsintheRequestBody)
		/// </summary>
		/// <param name="querySegmentSupported">The value to set</param>
		/// <returns><see cref="QuerySegmentSupportedConfiguration"/></returns>
		public QuerySegmentSupportedConfiguration HasQuerySegmentSupported(bool querySegmentSupported)
		{
			_querySegmentSupported = querySegmentSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_querySegmentSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("QuerySegmentSupported", new EdmBooleanConstant(_querySegmentSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
