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
	public partial class CallbackSupportedConfiguration : VocabularyTermConfiguration
	{
		private readonly HashSet<CallbackProtocolConfiguration> _callbackProtocols = new HashSet<CallbackProtocolConfiguration>();

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.CallbackSupported";

		/// <summary>
		/// List of supported callback protocols, e.g. `http` or `wss`
		/// </summary>
		/// <param name="callbackProtocolsConfiguration">The configuration to set</param>
		/// <returns><see cref="CallbackSupportedConfiguration"/></returns>
		public CallbackSupportedConfiguration HasCallbackProtocols(Func<CallbackProtocolConfiguration, CallbackProtocolConfiguration> callbackProtocolsConfiguration)
		{
			var instance = new CallbackProtocolConfiguration();
			instance = callbackProtocolsConfiguration?.Invoke(instance);
			return HasCallbackProtocols(instance);
		}

		/// <summary>
		/// List of supported callback protocols, e.g. `http` or `wss`
		/// </summary>
		/// <param name="callbackProtocols">The value(s) to set</param>
		/// <returns><see cref="CallbackSupportedConfiguration"/></returns>
		public CallbackSupportedConfiguration HasCallbackProtocols(params CallbackProtocolConfiguration[] callbackProtocols)
		{
			_callbackProtocols.UnionWith(callbackProtocols);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_callbackProtocols.Any())
			{
				var collection = _callbackProtocols.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("CallbackProtocols", new EdmCollectionExpression(collection)));
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
