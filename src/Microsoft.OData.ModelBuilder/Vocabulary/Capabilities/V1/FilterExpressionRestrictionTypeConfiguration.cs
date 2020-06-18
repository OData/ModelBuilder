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
	/// Org.OData.Capabilities.V1.FilterExpressionRestrictionType
	/// </summary>
	public partial class FilterExpressionRestrictionTypeConfiguration : IRecord
	{
		private EdmPropertyPathExpression _property;
		private string _allowedExpressions;

        /// <summary>
        /// Creates a new instance of <see cref="FilterExpressionRestrictionTypeConfiguration"/>
        /// </summary>
		public FilterExpressionRestrictionTypeConfiguration()
		{
		}

		/// <summary>
		/// Path to the restricted property
		/// </summary>
		/// <param name="property">The value to set</param>
		/// <returns><see cref="FilterExpressionRestrictionTypeConfiguration"/></returns>
		public FilterExpressionRestrictionTypeConfiguration HasProperty(EdmPropertyPathExpression property)
		{
			_property = property;
			return this;
		}

		/// <summary>
		/// Allowed subset of expressions
		/// </summary>
		/// <param name="allowedExpressions">The value to set</param>
		/// <returns><see cref="FilterExpressionRestrictionTypeConfiguration"/></returns>
		public FilterExpressionRestrictionTypeConfiguration HasAllowedExpressions(string allowedExpressions)
		{
			_allowedExpressions = allowedExpressions;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_property != null)
			{
				properties.Add(new EdmPropertyConstructor("Property", _property));
			}

			if (!string.IsNullOrEmpty(_allowedExpressions))
			{
				properties.Add(new EdmPropertyConstructor("AllowedExpressions", new EdmStringConstant(_allowedExpressions)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
