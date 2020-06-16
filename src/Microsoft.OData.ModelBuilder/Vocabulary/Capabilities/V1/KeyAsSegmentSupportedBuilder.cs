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
	/// Supports [key-as-segment convention](http://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_KeyasSegmentConvention) for addressing entities within a collection
	/// </summary>
	public partial class KeyAsSegmentSupportedBuilder : VocabularyBuilder
	{
        /// <summary>
        /// Creates a new instance of <see cref="KeyAsSegmentSupportedBuilder"/>
        /// </summary>
		public KeyAsSegmentSupportedBuilder()
			: base("Org.OData.Capabilities.V1.KeyAsSegmentSupported")
		{
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
