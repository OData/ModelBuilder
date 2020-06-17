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
	/// Supports cross joins for the entity sets in this container
	/// </summary>
	public partial class CrossJoinSupportedConfiguration : VocabularyConfiguration
	{
		private bool? _crossJoinSupported;

        /// <summary>
        /// Creates a new instance of <see cref="CrossJoinSupportedConfiguration"/>
        /// </summary>
		public CrossJoinSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.CrossJoinSupported")
		{
		}

		/// <summary>
		/// Supports cross joins for the entity sets in this container
		/// </summary>
		/// <param name="crossJoinSupported">The value to set</param>
		/// <returns><see cref="CrossJoinSupportedConfiguration"/></returns>
		public CrossJoinSupportedConfiguration HasCrossJoinSupported(bool crossJoinSupported)
		{
			_crossJoinSupported = crossJoinSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
