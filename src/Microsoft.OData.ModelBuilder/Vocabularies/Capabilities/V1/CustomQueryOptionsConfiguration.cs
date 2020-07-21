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
	/// Custom query options that are supported/required for the annotated resource
	/// If the entity container is annotated, the query option is supported/required by all resources in that container.
	/// </summary>
	public partial class CustomQueryOptionsConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<CustomParameterConfiguration> _customQueryOptions = new HashSet<CustomParameterConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="CustomQueryOptionsConfiguration"/>
        /// </summary>
		public CustomQueryOptionsConfiguration()
			: base("Org.OData.Capabilities.V1.CustomQueryOptions")
		{
		}

		/// <summary>
		/// Custom query options that are supported/required for the annotated resource
		/// If the entity container is annotated, the query option is supported/required by all resources in that container.
		/// </summary>
		/// <param name="customQueryOptionsConfiguration">The configuration to set</param>
		/// <returns><see cref="CustomQueryOptionsConfiguration"/></returns>
		public CustomQueryOptionsConfiguration HasCustomQueryOptions(Func<CustomParameterConfiguration, CustomParameterConfiguration> customQueryOptionsConfiguration)
		{
			var customQueryOptions = customQueryOptionsConfiguration?.Invoke(new CustomParameterConfiguration());
			return HasCustomQueryOptions(customQueryOptions);
		}

		/// <summary>
		/// Custom query options that are supported/required for the annotated resource
		/// If the entity container is annotated, the query option is supported/required by all resources in that container.
		/// </summary>
		/// <param name="customQueryOptions">The value(s) to set</param>
		/// <returns><see cref="CustomQueryOptionsConfiguration"/></returns>
		public CustomQueryOptionsConfiguration HasCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
		{
			_customQueryOptions.UnionWith(customQueryOptions);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

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
