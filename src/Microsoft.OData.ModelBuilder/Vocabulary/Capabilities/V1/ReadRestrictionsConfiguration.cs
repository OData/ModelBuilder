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
	/// Restrictions for retrieving a collection of entities, retrieving a singleton instance.
	/// </summary>
	public partial class ReadRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private bool? _readable;
		private readonly HashSet<PermissionTypeConfiguration> _permissions = new HashSet<PermissionTypeConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customHeaders = new HashSet<CustomParameterConfiguration>();
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();
		private string _description;
		private string _longDescription;
		private ReadByKeyRestrictionsTypeConfiguration _readByKeyRestrictions;

        /// <summary>
        /// Creates a new instance of <see cref="ReadRestrictionsConfiguration"/>
        /// </summary>
		public ReadRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.ReadRestrictions")
		{
		}

		/// <summary>
		/// Entities can be retrieved
		/// </summary>
		/// <param name="readable">The value to set</param>
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public ReadRestrictionsConfiguration HasReadable(bool readable)
		{
			_readable = readable;
			return this;
		}

		/// <summary>
		/// Required permissions. One of the specified sets of scopes is required to read.
		/// </summary>
		/// <param name="permissions">The value(s) to set</param>
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public ReadRestrictionsConfiguration AddPermissions(params PermissionTypeConfiguration[] permissions)
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
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public ReadRestrictionsConfiguration AddCustomHeaders(params CustomParameterConfiguration[] customHeaders)
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
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public ReadRestrictionsConfiguration AddCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
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
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public ReadRestrictionsConfiguration HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// A lengthy description of the request
		/// </summary>
		/// <param name="longDescription">The value to set</param>
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public ReadRestrictionsConfiguration HasLongDescription(string longDescription)
		{
			_longDescription = longDescription;
			return this;
		}

		/// <summary>
		/// Restrictions for retrieving an entity by key
		/// Only valid when applied to a collection. If a property of `ReadByKeyRestrictions` is not specified, the corresponding property value of `ReadRestrictions` applies.
		/// </summary>
		/// <param name="readByKeyRestrictions">The value to set</param>
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public ReadRestrictionsConfiguration HasReadByKeyRestrictions(ReadByKeyRestrictionsTypeConfiguration readByKeyRestrictions)
		{
			_readByKeyRestrictions = readByKeyRestrictions;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
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

			if (!string.IsNullOrEmpty(_description))
			{
				properties.Add(new EdmPropertyConstructor("Description", new EdmStringConstant(_description)));
			}

			if (!string.IsNullOrEmpty(_longDescription))
			{
				properties.Add(new EdmPropertyConstructor("LongDescription", new EdmStringConstant(_longDescription)));
			}

			if (_readByKeyRestrictions != null)
			{
				properties.Add(new EdmPropertyConstructor("ReadByKeyRestrictions", _readByKeyRestrictions.ToEdmExpression()));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
