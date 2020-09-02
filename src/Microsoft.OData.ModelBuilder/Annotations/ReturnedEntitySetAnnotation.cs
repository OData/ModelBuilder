// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// This annotation indicates the mapping from an <see cref="IEdmOperation"/> to a <see cref="String"/>.
    /// The <see cref="IEdmOperation"/> is a bound action/function and the <see cref="String"/> is the
    /// entity set name given by user to indicate the entity set returned from this action/function.
    /// </summary>
    public class ReturnedEntitySetAnnotation
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ReturnedEntitySetAnnotation"/> class.
        /// </summary>
        /// <param name="entitySetName">The return entity set or singleton name</param>
        public ReturnedEntitySetAnnotation(string entitySetName)
        {
            if (string.IsNullOrEmpty(entitySetName))
            {
                throw Error.ArgumentNullOrEmpty("entitySetName");
            }

            EntitySetName = entitySetName;
        }

        /// <summary>
        /// Gets the entity set name
        /// </summary>
        public string EntitySetName { get; }
    }
}
