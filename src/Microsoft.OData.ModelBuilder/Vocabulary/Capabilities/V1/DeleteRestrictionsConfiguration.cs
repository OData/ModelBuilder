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
	/// Restrictions on delete operations
	/// </summary>
	public partial class DeleteRestrictionsConfiguration : VocabularyConfiguration
	{
		private bool? _deletable;
		private readonly HashSet<EdmNavigationPropertyPathExpression> _nonDeletableNavigationProperties = new HashSet<EdmNavigationPropertyPathExpression>();
		private int? _maxLevels;
		private bool? _filterSegmentSupported;
		private bool? _typecastSegmentSupported;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();
		private string _description;
		private string _longDescription;

        /// <summary>
        /// Creates a new instance of <see cref="DeleteRestrictionsConfiguration"/>
        /// </summary>
		public DeleteRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.DeleteRestrictions")
		{
		}

		/// <summary>
		/// Entities can be deleted
		/// </summary>
		/// <param name="deletable">The value to set</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration HasDeletable(bool deletable)
		{
			_deletable = deletable;
			return this;
		}

		/// <summary>
		/// These navigation properties do not allow DeleteLink requests
		/// </summary>
		/// <param name="nonDeletableNavigationProperties">The value(s) to set</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration AddNonDeletableNavigationProperties(params EdmNavigationPropertyPathExpression[] nonDeletableNavigationProperties)
		{
			foreach (var item in nonDeletableNavigationProperties)
			{
				_ = _nonDeletableNavigationProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// The maximum number of navigation properties that can be traversed when addressing the collection to delete from or the entity to delete. A value of -1 indicates there is no restriction.
		/// </summary>
		/// <param name="maxLevels">The value to set</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration HasMaxLevels(int maxLevels)
		{
			_maxLevels = maxLevels;
			return this;
		}

		/// <summary>
		/// Members of collections can be updated via a PATCH request with a `/$filter(...)/$each` segment
		/// </summary>
		/// <param name="filterSegmentSupported">The value to set</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration HasFilterSegmentSupported(bool filterSegmentSupported)
		{
			_filterSegmentSupported = filterSegmentSupported;
			return this;
		}

		/// <summary>
		/// Members of collections can be updated via a PATCH request with a type-cast segment and a `/$each` segment
		/// </summary>
		/// <param name="typecastSegmentSupported">The value to set</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration HasTypecastSegmentSupported(bool typecastSegmentSupported)
		{
			_typecastSegmentSupported = typecastSegmentSupported;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to perform the delete.
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration AddPermissions(params PermissionTypeConfiguration[] permissions)
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
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration AddCustomHeaders(params CustomParameterConfiguration[] customHeaders)
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
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration AddCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
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
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// A lengthy description of the request
		/// </summary>
		/// <param name="longDescription">The value to set</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public DeleteRestrictionsConfiguration HasLongDescription(string longDescription)
		{
			_longDescription = longDescription;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
