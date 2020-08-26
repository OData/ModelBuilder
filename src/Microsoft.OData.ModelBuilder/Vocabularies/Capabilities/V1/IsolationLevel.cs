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
	/// Org.OData.Capabilities.V1.IsolationLevel
	/// </summary>
	[Flags]
	public enum IsolationLevel
	{
        /// <summary>
		/// All data returned for a request, including multiple requests within a batch or results retrieved across multiple pages, will be consistent as of a single point in time
        /// </summary>
		Snapshot,
	}
}
