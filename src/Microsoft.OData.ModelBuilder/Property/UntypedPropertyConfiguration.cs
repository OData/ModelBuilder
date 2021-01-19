// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Reflection;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Used to configure an untyped property of an entity type or complex type.
    /// This configuration functionality is exposed by the model builder Fluent API, see <see cref="ODataModelBuilder"/>.
    /// </summary>
    public class UntypedPropertyConfiguration : StructuralPropertyConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UntypedPropertyConfiguration"/> class.
        /// </summary>
        /// <param name="property">The property of the configuration.</param>
        /// <param name="declaringType">The declaring type of the property.</param>
        public UntypedPropertyConfiguration(PropertyInfo property, StructuralTypeConfiguration declaringType)
            : base(property, declaringType)
        {
            if (property == null)
            {
                throw Error.ArgumentNull(nameof(property));
            }

            if (property.PropertyType != typeof(object))
            {
                throw Error.Argument("property", SRResources.MustBeUntypedProperty, property.Name, property.DeclaringType.FullName);
            }
        }

        /// <summary>
        /// Gets or sets a value string representation of default value.
        /// </summary>
        public string DefaultValueString { get; set; }

        /// <summary>
        /// Gets the type of this property.
        /// </summary>
        public override PropertyKind Kind => PropertyKind.Untyped;

        /// <summary>
        /// Gets the backing CLR type of this property type.
        /// </summary>
        public override Type RelatedClrType => PropertyInfo.PropertyType;

        /// <summary>
        /// Configures the property to be nullable.
        /// </summary>
        /// <returns>Returns itself so that multiple calls can be chained.</returns>
        public UntypedPropertyConfiguration IsNullable()
        {
            NullableProperty = true;
            return this;
        }

        /// <summary>
        /// Configures the property to be required.
        /// </summary>
        /// <returns>Returns itself so that multiple calls can be chained.</returns>
        public UntypedPropertyConfiguration IsRequired()
        {
            NullableProperty = false;
            return this;
        }
    }
}
