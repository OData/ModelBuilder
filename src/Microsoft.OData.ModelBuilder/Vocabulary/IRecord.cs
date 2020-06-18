using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.OData.ModelBuilder
{
	/// <summary>
	/// Interface for clr types that can be converted into <see cref="EdmRecordExpression" />
	/// </summary>
	public interface IRecord
	{
		/// <summary>
		/// Convert a clr type to an <see cref="IEdmExpression" />
		/// </summary>
		/// <returns><see cref="IEdmExpression" /></returns>
		IEdmExpression ToEdmExpression();
	}
}
