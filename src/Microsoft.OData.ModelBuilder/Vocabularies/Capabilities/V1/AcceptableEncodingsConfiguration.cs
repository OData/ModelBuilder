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
	/// List of acceptable compression methods for ($batch) requests, e.g. gzip
	/// </summary>
	public partial class AcceptableEncodingsConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<string> _acceptableEncodings = new HashSet<string>();

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.AcceptableEncodings";

		/// <summary>
		/// List of acceptable compression methods for ($batch) requests, e.g. gzip
		/// </summary>
		/// <param name="acceptableEncodings">The value(s) to set</param>
		/// <returns><see cref="AcceptableEncodingsConfiguration"/></returns>
		public AcceptableEncodingsConfiguration HasAcceptableEncodings(params string[] acceptableEncodings)
		{
			_acceptableEncodings.UnionWith(acceptableEncodings);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_acceptableEncodings.Any())
			{
				var collection = _acceptableEncodings.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("AcceptableEncodings", new EdmCollectionExpression(collection)));
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
