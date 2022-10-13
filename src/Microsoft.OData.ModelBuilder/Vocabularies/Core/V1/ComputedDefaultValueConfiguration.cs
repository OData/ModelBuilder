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
    /// A value for this property can be provided by the client on insert and update. If no value is provided on insert, a non-static default value is generated
    /// </summary>
    public partial class ComputedDefaultValueConfiguration : VocabularyTermConfiguration
    {
        private bool? _computedDefaultValue;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.ComputedDefaultValue";

        /// <summary>
        /// A value for this property can be provided by the client on insert and update. If no value is provided on insert, a non-static default value is generated
        /// </summary>
        /// <param name="computedDefaultValue">The value to set</param>
        /// <returns><see cref="ComputedDefaultValueConfiguration"/></returns>
        public ComputedDefaultValueConfiguration IsComputedDefaultValue(bool computedDefaultValue)
        {
            _computedDefaultValue = computedDefaultValue;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            return new EdmBooleanConstant(_computedDefaultValue ?? true);
        }
    }
}
