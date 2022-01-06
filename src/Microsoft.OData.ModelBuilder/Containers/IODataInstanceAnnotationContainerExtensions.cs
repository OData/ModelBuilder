// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Extensions method on <see cref="IODataInstanceAnnotationContainer"/>.
    /// </summary>
    public static class IODataInstanceAnnotationContainerExtensions
    {
        /// <summary>
        /// Adds an instance annotation to the resource.
        /// </summary>
        /// <param name="container">The instance annotation container.</param>
        /// <param name="annotationName">The annotation name.</param>
        /// <param name="value">The annotation value.</param>
        public static void AddResourceAnnotation(this IODataInstanceAnnotationContainer container, string annotationName, object value)
        {
            container.AddPropertyAnnotation(string.Empty, annotationName, value);
        }

        /// <summary>
        /// Adds an instance annotation to a property.
        /// </summary>
        /// <param name="container">The instance annotation container.</param>
        /// <param name="propertyName">The property name.</param>
        /// <param name="annotationName">The annotation name.</param>
        /// <param name="value">The annotation value.</param>
        public static void AddPropertyAnnotation(this IODataInstanceAnnotationContainer container, string propertyName, string annotationName, object value)
        {
            if (container == null)
            {
                throw Error.ArgumentNull(nameof(container));
            }

            VerifyInstanceAnnotationName(annotationName);

            IDictionary<string, object> annotationDictionary;
            if (!container.InstanceAnnotations.TryGetValue(propertyName, out annotationDictionary))
            {
                annotationDictionary = new Dictionary<string, object>();
                container.InstanceAnnotations.Add(propertyName, annotationDictionary);
            }

            annotationDictionary[annotationName] = value;
        }

        /// <summary>
        /// Gets all instance annotations of a resource.
        /// </summary>
        /// <param name="container">The instance annotation container.</param>
        /// <returns>Dictionary of string(annotation name) and object value(annotation value)</returns>
        public static IDictionary<string, object> GetResourceAnnotations(this IODataInstanceAnnotationContainer container)
        {
            return container.GetPropertyAnnotations(string.Empty);
        }

        /// <summary>
        /// Gets all instance annotations of a property on the resource.
        /// </summary>
        /// <param name="container">The instance annotation container.</param>
        /// <param name="propertyName">The property name.</param>
        /// <returns>Dictionary of string(annotation name) and object value(annotation value)</returns>
        public static IDictionary<string, object> GetPropertyAnnotations(this IODataInstanceAnnotationContainer container, string propertyName)
        {
            if (container == null)
            {
                throw Error.ArgumentNull(nameof(container));
            }

            return container.InstanceAnnotations.TryGetValue(propertyName, out IDictionary<string, object> annotationDictionary) ?
                annotationDictionary :
                null;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = "<Pending>")]
        private static void VerifyInstanceAnnotationName(string annotationName)
        {
            if (string.IsNullOrEmpty(annotationName) || !annotationName.Contains("."))
            {
                throw Error.Argument(nameof(annotationName), SRResources.InvalidInstanceAnnotationName, annotationName);
            }
        }
    }
}
