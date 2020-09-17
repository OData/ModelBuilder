// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Reflection;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder.Annotations
{
    /// <summary>
    /// The extensions for the <see cref="IEdmModel"/> for the annotations.
    /// </summary>
    public static class EdmAnnotationExtensions
    {
        /// <summary>
        /// Sets the CLR Type for the Edm structural type.
        /// </summary>
        /// <typeparam name="T">The CLR type.</typeparam>
        /// <param name="edmModel">The Edm model.</param>
        /// <param name="structuredType">The Edm structured type.</param>
        public static void SetClrType<T>(this IEdmModel edmModel, IEdmStructuredType structuredType) where T: class
        {
            edmModel.SetClrType(structuredType, typeof(T));
        }

        /// <summary>
        /// Sets the CLR Type for the Edm structural type.
        /// </summary>
        /// <param name="edmModel">The Edm model.</param>
        /// <param name="structuredType">The Edm structured type.</param>
        /// <param name="clrType">The clr Type.</param>
        public static void SetClrType(this IEdmModel edmModel, IEdmStructuredType structuredType, Type clrType)
        {
            if (edmModel == null)
            {
                throw Error.ArgumentNull(nameof(edmModel));
            }

            if (structuredType == null)
            {
                throw Error.ArgumentNull(nameof(structuredType));
            }

            if (clrType == null)
            {
                throw Error.ArgumentNull(nameof(clrType));
            }

            if (!clrType.IsClass)
            {
                throw Error.Argument("clrType", SRResources.ArgumentMustBeOfType, "class");
            }

            edmModel.SetAnnotationValue(structuredType, new ClrTypeAnnotation(clrType));
        }

        /// <summary>
        /// Get the CLR property name.
        /// </summary>
        /// <param name="edmModel">The Edm model.</param>
        /// <param name="edmProperty">The Edm property.</param>
        /// <returns>The property name.</returns>
        public static string GetClrPropertyName(this IEdmModel edmModel, IEdmProperty edmProperty)
        {
            if (edmModel == null)
            {
                throw new ArgumentNullException(nameof(edmModel));
            }

            if (edmProperty == null)
            {
                throw new ArgumentNullException(nameof(edmProperty));
            }

            string propertyName = edmProperty.Name;
            ClrPropertyInfoAnnotation annotation = edmModel.GetAnnotationValue<ClrPropertyInfoAnnotation>(edmProperty);
            if (annotation != null)
            {
                PropertyInfo propertyInfo = annotation.ClrPropertyInfo;
                if (propertyInfo != null)
                {
                    propertyName = propertyInfo.Name;
                }
            }

            return propertyName;
        }

        /// <summary>
        /// Gets the dynamic property container name.
        /// </summary>
        /// <param name="edmModel">The Edm model.</param>
        /// <param name="edmType">The Edm type.</param>
        /// <returns>The dynamic property container property info.</returns>
        public static PropertyInfo GetDynamicPropertyDictionary(this IEdmModel edmModel, IEdmStructuredType edmType)
        {
            if (edmModel == null)
            {
                throw new ArgumentNullException(nameof(edmModel));
            }

            if (edmType == null)
            {
                throw new ArgumentNullException(nameof(edmType));
            }

            DynamicPropertyDictionaryAnnotation annotation =
                edmModel.GetAnnotationValue<DynamicPropertyDictionaryAnnotation>(edmType);
            if (annotation != null)
            {
                return annotation.PropertyInfo;
            }

            return null;
        }

        /// <summary>
        /// Gets the Enum member annotations.
        /// </summary>
        /// <param name="edmModel">The Edm model.</param>
        /// <param name="enumType">The Enum Type.</param>
        /// <returns>The Enum member annotation.</returns>
        public static ClrEnumMemberAnnotation GetClrEnumMemberAnnotation(this IEdmModel edmModel, IEdmEnumType enumType)
        {
            if (edmModel == null)
            {
                throw new ArgumentNullException(nameof(edmModel));
            }

            if (enumType == null)
            {
                throw new ArgumentNullException(nameof(enumType));
            }

            ClrEnumMemberAnnotation annotation = edmModel.GetAnnotationValue<ClrEnumMemberAnnotation>(enumType);
            if (annotation != null)
            {
                return annotation;
            }

            return null;
        }
    }
}
