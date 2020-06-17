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
	/// Restrictions for function or action operation
	/// </summary>
	public partial class OperationRestrictionsConfiguration : VocabularyConfiguration
	{
		private bool? _filterSegmentSupported;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="OperationRestrictionsConfiguration"/>
        /// </summary>
		public OperationRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.OperationRestrictions")
		{
		}

		/// <summary>
		/// Bound action or function can be invoked on a collection-valued binding parameter path with a `/$filter(...)` segment
		/// </summary>
		/// <param name="filterSegmentSupported">The value to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration HasFilterSegmentSupported(bool filterSegmentSupported)
		{
			_filterSegmentSupported = filterSegmentSupported;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to invoke an action or function
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration AddPermissions(params PermissionTypeConfiguration[] permissions)
		{
			foreach (var item in permissions)
			{
				_ = _permissions.Add(item);
			}

			return this;
		}

		/// <summary>
		/// Supported or required custom headers
		/// </summary>
		/// <param name="customHeaders">The value(s) to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration AddCustomHeaders(params CustomParameterConfiguration[] customHeaders)
		{
			foreach (var item in customHeaders)
			{
				_ = _customHeaders.Add(item);
			}

			return this;
		}

		/// <summary>
		/// Supported or required custom query options
		/// </summary>
		/// <param name="customQueryOptions">The value(s) to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration AddCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
		{
			foreach (var item in customQueryOptions)
			{
				_ = _customQueryOptions.Add(item);
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
