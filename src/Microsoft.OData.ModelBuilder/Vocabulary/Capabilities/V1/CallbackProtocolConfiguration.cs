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
	/// Org.OData.Capabilities.V1.CallbackProtocol
	/// </summary>
	public partial class CallbackProtocolConfiguration : IRecord
	{
		private string _id;
		private string _urlTemplate;
		private string _documentationUrl;

        /// <summary>
        /// Creates a new instance of <see cref="CallbackProtocolConfiguration"/>
        /// </summary>
		public CallbackProtocolConfiguration()
		{
		}

		/// <summary>
		/// Protocol Identifier
		/// </summary>
		/// <param name="id">The value to set</param>
		/// <returns><see cref="CallbackProtocolConfiguration"/></returns>
		public CallbackProtocolConfiguration HasId(string id)
		{
			_id = id;
			return this;
		}

		/// <summary>
		/// URL Template including parameters. Parameters are enclosed in curly braces {} as defined in RFC6570
		/// </summary>
		/// <param name="urlTemplate">The value to set</param>
		/// <returns><see cref="CallbackProtocolConfiguration"/></returns>
		public CallbackProtocolConfiguration HasUrlTemplate(string urlTemplate)
		{
			_urlTemplate = urlTemplate;
			return this;
		}

		/// <summary>
		/// Human readable description of the meaning of the URL Template parameters
		/// </summary>
		/// <param name="documentationUrl">The value to set</param>
		/// <returns><see cref="CallbackProtocolConfiguration"/></returns>
		public CallbackProtocolConfiguration HasDocumentationUrl(string documentationUrl)
		{
			_documentationUrl = documentationUrl;
			return this;
		}

		/// <inheritdoc/>
		public IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (string.IsNullOrEmpty(_id))
			{
				properties.Add(new EdmPropertyConstructor("Id", new EdmStringConstant(_id)));
			}

			if (string.IsNullOrEmpty(_urlTemplate))
			{
				properties.Add(new EdmPropertyConstructor("UrlTemplate", new EdmStringConstant(_urlTemplate)));
			}

			if (string.IsNullOrEmpty(_documentationUrl))
			{
				properties.Add(new EdmPropertyConstructor("DocumentationUrl", new EdmStringConstant(_documentationUrl)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
