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
	public partial class BatchSupportedConfiguration : VocabularyConfiguration
	{
		private bool? _batchSupported;

        /// <summary>
        /// Creates a new instance of <see cref="BatchSupportedConfiguration"/>
        /// </summary>
		public BatchSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.BatchSupported")
		{
		}

		/// <summary>
		/// Supports $batch requests. Services that apply the BatchSupported term should also apply the more comprehensive BatchSupport term.
		/// </summary>
		/// <param name="batchSupported">The value to set</param>
		/// <returns><see cref="BatchSupportedConfiguration"/></returns>
		public BatchSupportedConfiguration HasBatchSupported(bool batchSupported)
		{
			_batchSupported = batchSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
