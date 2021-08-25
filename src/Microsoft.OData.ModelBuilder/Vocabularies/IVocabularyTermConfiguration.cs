// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// interface for all vocabulary configuration classes
    /// </summary>
    public interface IVocabularyTermConfiguration
    {
        /// <summary>
        /// Vocabulary builders to annotate this <see cref="VocabularyTermConfiguration"/>
        /// </summary> 
        Dictionary<Type, VocabularyTermConfiguration> VocabularyTermConfigurations { get; }
    }
}
