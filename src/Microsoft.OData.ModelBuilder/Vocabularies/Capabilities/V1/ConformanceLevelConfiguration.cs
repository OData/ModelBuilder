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
	/// The conformance level achieved by this service
	/// </summary>
	public partial class ConformanceLevelConfiguration : VocabularyTermConfiguration
	{
		private ConformanceLevelType? _conformanceLevel;

        /// <inheritdoc/>
		public override string TermName => "Org.OData.Capabilities.V1.ConformanceLevel";

		/// <summary>
		/// The conformance level achieved by this service
		/// </summary>
		/// <param name="conformanceLevel">The value to set</param>
		/// <returns><see cref="ConformanceLevelConfiguration"/></returns>
		public ConformanceLevelConfiguration HasConformanceLevel(ConformanceLevelType conformanceLevel)
		{
			_conformanceLevel = conformanceLevel;
			return this;
		}

		/// <inheritdoc/>
		public override IEdmExpression ToEdmExpression()
		{
			var properties = new List<IEdmPropertyConstructor>();

			if (_conformanceLevel.HasValue)
			{
				var enumType = new EdmEnumType("Org.OData.Capabilities.V1", "ConformanceLevelType", false);
                var enumMember = new EdmEnumMember(enumType, _conformanceLevel.ToString(), new EdmEnumMemberValue((long)_conformanceLevel.Value));
				properties.Add(new EdmPropertyConstructor("ConformanceLevel", new EdmEnumMemberExpression(enumMember)));
			}

			if (!properties.Any())
			{
				return null;
			}

			return new EdmRecordExpression(properties);
		}
	}
}
