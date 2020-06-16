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
	/// Supports $batch requests. Services that apply the BatchSupported term should also apply the more comprehensive BatchSupport term.
	/// </summary>
	public partial class BatchSupportedBuilder : VocabularyBuilder
	{
        /// <summary>
        /// Creates a new instance of <see cref="BatchSupportedBuilder"/>
        /// </summary>
		public BatchSupportedBuilder()
			: base("Org.OData.Capabilities.V1.BatchSupported")
		{
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
