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
	/// Restrictions on insert operations
	/// </summary>
	public partial class InsertRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private bool? _insertable;
		private readonly HashSet<EdmPropertyPathExpression> _nonInsertableProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmNavigationPropertyPathExpression> _nonInsertableNavigationProperties = new HashSet<EdmNavigationPropertyPathExpression>();
		private int? _maxLevels;
		private bool? _typecastSegmentSupported;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private ModificationQueryOptionsConfiguration _queryOptions;
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();
		private string _description;
		private string _longDescription;

        /// <summary>
        /// Creates a new instance of <see cref="InsertRestrictionsConfiguration"/>
        /// </summary>
		public InsertRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.InsertRestrictions")
		{
		}

		/// <summary>
		/// Entities can be inserted
		/// </summary>
		/// <param name="insertable">The value to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration IsInsertable(bool insertable)
		{
			_insertable = insertable;
			return this;
		}

		/// <summary>
		/// These structural properties cannot be specified on insert
		/// </summary>
		/// <param name="nonInsertableProperties">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasNonInsertableProperties(params EdmPropertyPathExpression[] nonInsertableProperties)
		{
			_nonInsertableProperties.UnionWith(nonInsertableProperties);
			return this;
		}

		/// <summary>
		/// These navigation properties do not allow deep inserts
		/// </summary>
		/// <param name="nonInsertableNavigationProperties">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasNonInsertableNavigationProperties(params EdmNavigationPropertyPathExpression[] nonInsertableNavigationProperties)
		{
			_nonInsertableNavigationProperties.UnionWith(nonInsertableNavigationProperties);
			return this;
		}

		/// <summary>
		/// The maximum number of navigation properties that can be traversed when addressing the collection to insert into. A value of -1 indicates there is no restriction.
		/// </summary>
		/// <param name="maxLevels">The value to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasMaxLevels(int maxLevels)
		{
			_maxLevels = maxLevels;
			return this;
		}

		/// <summary>
		/// Entities of a specific derived type can be created by specifying a type-cast segment
		/// </summary>
		/// <param name="typecastSegmentSupported">The value to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration IsTypecastSegmentSupported(bool typecastSegmentSupported)
		{
			_typecastSegmentSupported = typecastSegmentSupported;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to perform the insert.
		/// </summary>
		/// <param name="permissionsConfiguration">The configuration to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasPermissions(Func<PermissionTypeConfiguration, PermissionTypeConfiguration> permissionsConfiguration)
		{
			var permissions = permissionsConfiguration?.Invoke(new PermissionTypeConfiguration());
			return HasPermissions(permissions);
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to perform the insert.
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasPermissions(params PermissionTypeConfiguration[] permissions)
		{
			_permissions.UnionWith(permissions);
			return this;
		}

		/// <summary>
		/// Support for query options with insert requests
		/// </summary>
		/// <param name="queryOptionsConfiguration">The configuration to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasQueryOptions(Func<ModificationQueryOptionsConfiguration, ModificationQueryOptionsConfiguration> queryOptionsConfiguration)
		{
			var queryOptions = queryOptionsConfiguration?.Invoke(new ModificationQueryOptionsConfiguration());
			return HasQueryOptions(queryOptions);
		}

		/// <summary>
		/// Support for query options with insert requests
		/// </summary>
		/// <param name="queryOptions">The value to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasQueryOptions(ModificationQueryOptionsConfiguration queryOptions)
		{
			_queryOptions = queryOptions;
			return this;
		}

		/// <summary>
		/// Supported or required custom headers
		/// </summary>
		/// <param name="customHeadersConfiguration">The configuration to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasCustomHeaders(Func<CustomParameterConfiguration, CustomParameterConfiguration> customHeadersConfiguration)
		{
			var customHeaders = customHeadersConfiguration?.Invoke(new CustomParameterConfiguration());
			return HasCustomHeaders(customHeaders);
		}

		/// <summary>
		/// Supported or required custom headers
		/// </summary>
		/// <param name="customHeaders">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasCustomHeaders(params CustomParameterConfiguration[] customHeaders)
		{
			_customHeaders.UnionWith(customHeaders);
			return this;
		}

		/// <summary>
		/// Supported or required custom query options
		/// </summary>
		/// <param name="customQueryOptionsConfiguration">The configuration to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasCustomQueryOptions(Func<CustomParameterConfiguration, CustomParameterConfiguration> customQueryOptionsConfiguration)
		{
			var customQueryOptions = customQueryOptionsConfiguration?.Invoke(new CustomParameterConfiguration());
			return HasCustomQueryOptions(customQueryOptions);
		}

		/// <summary>
		/// Supported or required custom query options
		/// </summary>
		/// <param name="customQueryOptions">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
		{
			_customQueryOptions.UnionWith(customQueryOptions);
			return this;
		}

		/// <summary>
		/// A brief description of the request
		/// </summary>
		/// <param name="description">The value to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// A lengthy description of the request
		/// </summary>
		/// <param name="longDescription">The value to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration HasLongDescription(string longDescription)
		{
			_longDescription = longDescription;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_insertable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Insertable", new EdmBooleanConstant(_insertable.Value)));
			}

			if (_nonInsertableProperties.Any())
			{
				var collection = _nonInsertableProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("NonInsertableProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_nonInsertableNavigationProperties.Any())
			{
				var collection = _nonInsertableNavigationProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("NonInsertableNavigationProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_maxLevels.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("MaxLevels", new EdmIntegerConstant(_maxLevels.Value)));
			}

			if (_typecastSegmentSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("TypecastSegmentSupported", new EdmBooleanConstant(_typecastSegmentSupported.Value)));
			}

			if (_permissions.Any())
			{
				var collection = _permissions.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("Permissions", new EdmCollectionExpression(collection)));
				}
			}

			if (_queryOptions != null)
			{
				properties.Add(new EdmPropertyConstructor("QueryOptions", _queryOptions.ToEdmExpression()));
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

			if (!string.IsNullOrEmpty(_description))
			{
				properties.Add(new EdmPropertyConstructor("Description", new EdmStringConstant(_description)));
			}

			if (!string.IsNullOrEmpty(_longDescription))
			{
				properties.Add(new EdmPropertyConstructor("LongDescription", new EdmStringConstant(_longDescription)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
