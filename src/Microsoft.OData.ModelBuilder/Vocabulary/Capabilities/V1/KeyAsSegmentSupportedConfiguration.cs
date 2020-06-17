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
	public partial class KeyAsSegmentSupportedConfiguration : VocabularyConfiguration
	{
		private bool? _keyAsSegmentSupported;

        /// <summary>
        /// Creates a new instance of <see cref="KeyAsSegmentSupportedConfiguration"/>
        /// </summary>
		public KeyAsSegmentSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.KeyAsSegmentSupported")
		{
		}

		/// <summary>
		/// Supports [key-as-segment convention](http://docs.oasis-open.org/odata/odata/v4.01/odata-v4.01-part2-url-conventions.html#sec_KeyasSegmentConvention) for addressing entities within a collection
		/// </summary>
		/// <param name="keyAsSegmentSupported">The value to set</param>
		/// <returns><see cref="KeyAsSegmentSupportedConfiguration"/></returns>
		public KeyAsSegmentSupportedConfiguration HasKeyAsSegmentSupported(bool keyAsSegmentSupported)
		{
			_keyAsSegmentSupported = keyAsSegmentSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
