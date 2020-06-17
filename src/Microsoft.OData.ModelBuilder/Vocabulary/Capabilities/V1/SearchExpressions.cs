// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Capabilities.V1
{
	/// <summary>
	/// Summary
/// 
	/// </summary>
	public enum SearchExpressions
	{

        /// <summary>
		/// Single search term
        /// </summary>
		none,

        /// <summary>
		/// Multiple search terms separated by `AND`
        /// </summary>
		AND,

        /// <summary>
		/// Multiple search terms separated by `OR`
        /// </summary>
		OR,

        /// <summary>
		/// Search terms preceded by `NOT`
        /// </summary>
		NOT,

        /// <summary>
		/// Search phrases enclosed in double quotes
        /// </summary>
		phrase,

        /// <summary>
		/// Precedence grouping of search expressions with parentheses
        /// </summary>
		group,
	}
}
