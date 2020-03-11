// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// Represents an <see cref="IEdmTerm"/> that can be built using <see cref="ODataModelBuilder"/>.
    /// </summary>
    public class TermConfiguration
    {
        private string _namespace;
        private string _name;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        public TermConfiguration(ODataModelBuilder builder, string name, IEdmTypeConfiguration type)
        {
            Namespace = builder?.Namespace;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// 
        /// </summary>
        public IEdmTypeConfiguration Type { get; }

        /// <summary>
        /// Gets or sets a value that is <c>true</c> if the type's name or namespace was set by the user; <c>false</c> if it was inferred through conventions.
        /// </summary>
        /// <remarks>The default value is <c>false</c>.</remarks>
        public bool AddedExplicitly { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool IsCollection => Type.Kind == EdmTypeKind.Collection;

        /// <summary>
        /// The <see cref="ODataModelBuilder"/>.
        /// </summary>
        public virtual ODataModelBuilder ModelBuilder { get; private set; }

        /// <summary>
        /// Gets or sets the namespace of this EDM type.
        /// </summary>
        [SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "<Pending>")]
        public virtual string Namespace
        {
            get
            {
                return _namespace;
            }
            set
            {
                if (value == null)
                {
                    throw Error.PropertyNull();
                }

                _namespace = value;
                AddedExplicitly = true;
            }
        }

        /// <summary>
        /// Gets or sets the name of this EDM type.
        /// </summary>
        public virtual string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null)
                {
                    throw Error.PropertyNull();
                }

                _name = value;
                AddedExplicitly = true;
            }
        }
    }
}
