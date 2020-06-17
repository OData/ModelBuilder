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
	public partial class PermissionTypeConfiguration : IRecord
	{
		private string _schemeName;
		private readonly HashSet<ScopeTypeConfiguration> _scopes = new HashSet<ScopeTypeConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="PermissionTypeConfiguration"/>
        /// </summary>
		public PermissionTypeConfiguration()
		{
		}

		/// <summary>
		/// Authorization flow scheme name
		/// </summary>
		/// <param name="schemeName">The value to set</param>
		/// <returns><see cref="PermissionType"/></returns>
		public PermissionType HasSchemeName(string schemeName)
		{
			_schemeName = schemeName;
			return this;
		}

		/// <summary>
		/// List of scopes that can provide access to the resource
		/// </summary>
		/// <param name="scopes">The value(s) to set</param>
		/// <returns><see cref="PermissionType"/></returns>
		public PermissionType AddScopes(params ScopeTypeConfiguration[] scopes)
		{
			foreach (var item in scopes)
			{
				_ = _scopes.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
