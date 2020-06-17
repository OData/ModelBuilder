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
	public partial class InsertRestrictionsConfiguration : VocabularyConfiguration
	{
		private bool? _insertable;
		private readonly HashSet<EdmPropertyPathExpression> _nonInsertableProperties = new HashSet<EdmPropertyPathExpression>();
		private readonly HashSet<EdmNavigationPropertyPathExpression> _nonInsertableNavigationProperties = new HashSet<EdmNavigationPropertyPathExpression>();
		private int? _maxLevels;
		private bool? _typecastSegmentSupported;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private ModificationQueryOptionsConfiguration _queryOptions;
		private readonly HashSet<CustomHeadersConfiguration> _customHeaders = new HashSet<CustomHeadersConfiguration>();
		private readonly HashSet<CustomHeadersConfiguration> _customQueryOptions = new HashSet<CustomHeadersConfiguration>();
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
		public InsertRestrictionsConfiguration HasInsertable(bool insertable)
		{
			_insertable = insertable;
			return this;
		}

		/// <summary>
		/// These structural properties cannot be specified on insert
		/// </summary>
		/// <param name="nonInsertableProperties">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration AddNonInsertableProperties(params EdmPropertyPathExpression[] nonInsertableProperties)
		{
			foreach (var item in nonInsertableProperties)
			{
				_ = _nonInsertableProperties.Add(item);
			}

			return this;
		}

		/// <summary>
		/// These navigation properties do not allow deep inserts
		/// </summary>
		/// <param name="nonInsertableNavigationProperties">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration AddNonInsertableNavigationProperties(params EdmNavigationPropertyPathExpression[] nonInsertableNavigationProperties)
		{
			foreach (var item in nonInsertableNavigationProperties)
			{
				_ = _nonInsertableNavigationProperties.Add(item);
			}

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
		public InsertRestrictionsConfiguration HasTypecastSegmentSupported(bool typecastSegmentSupported)
		{
			_typecastSegmentSupported = typecastSegmentSupported;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to perform the insert.
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration AddPermissions(params PermissionTypeConfiguration[] permissions)
		{
			foreach (var item in permissions)
			{
				_ = _permissions.Add(item);
			}

			return this;
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
		/// <param name="customHeaders">The value(s) to set</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration AddCustomHeaders(params CustomHeadersConfiguration[] customHeaders)
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
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public InsertRestrictionsConfiguration AddCustomQueryOptions(params CustomHeadersConfiguration[] customQueryOptions)
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
			return null;
		}
	}
}
