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
	/// Supports key values according to OData URL conventions
	/// </summary>
	public partial class IndexableByKeyConfiguration : VocabularyConfiguration
	{
		private bool? _indexableByKey;

        /// <summary>
        /// Creates a new instance of <see cref="IndexableByKeyConfiguration"/>
        /// </summary>
		public IndexableByKeyConfiguration()
			: base("Org.OData.Capabilities.V1.IndexableByKey")
		{
		}

		/// <summary>
		/// Supports key values according to OData URL conventions
		/// </summary>
		/// <param name="indexableByKey">The value to set</param>
		/// <returns><see cref="IndexableByKeyConfiguration"/></returns>
		public IndexableByKeyConfiguration HasIndexableByKey(bool indexableByKey)
		{
			_indexableByKey = indexableByKey;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
