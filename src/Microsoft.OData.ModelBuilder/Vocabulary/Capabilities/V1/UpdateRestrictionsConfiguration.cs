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
	/// Restrictions on update operations
	/// </summary>
	public partial class UpdateRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private bool? _updatable;
		private bool? _upsertable;
		private bool? _deltaUpdateSupported;
		private bool? _filterSegmentSupported;
		private bool? _typecastSegmentSupported;
		private readonly HashSet<EdmNavigationPropertyPathExpression> _nonUpdatableNavigationProperties = new HashSet<EdmNavigationPropertyPathExpression>();
		private int? _maxLevels;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private ModificationQueryOptionsConfiguration _queryOptions;
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();
		private string _description;
		private string _longDescription;

        /// <summary>
        /// Creates a new instance of <see cref="UpdateRestrictionsConfiguration"/>
        /// </summary>
		public UpdateRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.UpdateRestrictions")
		{
		}

		/// <summary>
		/// Entities can be updated
		/// </summary>
		/// <param name="updatable">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration IsUpdatable(bool updatable)
		{
			_updatable = updatable;
			return this;
		}

		/// <summary>
		/// Entities can be upserted
		/// </summary>
		/// <param name="upsertable">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration IsUpsertable(bool upsertable)
		{
			_upsertable = upsertable;
			return this;
		}

		/// <summary>
		/// Entities can be inserted, updated, and deleted via a PATCH request with a delta payload
		/// </summary>
		/// <param name="deltaUpdateSupported">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration IsDeltaUpdateSupported(bool deltaUpdateSupported)
		{
			_deltaUpdateSupported = deltaUpdateSupported;
			return this;
		}

		/// <summary>
		/// Members of collections can be updated via a PATCH request with a `/$filter(...)/$each` segment
		/// </summary>
		/// <param name="filterSegmentSupported">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration IsFilterSegmentSupported(bool filterSegmentSupported)
		{
			_filterSegmentSupported = filterSegmentSupported;
			return this;
		}

		/// <summary>
		/// Members of collections can be updated via a PATCH request with a type-cast segment and a `/$each` segment
		/// </summary>
		/// <param name="typecastSegmentSupported">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration IsTypecastSegmentSupported(bool typecastSegmentSupported)
		{
			_typecastSegmentSupported = typecastSegmentSupported;
			return this;
		}

		/// <summary>
		/// These navigation properties do not allow rebinding
		/// </summary>
		/// <param name="nonUpdatableNavigationProperties">The value(s) to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration AddNonUpdatableNavigationProperties(params EdmNavigationPropertyPathExpression[] nonUpdatableNavigationProperties)
		{
			foreach (var item in nonUpdatableNavigationProperties)
			{
				_ = _nonUpdatableNavigationProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// The maximum number of navigation properties that can be traversed when addressing the collection or entity to update. A value of -1 indicates there is no restriction.
		/// </summary>
		/// <param name="maxLevels">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration HasMaxLevels(int maxLevels)
		{
			_maxLevels = maxLevels;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to perform the update.
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration AddPermissions(params PermissionTypeConfiguration[] permissions)
		{
			foreach (var item in permissions)
			{
				_ = _permissions.Add(item);
			}

			return this;
		}

		/// <summary>
		/// Support for query options with update requests
		/// </summary>
		/// <param name="queryOptions">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration HasQueryOptions(ModificationQueryOptionsConfiguration queryOptions)
		{
			_queryOptions = queryOptions;
			return this;
		}

		/// <summary>
		/// Supported or required custom headers
		/// </summary>
		/// <param name="customHeaders">The value(s) to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration AddCustomHeaders(params CustomParameterConfiguration[] customHeaders)
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
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration AddCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
		{
			foreach (var item in customQueryOptions)
			{
				_ = _customQueryOptions.Add(item);
			}

			return this;
		}

		/// <summary>
		/// A brief description of the request
		/// </summary>
		/// <param name="description">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// A lengthy description of the request
		/// </summary>
		/// <param name="longDescription">The value to set</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public UpdateRestrictionsConfiguration HasLongDescription(string longDescription)
		{
			_longDescription = longDescription;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_updatable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Updatable", new EdmBooleanConstant(_updatable.Value)));
			}

			if (_upsertable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Upsertable", new EdmBooleanConstant(_upsertable.Value)));
			}

			if (_deltaUpdateSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("DeltaUpdateSupported", new EdmBooleanConstant(_deltaUpdateSupported.Value)));
			}

			if (_filterSegmentSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("FilterSegmentSupported", new EdmBooleanConstant(_filterSegmentSupported.Value)));
			}

			if (_typecastSegmentSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("TypecastSegmentSupported", new EdmBooleanConstant(_typecastSegmentSupported.Value)));
			}

			if (_nonUpdatableNavigationProperties.Any())
			{
				var collection = _nonUpdatableNavigationProperties.Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("NonUpdatableNavigationProperties", new EdmCollectionExpression(collection)));
				}
			}

			if (_maxLevels.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("MaxLevels", new EdmIntegerConstant(_maxLevels.Value)));
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
