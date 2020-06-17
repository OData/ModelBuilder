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

        /// <summary>
        /// Creates a new instance of <see cref="ReadByKeyRestrictionsTypeConfiguration"/>
        /// </summary>
		public ReadByKeyRestrictionsTypeConfiguration()
		{
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
