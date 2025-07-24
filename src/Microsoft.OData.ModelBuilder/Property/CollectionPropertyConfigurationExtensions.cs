// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Extension methods for <see cref="CollectionPropertyConfiguration"/>.
    /// </summary>
    public static class CollectionPropertyConfigurationExtensions
    {
        /// <summary>
        /// Sets an Edm spatial primitive type kind (e.g., GeographyPoint, GeometryLineString, etc).
        /// </summary>
        /// <param name="property">Reference to the calling primitive property configuration.</param>
        /// <param name="spatialKind">The spatial kind to set.</param>
        /// <returns>Returns itself so that multiple calls can be chained.</returns>
        public static CollectionPropertyConfiguration AsSpatial(this CollectionPropertyConfiguration property, EdmPrimitiveTypeKind spatialKind)
        {
            if (property == null)
            {
                throw Error.ArgumentNull("property");
            }

            if (!IsSpatialKind(spatialKind))
            {
                throw Error.Argument("spatialKind",
                    SRResources.MustBeSpatialEdmTypeKind,
                    spatialKind.ToString(),
                    property.PropertyInfo.Name,
                    property.DeclaringType.FullName);
            }

            property.ElementTargetEdmTypeKind = spatialKind;
            return property;
        }

        internal static bool IsSpatialKind(EdmPrimitiveTypeKind kind)
        {
            switch (kind)
            {
                case EdmPrimitiveTypeKind.Geometry:
                case EdmPrimitiveTypeKind.GeometryPoint:
                case EdmPrimitiveTypeKind.GeometryLineString:
                case EdmPrimitiveTypeKind.GeometryPolygon:
                case EdmPrimitiveTypeKind.GeometryMultiPoint:
                case EdmPrimitiveTypeKind.GeometryMultiLineString:
                case EdmPrimitiveTypeKind.GeometryMultiPolygon:
                case EdmPrimitiveTypeKind.GeometryCollection:
                case EdmPrimitiveTypeKind.Geography:
                case EdmPrimitiveTypeKind.GeographyPoint:
                case EdmPrimitiveTypeKind.GeographyLineString:
                case EdmPrimitiveTypeKind.GeographyPolygon:
                case EdmPrimitiveTypeKind.GeographyMultiPoint:
                case EdmPrimitiveTypeKind.GeographyMultiLineString:
                case EdmPrimitiveTypeKind.GeographyMultiPolygon:
                case EdmPrimitiveTypeKind.GeographyCollection:
                    return true;
                default:
                    return false;
            }
        }
    }
}
