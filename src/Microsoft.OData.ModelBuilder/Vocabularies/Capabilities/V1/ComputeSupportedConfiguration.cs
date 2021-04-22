// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.
// <auto-generated />

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Capabilities.V1
{
    /// <summary>
    /// Supports $compute
    /// </summary>
    public partial class ComputeSupportedConfiguration : VocabularyTermConfiguration
    {
        private readonly Dictionary<string, object> _dynamicProperties = new Dictionary<string, object>();
        private bool? _computeSupported;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Capabilities.V1.ComputeSupported";

        /// <summary>
        /// Dynamic properties.
        /// </summary>
        /// <param name="name">The name to set</param>
        /// <param name="value">The value to set</param>
        /// <returns><see cref="ComputeSupportedConfiguration"/></returns>
        public ComputeSupportedConfiguration HasDynamicProperty(string name, object value)
        {
            _dynamicProperties[name] = value;
            return this;
        }

        /// <summary>
        /// Supports $compute
        /// </summary>
        /// <param name="computeSupported">The value to set</param>
        /// <returns><see cref="ComputeSupportedConfiguration"/></returns>
        public ComputeSupportedConfiguration IsComputeSupported(bool computeSupported)
        {
            _computeSupported = computeSupported;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            var properties = new List<IEdmPropertyConstructor>();

            if (_computeSupported.HasValue)
            {
                properties.Add(new EdmPropertyConstructor("ComputeSupported", new EdmBooleanConstant(_computeSupported.Value)));
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
