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
	/// Describes restrictions on operations applied to collection-valued structural properties
	/// </summary>
	public partial class CollectionPropertyRestrictionsConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<CollectionPropertyRestrictionsTypeConfiguration> _collectionPropertyRestrictions = new HashSet<CollectionPropertyRestrictionsTypeConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="CollectionPropertyRestrictionsConfiguration"/>
        /// </summary>
		public CollectionPropertyRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.CollectionPropertyRestrictions")
		{
		}

		/// <summary>
		/// Describes restrictions on operations applied to collection-valued structural properties
		/// </summary>
		/// <param name="collectionPropertyRestrictions">The value(s) to set</param>
		/// <returns><see cref="CollectionPropertyRestrictionsConfiguration"/></returns>
		public CollectionPropertyRestrictionsConfiguration AddCollectionPropertyRestrictions(params CollectionPropertyRestrictionsTypeConfiguration[] collectionPropertyRestrictions)
		{
			foreach (var item in collectionPropertyRestrictions)
			{
				_ = _collectionPropertyRestrictions.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_collectionPropertyRestrictions.Any())
			{
				var collection = _collectionPropertyRestrictions.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("CollectionPropertyRestrictions", new EdmCollectionExpression(collection)));
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
