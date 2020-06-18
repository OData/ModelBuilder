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
	/// The type of a custom parameter is always a string. Restrictions on the parameter values can be expressed by annotating the record expression describing the parameter with terms from the Validation vocabulary, e.g. Validation.Pattern or Validation.AllowedValues.
	/// </summary>
	public partial class CustomParameterConfiguration : IRecord
	{
		private string _name;
		private string _description;
		private string _documentationURL;
		private bool? _required;
		private readonly HashSet<Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration> _exampleValues = new HashSet<Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration>();

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
		/// <returns><see cref="CustomParameterConfiguration"/></returns>
		public CustomParameterConfiguration HasName(string name)
		{
			_name = name;
			return this;
		}

		/// <summary>
		/// Description of the custom parameter
		/// </summary>
		/// <param name="description">The value to set</param>
		/// <returns><see cref="CustomParameterConfiguration"/></returns>
		public CustomParameterConfiguration HasDescription(string description)
		{
			_description = description;
			return this;
		}

		/// <summary>
		/// URL of related documentation
		/// </summary>
		/// <param name="documentationURL">The value to set</param>
		/// <returns><see cref="CustomParameterConfiguration"/></returns>
		public CustomParameterConfiguration HasDocumentationURL(string documentationURL)
		{
			_documentationURL = documentationURL;
			return this;
		}

		/// <summary>
		/// true: parameter is required, false or not specified: parameter is optional
		/// </summary>
		/// <param name="required">The value to set</param>
		/// <returns><see cref="CustomParameterConfiguration"/></returns>
		public CustomParameterConfiguration IsRequired(bool required)
		{
			_required = required;
			return this;
		}

		/// <summary>
		/// Example values for the custom parameter
		/// </summary>
		/// <param name="exampleValues">The value(s) to set</param>
		/// <returns><see cref="CustomParameterConfiguration"/></returns>
		public CustomParameterConfiguration AddExampleValues(params Microsoft.OData.ModelBuilder.Core.V1.PrimitiveExampleValueConfiguration[] exampleValues)
		{
			foreach (var item in exampleValues)
			{
				_ = _exampleValues.Add(item);
			}

			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (!string.IsNullOrEmpty(_name))
			{
				properties.Add(new EdmPropertyConstructor("Name", new EdmStringConstant(_name)));
			}

			if (!string.IsNullOrEmpty(_description))
			{
				properties.Add(new EdmPropertyConstructor("Description", new EdmStringConstant(_description)));
			}

			if (!string.IsNullOrEmpty(_documentationURL))
			{
				properties.Add(new EdmPropertyConstructor("DocumentationURL", new EdmStringConstant(_documentationURL)));
			}

			if (_required.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Required", new EdmBooleanConstant(_required.Value)));
			}

			if (_exampleValues.Any())
			{
				var collection = _exampleValues.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("ExampleValues", new EdmCollectionExpression(collection)));
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
