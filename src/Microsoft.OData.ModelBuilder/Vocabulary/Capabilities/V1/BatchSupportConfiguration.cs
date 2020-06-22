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
	/// Batch Support for the service
	/// </summary>
	public partial class BatchSupportConfiguration : VocabularyTermConfiguration
	{
		private bool? _supported;
		private bool? _continueOnErrorSupported;
		private bool? _referencesInRequestBodiesSupported;
		private bool? _referencesAcrossChangeSetsSupported;
		private bool? _etagReferencesSupported;
		private bool? _requestDependencyConditionsSupported;
		private readonly HashSet<string> _supportedFormats = new HashSet<string>();

        /// <summary>
        /// Creates a new instance of <see cref="BatchSupportConfiguration"/>
        /// </summary>
		public BatchSupportConfiguration()
			: base("Org.OData.Capabilities.V1.BatchSupport")
		{
		}

		/// <summary>
		/// Service supports requests to $batch
		/// </summary>
		/// <param name="supported">The value to set</param>
		/// <returns><see cref="BatchSupportConfiguration"/></returns>
		public BatchSupportConfiguration IsSupported(bool supported)
		{
			_supported = supported;
			return this;
		}

		/// <summary>
		/// Service supports the continue on error preference
		/// </summary>
		/// <param name="continueOnErrorSupported">The value to set</param>
		/// <returns><see cref="BatchSupportConfiguration"/></returns>
		public BatchSupportConfiguration IsContinueOnErrorSupported(bool continueOnErrorSupported)
		{
			_continueOnErrorSupported = continueOnErrorSupported;
			return this;
		}

		/// <summary>
		/// Service supports Content-ID referencing in request bodies
		/// </summary>
		/// <param name="referencesInRequestBodiesSupported">The value to set</param>
		/// <returns><see cref="BatchSupportConfiguration"/></returns>
		public BatchSupportConfiguration IsReferencesInRequestBodiesSupported(bool referencesInRequestBodiesSupported)
		{
			_referencesInRequestBodiesSupported = referencesInRequestBodiesSupported;
			return this;
		}

		/// <summary>
		/// Service supports Content-ID referencing across change sets
		/// </summary>
		/// <param name="referencesAcrossChangeSetsSupported">The value to set</param>
		/// <returns><see cref="BatchSupportConfiguration"/></returns>
		public BatchSupportConfiguration IsReferencesAcrossChangeSetsSupported(bool referencesAcrossChangeSetsSupported)
		{
			_referencesAcrossChangeSetsSupported = referencesAcrossChangeSetsSupported;
			return this;
		}

		/// <summary>
		/// Service supports referencing Etags from previous requests
		/// </summary>
		/// <param name="etagReferencesSupported">The value to set</param>
		/// <returns><see cref="BatchSupportConfiguration"/></returns>
		public BatchSupportConfiguration IsEtagReferencesSupported(bool etagReferencesSupported)
		{
			_etagReferencesSupported = etagReferencesSupported;
			return this;
		}

		/// <summary>
		/// Service supports the `if` member in JSON batch requests
		/// </summary>
		/// <param name="requestDependencyConditionsSupported">The value to set</param>
		/// <returns><see cref="BatchSupportConfiguration"/></returns>
		public BatchSupportConfiguration IsRequestDependencyConditionsSupported(bool requestDependencyConditionsSupported)
		{
			_requestDependencyConditionsSupported = requestDependencyConditionsSupported;
			return this;
		}

		/// <summary>
		/// Media types of supported formats for $batch
		/// </summary>
		/// <param name="supportedFormats">The value(s) to set</param>
		/// <returns><see cref="BatchSupportConfiguration"/></returns>
		public BatchSupportConfiguration AddSupportedFormats(params string[] supportedFormats)
		{
			_supportedFormats.UnionWith(supportedFormats);
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_supported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("Supported", new EdmBooleanConstant(_supported.Value)));
			}

			if (_continueOnErrorSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("ContinueOnErrorSupported", new EdmBooleanConstant(_continueOnErrorSupported.Value)));
			}

			if (_referencesInRequestBodiesSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("ReferencesInRequestBodiesSupported", new EdmBooleanConstant(_referencesInRequestBodiesSupported.Value)));
			}

			if (_referencesAcrossChangeSetsSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("ReferencesAcrossChangeSetsSupported", new EdmBooleanConstant(_referencesAcrossChangeSetsSupported.Value)));
			}

			if (_etagReferencesSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("EtagReferencesSupported", new EdmBooleanConstant(_etagReferencesSupported.Value)));
			}

			if (_requestDependencyConditionsSupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("RequestDependencyConditionsSupported", new EdmBooleanConstant(_requestDependencyConditionsSupported.Value)));
			}

			if (_supportedFormats.Any())
			{
				var collection = _supportedFormats.Select(item => item.ToEdmExpression()).Where(item => item != null);
				if (collection.Any())
				{
					properties.Add(new EdmPropertyConstructor("SupportedFormats", new EdmCollectionExpression(collection)));
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
