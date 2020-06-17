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
	/// Summary
/// 
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
		/// <returns><see cref="CallbackProtocol"/></returns>
		public CallbackProtocol HasId(string id)
		{
			_id = id;
			return this;
		}

		/// <summary>
		/// URL Template including parameters. Parameters are enclosed in curly braces {} as defined in RFC6570
		/// </summary>
		/// <param name="urlTemplate">The value to set</param>
		/// <returns><see cref="CallbackProtocol"/></returns>
		public CallbackProtocol HasUrlTemplate(string urlTemplate)
		{
			_urlTemplate = urlTemplate;
			return this;
		}

		/// <summary>
		/// Human readable description of the meaning of the URL Template parameters
		/// </summary>
		/// <param name="documentationUrl">The value to set</param>
		/// <returns><see cref="CallbackProtocol"/></returns>
		public CallbackProtocol HasDocumentationUrl(string documentationUrl)
		{
			_documentationUrl = documentationUrl;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			return null;
		}
	}
}
