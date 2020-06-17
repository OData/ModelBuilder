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
	/// Summary
/// 
	/// </summary>
	public partial class ScopeTypeConfiguration : IRecord
	{
		private string _scope;
		private string _restrictedProperties;

        /// <summary>
        /// Creates a new instance of <see cref="ScopeTypeConfiguration"/>
        /// </summary>
		public ScopeTypeConfiguration()
		{
		}

		/// <summary>
		/// Name of the scope.
		/// </summary>
		/// <param name="scope">The value to set</param>
		/// <returns><see cref="ScopeTypeConfiguration"/></returns>
		public ScopeTypeConfiguration HasScope(string scope)
		{
			_scope = scope;
			return this;
		}

		/// <summary>
		/// Comma-separated string value of all properties that will be included or excluded when using the scope.
		/// </summary>
		/// <param name="restrictedProperties">The value to set</param>
		/// <returns><see cref="ScopeTypeConfiguration"/></returns>
		public ScopeTypeConfiguration HasRestrictedProperties(string restrictedProperties)
		{
			_restrictedProperties = restrictedProperties;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
