// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Microsoft.OData.ModelBuilder.Conventions.Attributes
{
    /// <summary>
    /// Configures properties that have the NullableAttribute.
    /// </summary>
    /// <remarks>This MUST come after RequiredAttribute</remarks>
    internal class NullableAttributeEdmPropertyConvention : AttributeEdmPropertyConvention<PropertyConfiguration>
    {
        //
        // For the interpretation of nullability metadata, see
        // https://github.com/dotnet/roslyn/blob/master/docs/features/nullable-metadata.md
        //

        private const string NullableAttributeFullName = "System.Runtime.CompilerServices.NullableAttribute";

        internal static readonly Func<Attribute, bool> NullableAttributeFilter = attribute => attribute.GetType().FullName == NullableAttributeFullName;

        public NullableAttributeEdmPropertyConvention()
            : base(NullableAttributeFilter, allowMultiple: false)
        {
        }

        /// <summary>
        /// Configures property's NonNullablity.
        /// </summary>
        /// <param name="edmProperty">The key property.</param>
        /// <param name="structuralTypeConfiguration">The edm type being configured.</param>
        /// <param name="attribute">The <see cref="Attribute"/> found on the property.</param>
        /// <param name="model">The ODataConventionModelBuilder used to build the model.</param>
        public override void Apply(PropertyConfiguration edmProperty,
            StructuralTypeConfiguration structuralTypeConfiguration,
            Attribute attribute,
            ODataConventionModelBuilder model)
        {
            Contract.Assert(edmProperty != null);

            //
            // Check if already NonNullable
            //
            if (edmProperty.NonNullable())
            {
                return;
            }

            var nullableFlagsFieldInfo = attribute.GetType().GetField("NullableFlags");
            if (nullableFlagsFieldInfo?.GetValue(attribute) is byte[] flags)
            {
                //
                // flags:
                // 0 oblivious
                // 1 not annotated
                // 2 annotated
                //
                if (flags.FirstOrDefault() == 1 && !edmProperty.ReturnMaybeNull())
                {
                    edmProperty.SetNonNullable();
                }
            }
        }
    }
}
