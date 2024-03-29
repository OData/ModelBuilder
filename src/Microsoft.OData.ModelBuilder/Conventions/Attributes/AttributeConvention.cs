﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Linq;
using System.Reflection;

namespace Microsoft.OData.ModelBuilder.Conventions.Attributes
{
    /// <summary>
    /// Base class for all attribute based conventions.
    /// </summary>
    public abstract class AttributeConvention : IODataModelConvention
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeConvention"/> class.
        /// </summary>
        /// <param name="attributeFilter">A function to test whether this convention applies to an attribute or not.</param>
        /// <param name="allowMultiple"><c>true</c> if the convention allows multiple attributes; otherwise, <c>false</c>.</param>
        protected AttributeConvention(Func<Attribute, bool> attributeFilter, bool allowMultiple)
        {
            if (attributeFilter == null)
            {
                throw Error.ArgumentNull("attributeFilter");
            }

            AllowMultiple = allowMultiple;
            AttributeFilter = attributeFilter;
        }

        /// <summary>
        /// Gets the filter that finds the attributes that this convention applies to.
        /// </summary>
        public Func<Attribute, bool> AttributeFilter { get; private set; }

        /// <summary>
        /// Gets whether this convention allows multiple instances of the attribute.
        /// </summary>
        public bool AllowMultiple { get; private set; }

        /// <summary>
        /// Returns the attributes on <paramref name="member"/> that this convention applies to.
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public Attribute[] GetAttributes(MemberInfo member)
        {
            if (member == null)
            {
                throw Error.ArgumentNull("member");
            }

            Attribute[] attributes =
                member
                .GetCustomAttributes(inherit: true)
                .OfType<Attribute>()
                .Where(AttributeFilter)
                .ToArray();

            if (!AllowMultiple && attributes.Length > 1)
            {
                throw Error.Argument(
                    "member",
                    SRResources.MultipleAttributesFound,
                    member.Name,
                    TypeHelper.GetReflectedType(member).Name,
                    attributes.First().GetType().Name);
            }

            return attributes;
        }
    }
}
