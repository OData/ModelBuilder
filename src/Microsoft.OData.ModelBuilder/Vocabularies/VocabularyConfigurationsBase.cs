// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// Base for all vocabulary configuration classes
    /// </summary>
    public class VocabularyConfigurationsBase : IVocabularyTermConfiguration
    {
        /// <summary>
        /// Vocabulary builders to annotate this <see cref="VocabularyTermConfiguration"/>
        /// </summary> 
        public Dictionary<Type, VocabularyTermConfiguration> VocabularyTermConfigurations { get; } = new Dictionary<Type, VocabularyTermConfiguration>();
    }
}
