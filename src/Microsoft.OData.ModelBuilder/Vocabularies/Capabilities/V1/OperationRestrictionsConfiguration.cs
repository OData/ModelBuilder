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
	public partial class OperationRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private bool? _filterSegmentSupported;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.OperationRestrictions";

		/// <summary>
		/// Bound action or function can be invoked on a collection-valued binding parameter path with a `/$filter(...)` segment
		/// </summary>
		/// <param name="filterSegmentSupported">The value to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration IsFilterSegmentSupported(bool filterSegmentSupported)
		{
			_filterSegmentSupported = filterSegmentSupported;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to invoke an action or function
		/// </summary>
		/// <param name="permissionsConfiguration">The configuration to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration HasPermissions(Func<PermissionTypeConfiguration, PermissionTypeConfiguration> permissionsConfiguration)
		{
			var instance = new PermissionTypeConfiguration();
			instance = permissionsConfiguration?.Invoke(instance);
			return HasPermissions(instance);
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to invoke an action or function
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration HasPermissions(params PermissionTypeConfiguration[] permissions)
		{
			_permissions.UnionWith(permissions);
			return this;
		}

		/// <summary>
		/// Supported or required custom headers
		/// </summary>
		/// <param name="customHeadersConfiguration">The configuration to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration HasCustomHeaders(Func<CustomParameterConfiguration, CustomParameterConfiguration> customHeadersConfiguration)
		{
			var instance = new CustomParameterConfiguration();
			instance = customHeadersConfiguration?.Invoke(instance);
			return HasCustomHeaders(instance);
		}

		/// <summary>
		/// Supported or required custom headers
		/// </summary>
		/// <param name="customHeaders">The value(s) to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration HasCustomHeaders(params CustomParameterConfiguration[] customHeaders)
		{
			_customHeaders.UnionWith(customHeaders);
			return this;
		}

		/// <summary>
		/// Supported or required custom query options
		/// </summary>
		/// <param name="customQueryOptionsConfiguration">The configuration to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration HasCustomQueryOptions(Func<CustomParameterConfiguration, CustomParameterConfiguration> customQueryOptionsConfiguration)
		{
			var instance = new CustomParameterConfiguration();
			instance = customQueryOptionsConfiguration?.Invoke(instance);
			return HasCustomQueryOptions(instance);
		}

		/// <summary>
		/// Supported or required custom query options
		/// </summary>
		/// <param name="customQueryOptions">The value(s) to set</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public OperationRestrictionsConfiguration HasCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
		{
			_customQueryOptions.UnionWith(customQueryOptions);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_filterSegmentSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("FilterSegmentSupported", new EdmBooleanConstant(_filterSegmentSupported.Value)));
			}

			if (_permissions.Any())
			{
				var collection = _permissions.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("Permissions", new EdmCollectionExpression(collection)));
				}
			}

			if (_customHeaders.Any())
			{
				var collection = _customHeaders.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("CustomHeaders", new EdmCollectionExpression(collection)));
				}
			}

			if (_customQueryOptions.Any())
			{
				var collection = _customQueryOptions.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("CustomQueryOptions", new EdmCollectionExpression(collection)));
				}
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
