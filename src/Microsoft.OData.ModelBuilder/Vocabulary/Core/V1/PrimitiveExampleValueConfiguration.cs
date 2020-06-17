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
	/// Summary
/// 
	/// </summary>
	public partial class PrimitiveExampleValueConfiguration : IRecord
	{
		private object _value;

        /// <summary>
        /// Creates a new instance of <see cref="PrimitiveExampleValueConfiguration"/>
        /// </summary>
		public PrimitiveExampleValueConfiguration()
		{
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
			return null;
		}
	}
}
