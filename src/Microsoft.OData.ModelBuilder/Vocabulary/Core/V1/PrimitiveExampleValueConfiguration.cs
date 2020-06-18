// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Core.V1
{
	/// <summary>
	/// Org.OData.Core.V1.PrimitiveExampleValue
	/// </summary>
	public partial class PrimitiveExampleValueConfiguration : IRecord
	{
		private string _description;
		private object _value;

        /// <summary>
        /// Creates a new instance of <see cref="PrimitiveExampleValueConfiguration"/>
        /// </summary>
		public PrimitiveExampleValueConfiguration()
		{
		}

		/// <summary>
		/// Description of the example value
		/// </summary>
		/// <param name="description">The value to set</param>
		/// <returns><see cref="PrimitiveExampleValueConfiguration"/></returns>
		public PrimitiveExampleValueConfiguration HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// Example value for the custom parameter
		/// </summary>
		/// <param name="value">The value to set</param>
		/// <returns><see cref="PrimitiveExampleValueConfiguration"/></returns>
		public PrimitiveExampleValueConfiguration HasValue(object value)
		{
			_value = value;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (!string.IsNullOrEmpty(_description))
			{
				properties.Add(new EdmPropertyConstructor("Description", new EdmStringConstant(_description)));
			}

			if (_value != null)
			{
				// properties.Add(new EdmPropertyConstructor("Value", new EdmPrimitiveConstant(_value.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
