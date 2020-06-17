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
	/// A custom parameter is either a header or a query option
	/// </summary>
	public partial class CustomParameterConfiguration : IRecord
	{
		private string _name;
		private string _description;
		private string _documentationURL;
		private bool? _required;
		private readonly HashSet<PrimitiveExampleValueConfiguration> _exampleValues = new HashSet<PrimitiveExampleValueConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="CustomParameterConfiguration"/>
        /// </summary>
		public CustomParameterConfiguration()
		{
		}

		/// <summary>
		/// Name of the custom parameter
		/// </summary>
		/// <param name="name">The value to set</param>
		/// <returns><see cref="CustomParameter"/></returns>
		public CustomParameter HasName(string name)
		{
			_name = name;
			return this;
		}

		/// <summary>
		/// Description of the custom parameter
		/// </summary>
		/// <param name="description">The value to set</param>
		/// <returns><see cref="CustomParameter"/></returns>
		public CustomParameter HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// URL of related documentation
		/// </summary>
		/// <param name="documentationURL">The value to set</param>
		/// <returns><see cref="CustomParameter"/></returns>
		public CustomParameter HasDocumentationURL(string documentationURL)
		{
			_documentationURL = documentationURL;
			return this;
		}

		/// <summary>
		/// true: parameter is required, false or not specified: parameter is optional
		/// </summary>
		/// <param name="required">The value to set</param>
		/// <returns><see cref="CustomParameter"/></returns>
		public CustomParameter HasRequired(bool required)
		{
			_required = required;
			return this;
		}

		/// <summary>
		/// Example values for the custom parameter
		/// </summary>
		/// <param name="exampleValues">The value(s) to set</param>
		/// <returns><see cref="CustomParameter"/></returns>
		public CustomParameter AddExampleValues(params PrimitiveExampleValueConfiguration[] exampleValues)
		{
			foreach (var item in exampleValues)
			{
				_ = _exampleValues.Add(item);
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
