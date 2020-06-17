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
	/// Supports callbacks for the specified protocols
	/// </summary>
	public partial class CallbackSupportedConfiguration : VocabularyConfiguration
	{
		private readonly HashSet<CallbackProtocolConfiguration> _callbackProtocols = new HashSet<CallbackProtocolConfiguration>();

        /// <summary>
        /// Creates a new instance of <see cref="CallbackSupportedConfiguration"/>
        /// </summary>
		public CallbackSupportedConfiguration()
			: base("Org.OData.Capabilities.V1.CallbackSupported")
		{
		}

		/// <summary>
		/// List of supported callback protocols, e.g. `http` or `wss`
		/// </summary>
		/// <param name="callbackProtocols">The value(s) to set</param>
		/// <returns><see cref="CallbackSupportedConfiguration"/></returns>
		public CallbackSupportedConfiguration AddCallbackProtocols(params CallbackProtocolConfiguration[] callbackProtocols)
		{
			foreach (var item in callbackProtocols)
			{
				_ = _callbackProtocols.Add(item);
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
