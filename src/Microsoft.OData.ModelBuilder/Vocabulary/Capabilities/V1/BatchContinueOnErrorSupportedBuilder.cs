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
	/// Service supports the continue on error preference. Supports $batch requests. Services that apply the BatchContinueOnErrorSupported term should also specify the ContinueOnErrorSupported property from the BatchSupport term.
	/// </summary>
	public partial class BatchContinueOnErrorSupportedBuilder : VocabularyBuilder
	{
        /// <summary>
        /// Creates a new instance of <see cref="BatchContinueOnErrorSupportedBuilder"/>
        /// </summary>
		public BatchContinueOnErrorSupportedBuilder()
			: base("Org.OData.Capabilities.V1.BatchContinueOnErrorSupported")
		{
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
