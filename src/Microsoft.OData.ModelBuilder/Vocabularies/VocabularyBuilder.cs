using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// Base vocabulary builder.
    /// </summary>
    /// <typeparam name="T">The <see cref="IRecord"/> to be built.</typeparam>
    public abstract class VocabularyBuilder<T> where T : IRecord
    {
        /// <summary>
        /// Creates a new instance of <see cref="VocabularyBuilder{T}"/>
        /// </summary>
        /// <param name="termName">The name of the <see cref="IEdmTerm"/> being built.</param>
        /// <param name="data">The <see cref="IRecord"/> holding the data being built.</param>
        public VocabularyBuilder(string termName, T data) => (TermName, Data) = (termName, data);

        /// <summary>
        /// The name of the vocabulary term.
        /// </summary>
        protected string TermName { get; }

        /// <summary>
        /// The builder data.
        /// </summary>
        protected T Data { get; }

        /// <summary>
        /// Sets the vocabulary annotation on the model's target.
        /// </summary>
        /// <param name="model">The <see cref="IEdmModel"/> having reference vocabulary models.</param>
        /// <param name="target">The <see cref="IEdmVocabularyAnnotatable"/> to set annotations on.</param>
        public virtual void SetVocabularyAnnotations(EdmModel model, IEdmVocabularyAnnotatable target)
        {
            _ = model ?? throw new ArgumentNullException(nameof(model));
            _ = target ?? throw new ArgumentNullException(nameof(target));

            var record = Data.ToEdmRecordExpression();
            if (record == null)
            {
                return;
            }

            var term = model.FindTerm(TermName);
            if (term == null)
            {
                return;
            }

            var annotation = new EdmVocabularyAnnotation(target, term, record);
            model.SetVocabularyAnnotation(annotation);
        }
    }
}
