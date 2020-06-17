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
	/// Supports $skip
	/// </summary>
	public partial class SkipSupportedConfiguration : VocabularyConfiguration
	{
		private bool? _skipSupported;

        /// <summary>
        /// Creates a new instance of <see cref="SkipSupportedConfiguration"/>
        /// </summary>
		public SkipSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.SkipSupported")
		{
		}

		/// <summary>
		/// Supports $skip
		/// </summary>
		/// <param name="skipSupported">The value to set</param>
		/// <returns><see cref="SkipSupportedConfiguration"/></returns>
		public SkipSupportedConfiguration HasSkipSupported(bool skipSupported)
		{
			_skipSupported = skipSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
