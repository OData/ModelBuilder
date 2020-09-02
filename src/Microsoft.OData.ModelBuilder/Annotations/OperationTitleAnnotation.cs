// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Represents a annotation for the Operation title.
    /// </summary>
    public class OperationTitleAnnotation
    {
        /// <summary>
        /// Initializes a new instance of <see cref="OperationTitleAnnotation"/> class.
        /// </summary>
        /// <param name="title">The operation title.</param>
        public OperationTitleAnnotation(string title)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
        }

        /// <summary>
        /// Gets the operation title.
        /// </summary>
        public string Title { get; }
    }
}
