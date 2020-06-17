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
	public partial class ReadRestrictionsConfiguration : VocabularyConfiguration
	{
		private ReadByKeyRestrictionsTypeConfiguration _readByKeyRestrictions;

        /// <summary>
        /// Creates a new instance of <see cref="ReadRestrictionsConfiguration"/>
        /// </summary>
		public ReadRestrictionsConfiguration()
			: base("Org.OData.Capabilities.V1.ReadRestrictions")
		{
		}

		/// <summary>
		/// Restrictions for retrieving an entity by key
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
