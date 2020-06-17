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
	/// Restrictions for retrieving an entity by key
	/// </summary>
	public partial class ReadByKeyRestrictionsTypeConfiguration : IRecord
	{
		private bool? _readable;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();
		private string _description;
		private string _longDescription;

        /// <summary>
        /// Creates a new instance of <see cref="ReadByKeyRestrictionsTypeConfiguration"/>
        /// </summary>
		public ReadByKeyRestrictionsTypeConfiguration()
		{
		}

		/// <summary>
		/// Entities can be retrieved
		/// </summary>
		/// <param name="readable">The value to set</param>
		/// <returns><see cref="ReadByKeyRestrictionsTypeConfiguration"/></returns>
		public ReadByKeyRestrictionsTypeConfiguration HasReadable(bool readable)
		{
			_readable = readable;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to read.
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="ReadByKeyRestrictionsTypeConfiguration"/></returns>
		public ReadByKeyRestrictionsTypeConfiguration AddPermissions(params PermissionTypeConfiguration[] permissions)
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
		/// <returns><see cref="ReadByKeyRestrictionsTypeConfiguration"/></returns>
		public ReadByKeyRestrictionsTypeConfiguration AddCustomHeaders(params CustomParameterConfiguration[] customHeaders)
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
		/// <returns><see cref="ReadByKeyRestrictionsTypeConfiguration"/></returns>
		public ReadByKeyRestrictionsTypeConfiguration AddCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
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
		/// <returns><see cref="ReadByKeyRestrictionsTypeConfiguration"/></returns>
		public ReadByKeyRestrictionsTypeConfiguration HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// A lengthy description of the request
		/// </summary>
		/// <param name="longDescription">The value to set</param>
		/// <returns><see cref="ReadByKeyRestrictionsTypeConfiguration"/></returns>
		public ReadByKeyRestrictionsTypeConfiguration HasLongDescription(string longDescription)
		{
			_longDescription = longDescription;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_readable.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Readable", new EdmBooleanConstant(_readable.Value)));
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

			if (string.IsNullOrEmpty(_description))
			{
				properties.Add(new EdmPropertyConstructor("Description", new EdmStringConstant(_description)));
			}

			if (string.IsNullOrEmpty(_longDescription))
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
