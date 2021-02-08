// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;

namespace Microsoft.OData.ModelBuilder.Conventions.Attributes
{
    /// <summary>
    /// Configures properties of a Type that has the NullableContextAttribute.
    /// </summary>
    /// <remarks>This MUST come after NullableAttribute</remarks>
    internal class NullableContextAttributeEdmTypeConvention : AttributeEdmTypeConvention<StructuralTypeConfiguration>
    {
        //
        // For the interpretation of nullability metadata, see
        // https://github.com/dotnet/roslyn/blob/master/docs/features/nullable-metadata.md
        //

        private const string NullableContextAttributeFullName = "System.Runtime.CompilerServices.NullableContextAttribute";

        public NullableContextAttributeEdmTypeConvention()
            : base(attribute => attribute.GetType().FullName == NullableContextAttributeFullName, allowMultiple: false)
        {
        }

        /// <summary>
        /// Configures the NonNullablity of a type's properties based on the NullableContext.
        /// </summary>
        /// <param name="edmTypeConfiguration">The edm type being configured.</param>
        /// <param name="attribute">The <see cref="Attribute"/> found on the property.</param>
        /// <param name="model">The ODataConventionModelBuilder used to build the model.</param>
        public override void Apply(StructuralTypeConfiguration edmTypeConfiguration,
                                   ODataConventionModelBuilder model,
                                   Attribute attribute)
        {
            Contract.Assert(edmTypeConfiguration != null);

            //
            // Only propagate Nullability if flag == 1 (not annotated)
            //
            if (attribute.GetType().GetField("Flag")?.GetValue(attribute) is byte flag && flag != 1)
            {
                return;
            }

            var declaredOnlyProperties = edmTypeConfiguration.ClrType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public);
            var declaredOnlyPropertyNames = new HashSet<string>(declaredOnlyProperties.Select(p => p.Name));

            foreach (var edmProperty in edmTypeConfiguration.Properties.ToArray())
            {
                //
                // The NullableContextAttribute is not inherited so only apply to declared properties
                //
                if (!declaredOnlyPropertyNames.Contains(edmProperty.Name))
                {
                    continue;
                }

                //
                // Do not propagate if it is a value type
                //
                if (TypeHelper.IsValueType(edmProperty.PropertyInfo.PropertyType))
                {
                    continue;
                }

                //
                // Only propagate the NullableContext to properties without a Nullable attribute
                //      
                if (GetNullableAttribute(edmProperty.PropertyInfo) != null)
                {
                    continue;
                }

                if (!edmProperty.ReturnMaybeNull())
                {
                    edmProperty.SetNonNullable();
                }

                //
                // Similar to EF Core, do not try to propagate nullability for generic properties, since calculating
                // that is complex (depends on the nullability of generic type argument).
                // Unlike EF Core, do not special case Dictionary as OData uses that exclusively for open types
                // where NonNullability is not a factor.
                //
            }
        }

        private Attribute GetNullableAttribute(MemberInfo member)
            => member?.GetCustomAttributes(inherit: true)
                      .OfType<Attribute>()
                      .Where(NullableAttributeEdmPropertyConvention.NullableAttributeFilter)
                      .FirstOrDefault();
    }
}
