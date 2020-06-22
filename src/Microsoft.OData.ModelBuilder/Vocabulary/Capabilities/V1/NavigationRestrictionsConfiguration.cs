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
	/// Restrictions on navigating properties according to OData URL conventions
	/// Restrictions specified on an entity set are valid whether the request is directly to the entity set or through a navigation property bound to that entity set. Services can specify a different set of restrictions specific to a path, in which case the more specific restrictions take precedence.
	/// </summary>
	public partial class NavigationRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private NavigationType? _navigability;
		private readonly HashSet<NavigationPropertyRestrictionConfiguration> _restrictedProperties = new HashSet<NavigationPropertyRestrictionConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="NavigationRestrictionsConfiguration"/>
        /// </summary>
		public NavigationRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.NavigationRestrictions")
		{
		}

		/// <summary>
		/// Default navigability for all navigation properties of the annotation target. Individual navigation properties can override this value via `RestrictedProperties/Navigability`.
		/// </summary>
		/// <param name="navigability">The value to set</param>
		/// <returns><see cref="NavigationRestrictionsConfiguration"/></returns>
		public NavigationRestrictionsConfiguration HasNavigability(NavigationType navigability)
		{
			_navigability = navigability;
			return this;
		}

		/// <summary>
		/// List of navigation properties with restrictions
		/// </summary>
		/// <param name="restrictedProperties">The value(s) to set</param>
		/// <returns><see cref="NavigationRestrictionsConfiguration"/></returns>
		public NavigationRestrictionsConfiguration AddRestrictedProperties(params NavigationPropertyRestrictionConfiguration[] restrictedProperties)
		{
			_restrictedProperties.UnionWith(restrictedProperties);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_navigability.HasValue)
			{
				// properties.Add(new EdmPropertyConstructor("Navigability", new EdmEnumValue(_navigability.Value)));
			}

			if (_restrictedProperties.Any())
			{
				var collection = _restrictedProperties.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("RestrictedProperties", new EdmCollectionExpression(collection)));
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
