// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.
// <auto-generated />

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Core.V1
{
    /// <summary>
    /// A value for this property is generated on both insert and update
    /// </summary>
    public partial class ComputedConfiguration : VocabularyTermConfiguration
    {
        private readonly Dictionary<string, object> _dynamicProperties = new Dictionary<string, object>();
        private bool? _computed;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.Computed";

        /// <summary>
        /// Dynamic properties.
        /// </summary>
        /// <param name="name">The name to set</param>
        /// <param name="value">The value to set</param>
        /// <returns><see cref="ComputedConfiguration"/></returns>
        public ComputedConfiguration HasDynamicProperty(string name, object value)
        {
            _dynamicProperties[name] = value;
            return this;
        }

        /// <summary>
        /// A value for this property is generated on both insert and update
        /// </summary>
        /// <param name="computed">The value to set</param>
        /// <returns><see cref="ComputedConfiguration"/></returns>
        public ComputedConfiguration IsComputed(bool computed)
        {
            _computed = computed;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            var properties = new List<IEdmPropertyConstructor>();

            if (_computed.HasValue)
            {
                properties.Add(new EdmPropertyConstructor("Computed", new EdmBooleanConstant(_computed.Value)));
            }

            properties.AddRange(_dynamicProperties.ToEdmProperties());

            if (!properties.Any())
            {
                return null;
            }

            return new EdmRecordExpression(properties);
        }
    }
}