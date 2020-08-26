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
	public partial class BatchContinueOnErrorSupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _batchContinueOnErrorSupported;

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.BatchContinueOnErrorSupported";

		/// <summary>
		/// Service supports the continue on error preference. Supports $batch requests. Services that apply the BatchContinueOnErrorSupported term should also specify the ContinueOnErrorSupported property from the BatchSupport term.
		/// </summary>
		/// <param name="batchContinueOnErrorSupported">The value to set</param>
		/// <returns><see cref="BatchContinueOnErrorSupportedConfiguration"/></returns>
		public BatchContinueOnErrorSupportedConfiguration IsBatchContinueOnErrorSupported(bool batchContinueOnErrorSupported)
		{
			_batchContinueOnErrorSupported = batchContinueOnErrorSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_batchContinueOnErrorSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("BatchContinueOnErrorSupported", new EdmBooleanConstant(_batchContinueOnErrorSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
