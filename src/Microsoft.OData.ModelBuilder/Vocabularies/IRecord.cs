// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

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
