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
	public partial class AsynchronousRequestsSupportedConfiguration : VocabularyConfiguration
	{
		private bool? _asynchronousRequestsSupported;

        /// <summary>
        /// Creates a new instance of <see cref="AsynchronousRequestsSupportedConfiguration"/>
        /// </summary>
		public AsynchronousRequestsSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.AsynchronousRequestsSupported")
		{
		}

		/// <summary>
		/// Service supports the asynchronous request preference
		/// </summary>
		/// <param name="asynchronousRequestsSupported">The value to set</param>
		/// <returns><see cref="AsynchronousRequestsSupportedConfiguration"/></returns>
		public AsynchronousRequestsSupportedConfiguration HasAsynchronousRequestsSupported(bool asynchronousRequestsSupported)
		{
			_asynchronousRequestsSupported = asynchronousRequestsSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
