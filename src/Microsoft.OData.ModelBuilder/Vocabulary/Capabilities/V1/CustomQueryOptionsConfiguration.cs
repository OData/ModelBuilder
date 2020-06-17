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
	/// </summary>
	public partial class CustomQueryOptionsConfiguration : VocabularyConfiguration
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
		/// </summary>
		/// <param name="customQueryOptions">The value(s) to set</param>
		/// <returns><see cref="CustomQueryOptionsConfiguration"/></returns>
		public CustomQueryOptionsConfiguration AddCustomQueryOptions(params CustomParameterConfiguration[] customQueryOptions)
		{
			foreach (var item in customQueryOptions)
			{
				_ = _customQueryOptions.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
