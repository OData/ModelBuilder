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
	/// Org.OData.Capabilities.V1.NavigationType
	/// </summary>
	public enum NavigationType
	{
        /// <summary>
		/// Navigation properties can be recursively navigated
        /// </summary>
		Recursive,

        /// <summary>
		/// Navigation properties can be navigated to a single level
        /// </summary>
		Single,

        /// <summary>
		/// Navigation properties are not navigable
        /// </summary>
		None,
	}
}
