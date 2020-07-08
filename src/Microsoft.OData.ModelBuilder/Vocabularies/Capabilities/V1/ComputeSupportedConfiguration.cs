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
	/// Supports $compute
	/// </summary>
	public partial class ComputeSupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _computeSupported;

        /// <summary>
        /// Creates a new instance of <see cref="ComputeSupportedConfiguration"/>
        /// </summary>
		public ComputeSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.ComputeSupported")
		{
		}

		/// <summary>
		/// Supports $compute
		/// </summary>
		/// <param name="computeSupported">The value to set</param>
		/// <returns><see cref="ComputeSupportedConfiguration"/></returns>
		public ComputeSupportedConfiguration IsComputeSupported(bool computeSupported)
		{
			_computeSupported = computeSupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_computeSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("ComputeSupported", new EdmBooleanConstant(_computeSupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
