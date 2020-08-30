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
	public partial class BatchSupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _batchSupported;

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.BatchSupported";

		/// <summary>
		/// Supports $batch requests. Services that apply the BatchSupported term should also apply the more comprehensive BatchSupport term.
		/// </summary>
		/// <param name="batchSupported">The value to set</param>
		/// <returns><see cref="BatchSupportedConfiguration"/></returns>
		public BatchSupportedConfiguration IsBatchSupported(bool batchSupported)
		{
			_batchSupported = batchSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_batchSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("BatchSupported", new EdmBooleanConstant(_batchSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
