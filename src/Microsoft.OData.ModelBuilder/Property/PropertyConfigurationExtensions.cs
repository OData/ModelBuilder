// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System.Diagnostics.Contracts;
using System.Linq;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Extensions method for <see cref="PropertyConfiguration"/>.
    /// </summary>
    internal static class PropertyConfigurationExtensions
    {
        /// <summary>
        /// Determine if the EDM PropertyConfiguration is already set to be NonNullable
        /// </summary>
        /// <param name="edmProperty">The <see cref="PropertyConfiguration"/> being extended.</param>
        /// <returns><c>true</c> if NonNullable</returns>
        internal static bool NonNullable(this PropertyConfiguration edmProperty)
        {
            Contract.Assert(edmProperty != null);

            //
            // Check if already NonNullable
            //
            if (edmProperty is StructuralPropertyConfiguration structuralProperty && structuralProperty.NullableProperty == false)
            {
                return true;
            }

            if (edmProperty is NavigationPropertyConfiguration navigationProperty)
            {
                switch (navigationProperty.Multiplicity)
                {
                    case Edm.EdmMultiplicity.Many:      // Can't change Many
                    case Edm.EdmMultiplicity.One:       // Already NonNullable
                        return true;
                    case Edm.EdmMultiplicity.Unknown:
                    case Edm.EdmMultiplicity.ZeroOrOne:
                    default:
                        break;
                }
            }

            return false;
        }

        /// <summary>
        /// Determine if the EDM PropertyConfiguration has [MaybeNull] on return value
        /// </summary>
        /// <param name="edmProperty">The <see cref="PropertyConfiguration"/> being extended.</param>
        /// <returns><c>true</c> if MaybeNull set</returns>
        internal static bool ReturnMaybeNull(this PropertyConfiguration edmProperty)
        {
            Contract.Assert(edmProperty != null);

            const string MaybeNullAttributeFullName = "System.Diagnostics.CodeAnalysis.MaybeNullAttribute";

            //
            // Check for [MaybeNull] on the return value. If it exists, the member is nullable.
            // Note: avoid using GetCustomAttribute<> below because of https://github.com/mono/mono/issues/17477
            //
            return ((edmProperty.PropertyInfo
                                .GetMethod?
                                .ReturnParameter)?
                                .CustomAttributes)
                                .Any(a => a.AttributeType.FullName == MaybeNullAttributeFullName);
        }

        /// <summary>
        /// Set the EDM PropertyConfiguration to be NonNullable
        /// </summary>
        /// <param name="edmProperty">The <see cref="PropertyConfiguration"/> being extended.</param>
        internal static void SetNonNullable(this PropertyConfiguration edmProperty)
        {
            Contract.Assert(edmProperty != null);

            //
            // Only make NonNullable if not already set
            //
            if (edmProperty is StructuralPropertyConfiguration structuralProperty)
            {
                if (structuralProperty.NullableProperty == false)
                {
                    return;
                }

                structuralProperty.NullableProperty = false;
            }

            if (edmProperty is NavigationPropertyConfiguration navigationProperty)
            {
                switch (navigationProperty.Multiplicity)
                {
                    case Edm.EdmMultiplicity.Many:      // Can't change Many
                    case Edm.EdmMultiplicity.One:       // Already NonNullable
                        return;
                    default:
                        break;
                }

                navigationProperty.Required();
            }
        }
    }
}
