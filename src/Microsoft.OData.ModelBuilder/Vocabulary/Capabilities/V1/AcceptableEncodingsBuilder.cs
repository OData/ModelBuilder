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
	/// List of acceptable compression methods for ($batch) requests, e.g. gzip
	/// </summary>
	public partial class AcceptableEncodingsBuilder : VocabularyBuilder
	{
        /// <summary>
        /// Creates a new instance of <see cref="AcceptableEncodingsBuilder"/>
        /// </summary>
		public AcceptableEncodingsBuilder()
			: base("Org.OData.Capabilities.V1.AcceptableEncodings")
		{
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
