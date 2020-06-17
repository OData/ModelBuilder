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
	/// Supported odata.isolation levels
	/// </summary>
	public partial class IsolationSupportedConfiguration : VocabularyConfiguration
	{
		private IsolationLevel _isolationSupported;

        /// <summary>
        /// Creates a new instance of <see cref="IsolationSupportedConfiguration"/>
        /// </summary>
		public IsolationSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.IsolationSupported")
		{
		}

		/// <summary>
		/// Supported odata.isolation levels
		/// </summary>
		/// <param name="isolationSupported">The value to set</param>
		/// <returns><see cref="IsolationSupportedConfiguration"/></returns>
		public IsolationSupportedConfiguration HasIsolationSupported(IsolationLevel isolationSupported)
		{
			_isolationSupported = isolationSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
