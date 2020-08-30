// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Base vocabulary configuration.
    /// </summary>
    public abstract partial class VocabularyTermConfiguration : IRecord
    {
        /// <summary>
        /// The name of the <see cref="IEdmTerm"/> to build.
        /// </summary>
        public abstract string TermName { get; }

        /// <inheritdoc/>
        public abstract IEdmExpression ToEdmExpression();

        /// <summary>
        /// Sets the vocabulary annotation on the model's target.
        /// </summary>
        /// <param name="model">The <see cref="IEdmModel"/> having reference vocabulary models.</param>
        /// <param name="target">The <see cref="IEdmVocabularyAnnotatable"/> to set annotations on.</param>
        public virtual void SetVocabularyAnnotations(EdmModel model, IEdmVocabularyAnnotatable target)
        {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            _ = target ?? throw new ArgumentNullException(nameof(target));

            var expression = ToEdmExpression();
            if (expression == null)
            {
                return;
            }

            var term = model.FindTerm(TermName);
            if (term == null)
            {
                return;
            }

            var annotation = new EdmVocabularyAnnotation(target, term, expression);
            model.SetVocabularyAnnotation(annotation);
        }
    }
}
