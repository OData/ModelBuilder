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
    /// Terms annotated with this term can only be applied to elements that have a type that is identical to or derived from the given type name
    /// </summary>
    public partial class RequiresTypeConfiguration : VocabularyTermConfiguration
    {
        private readonly Dictionary<string, object> _dynamicProperties = new Dictionary<string, object>();
        private string _requiresType;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.RequiresType";

        /// <summary>
        /// Dynamic properties.
        /// </summary>
        /// <param name="name">The name to set</param>
        /// <param name="value">The value to set</param>
        /// <returns><see cref="RequiresTypeConfiguration"/></returns>
        public RequiresTypeConfiguration HasDynamicProperty(string name, object value)
        {
            _dynamicProperties[name] = value;
            return this;
        }

        /// <summary>
        /// Terms annotated with this term can only be applied to elements that have a type that is identical to or derived from the given type name
        /// </summary>
        /// <param name="requiresType">The value to set</param>
        /// <returns><see cref="RequiresTypeConfiguration"/></returns>
        public RequiresTypeConfiguration HasRequiresType(string requiresType)
        {
            _requiresType = requiresType;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            var properties = new List<IEdmPropertyConstructor>();

            if (!string.IsNullOrEmpty(_requiresType))
            {
                properties.Add(new EdmPropertyConstructor("RequiresType", new EdmStringConstant(_requiresType)));
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
