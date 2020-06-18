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
	/// Supports annotation values within system query options
	/// </summary>
	public partial class AnnotationValuesInQuerySupportedConfiguration : VocabularyTermConfiguration
	{
		private bool? _annotationValuesInQuerySupported;

        /// <summary>
        /// Creates a new instance of <see cref="AnnotationValuesInQuerySupportedConfiguration"/>
        /// </summary>
		public AnnotationValuesInQuerySupportedConfiguration()
			: base("Org.OData.Capabilities.V1.AnnotationValuesInQuerySupported")
		{
		}

		/// <summary>
		/// Supports annotation values within system query options
		/// </summary>
		/// <param name="annotationValuesInQuerySupported">The value to set</param>
		/// <returns><see cref="AnnotationValuesInQuerySupportedConfiguration"/></returns>
		public AnnotationValuesInQuerySupportedConfiguration HasAnnotationValuesInQuerySupported(bool annotationValuesInQuerySupported)
		{
			_annotationValuesInQuerySupported = annotationValuesInQuerySupported;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_annotationValuesInQuerySupported.HasValue)
			{
				properties.Add(new EdmPropertyConstructor("AnnotationValuesInQuerySupported", new EdmBooleanConstant(_annotationValuesInQuerySupported.Value)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
