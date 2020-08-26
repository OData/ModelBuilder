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
	/// Service supports the asynchronous request preference
	/// </summary>
	public partial class AsynchronousRequestsSupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _asynchronousRequestsSupported;

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.AsynchronousRequestsSupported";

		/// <summary>
		/// Service supports the asynchronous request preference
		/// </summary>
		/// <param name="asynchronousRequestsSupported">The value to set</param>
		/// <returns><see cref="AsynchronousRequestsSupportedConfiguration"/></returns>
		public AsynchronousRequestsSupportedConfiguration IsAsynchronousRequestsSupported(bool asynchronousRequestsSupported)
		{
			_asynchronousRequestsSupported = asynchronousRequestsSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_asynchronousRequestsSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("AsynchronousRequestsSupported", new EdmBooleanConstant(_asynchronousRequestsSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
