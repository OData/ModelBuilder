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
    /// A symbolic name for a model element
    /// </summary>
    public partial class SymbolicNameConfiguration : VocabularyTermConfiguration
    {
        private string _symbolicName;

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.SymbolicName";

        /// <summary>
        /// A symbolic name for a model element
        /// </summary>
        /// <param name="symbolicName">The value to set</param>
        /// <returns><see cref="SymbolicNameConfiguration"/></returns>
        public SymbolicNameConfiguration HasSymbolicName(string symbolicName)
        {
            _symbolicName = symbolicName;
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            return new EdmStringConstant(_symbolicName);
        }
    }
}