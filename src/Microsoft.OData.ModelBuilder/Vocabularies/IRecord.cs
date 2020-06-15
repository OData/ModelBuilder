using Microsoft.OData.Edm.Vocabularies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// Interface for clr types that can be converted into <see cref="EdmRecordExpression" />
    /// </summary>
    public interface IRecord
    {
        /// <summary>
        /// Convert a clr type to an <see cref="EdmRecordExpression" />
        /// </summary>
        /// <returns><see cref="EdmRecordExpression" /></returns>
        EdmRecordExpression ToEdmRecordExpression();
    }
}
