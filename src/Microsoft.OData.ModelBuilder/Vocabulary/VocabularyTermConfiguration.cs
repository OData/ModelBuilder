using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Base vocabulary configuration.
    /// </summary>
    public abstract partial class VocabularyTermConfiguration : IRecord
    {
        private readonly string _termName;

        /// <summary>
        /// Creates a new instance of <see cref="VocabularyTermConfiguration"/>
        /// </summary>
        /// <param name="termName">The name of the <see cref="IEdmTerm"/> being built.</param>
        public VocabularyTermConfiguration(string termName) => _termName = termName;

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

            var term = model.FindTerm(_termName);
            if (term == null)
            {
                return;
            }

            var annotation = new EdmVocabularyAnnotation(target, term, expression);
            model.SetVocabularyAnnotation(annotation);
        }
    }
}
