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
	public partial class QuerySegmentSupportedBuilder : VocabularyBuilder
	{
        /// <summary>
        /// Creates a new instance of <see cref="QuerySegmentSupportedBuilder"/>
        /// </summary>
		public QuerySegmentSupportedBuilder()
			: base("Org.OData.Capabilities.V1.QuerySegmentSupported")
		{
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
