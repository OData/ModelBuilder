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
	/// Org.OData.Capabilities.V1.ScopeType
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
		/// Possible string value identifiers when specifying properties are '*', _PropertyName_, '-'_PropertyName_. Where, '*' denotes all properties are accessible,'-'_PropertyName_ excludes that specific property and _PropertyName_ explicitly provides access to the specific property. The absence of 'RestrictedProperties' denotes all properties are accessible using that scope.
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
			var properties = new List<IEdmPropertyConstructor>();

			if (!string.IsNullOrEmpty(_scope))
			{
				properties.Add(new EdmPropertyConstructor("Scope", new EdmStringConstant(_scope)));
			}

			if (!string.IsNullOrEmpty(_restrictedProperties))
			{
				properties.Add(new EdmPropertyConstructor("RestrictedProperties", new EdmStringConstant(_restrictedProperties)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
