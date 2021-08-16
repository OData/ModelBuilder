// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Represents an <see cref="IEdmStructuredType"/> that can be built using <see cref="ODataModelBuilder"/>.
    /// </summary>
    public abstract class StructuralTypeConfiguration<TStructuralType> where TStructuralType : class
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StructuralTypeConfiguration{TStructuralType}"/> class.
        /// </summary>
        /// <param name="configuration">The inner configuration of the structural type.</param>
        protected StructuralTypeConfiguration(StructuralTypeConfiguration configuration)
        {
            Configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        /// <summary>
        /// Gets the collection of EDM structural properties that belong to this type.
        /// </summary>
        public IEnumerable<PropertyConfiguration> Properties => Configuration.Properties;

        /// <summary>
        /// Gets the full name of this EDM type.
        /// </summary>
        public string FullName => Configuration.FullName;

        /// <summary>
        /// Gets and sets the namespace of this EDM type.
        /// </summary>
        public string Namespace
        {
            get => Configuration.Namespace;
            set => Configuration.Namespace = value;
        }

        /// <summary>
        /// Gets and sets the name of this EDM type.
        /// </summary>
        public string Name
        {
            get => Configuration.Name;
            set => Configuration.Name = value;
        }

        /// <summary>
        /// Gets an indicator whether this EDM type is an open type or not.
        /// Returns <c>true</c> if this is an open type; <c>false</c> otherwise.
        /// </summary>
        public bool IsOpen => Configuration.IsOpen;

        internal StructuralTypeConfiguration Configuration { get; }

        /// <summary>
        /// Excludes a property from the type.
        /// </summary>
        /// <typeparam name="TProperty">The property type.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <remarks>This method is used to exclude properties from the type that would have been added by convention during model discovery.</remarks>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        public virtual void Ignore<TProperty>(Expression<Func<TStructuralType, TProperty>> propertyExpression)
        {
            PropertyInfo ignoredProperty = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);
            Configuration.RemoveProperty(ignoredProperty);
        }

        /// <summary>
        /// Adds a string property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public LengthPropertyConfiguration Property(Expression<Func<TStructuralType, string>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true) as LengthPropertyConfiguration;
        }

        /// <summary>
        /// Adds a binary property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public LengthPropertyConfiguration Property(Expression<Func<TStructuralType, byte[]>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true) as LengthPropertyConfiguration;
        }

        /// <summary>
        /// Adds a stream property the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrimitivePropertyConfiguration Property(Expression<Func<TStructuralType, Stream>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true);
        }

        /// <summary>
        /// Adds an decimal primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public DecimalPropertyConfiguration Property(Expression<Func<TStructuralType, decimal?>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true) as DecimalPropertyConfiguration;
        }

        /// <summary>
        /// Adds an decimal primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public DecimalPropertyConfiguration Property(Expression<Func<TStructuralType, decimal>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: false) as DecimalPropertyConfiguration;
        }

        /// <summary>
        /// Adds an time-of-day primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrecisionPropertyConfiguration Property(Expression<Func<TStructuralType, TimeOfDay?>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true) as PrecisionPropertyConfiguration;
        }

        /// <summary>
        /// Adds an time-of-day primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrecisionPropertyConfiguration Property(Expression<Func<TStructuralType, TimeOfDay>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: false) as PrecisionPropertyConfiguration;
        }

        /// <summary>
        /// Adds an duration primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrecisionPropertyConfiguration Property(Expression<Func<TStructuralType, TimeSpan?>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true) as PrecisionPropertyConfiguration;
        }

        /// <summary>
        /// Adds an duration primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrecisionPropertyConfiguration Property(Expression<Func<TStructuralType, TimeSpan>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: false) as PrecisionPropertyConfiguration;
        }

        /// <summary>
        /// Adds an datetime-with-offset primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrecisionPropertyConfiguration Property(Expression<Func<TStructuralType, DateTimeOffset?>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true) as PrecisionPropertyConfiguration;
        }

        /// <summary>
        /// Adds an datetime-with-offset primitive property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrecisionPropertyConfiguration Property(Expression<Func<TStructuralType, DateTimeOffset>> propertyExpression)
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: false) as PrecisionPropertyConfiguration;
        }

        /// <summary>
        /// Adds an untyped (object) property to the EDM type.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        public UntypedPropertyConfiguration Property(Expression<Func<TStructuralType, object>> propertyExpression)
        {
            PropertyInfo propertyInfo = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);

            UntypedPropertyConfiguration property = Configuration.AddUntypedProperty(propertyInfo);
            property.IsNullable(); // by default always nullable?
            return property;
        }

        /// <summary>
        /// Adds an optional primitive property to the EDM type.
        /// </summary>
        /// <typeparam name="T">The primitive property type.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrimitivePropertyConfiguration Property<T>(Expression<Func<TStructuralType, T?>> propertyExpression) where T : struct
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: true);
        }

        /// <summary>
        /// Adds a required primitive property to the EDM type.
        /// </summary>
        /// <typeparam name="T">The primitive property type.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public PrimitivePropertyConfiguration Property<T>(Expression<Func<TStructuralType, T>> propertyExpression) where T : struct
        {
            return GetPrimitivePropertyConfiguration(propertyExpression, nullable: false);
        }

        /// <summary>
        /// Adds an optional enum property to the EDM type.
        /// </summary>
        /// <typeparam name="T">The enum property type.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public EnumPropertyConfiguration EnumProperty<T>(Expression<Func<TStructuralType, T?>> propertyExpression) where T : struct
        {
            return GetEnumPropertyConfiguration(propertyExpression, nullable: true);
        }

        /// <summary>
        /// Adds a required enum property to the EDM type.
        /// </summary>
        /// <typeparam name="T">The enum property type.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public EnumPropertyConfiguration EnumProperty<T>(Expression<Func<TStructuralType, T>> propertyExpression) where T : struct
        {
            return GetEnumPropertyConfiguration(propertyExpression, nullable: false);
        }

        /// <summary>
        /// Adds a complex property to the EDM type.
        /// </summary>
        /// <typeparam name="TComplexType">The complex type.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public ComplexPropertyConfiguration ComplexProperty<TComplexType>(Expression<Func<TStructuralType, TComplexType>> propertyExpression)
        {
            return GetComplexPropertyConfiguration(propertyExpression);
        }

        /// <summary>
        /// Adds a collection property to the EDM type.
        /// </summary>
        /// <typeparam name="TElementType">The element type of the collection.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the property.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "More specific expression type is clearer")]
        public CollectionPropertyConfiguration CollectionProperty<TElementType>(Expression<Func<TStructuralType, IEnumerable<TElementType>>> propertyExpression)
        {
            return GetCollectionPropertyConfiguration(propertyExpression);
        }

        /// <summary>
        /// Adds a dynamic property dictionary property.
        /// </summary>
        /// <param name="propertyExpression">A lambda expression representing the dynamic property dictionary for the relationship.
        /// For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generics appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "More specific expression type is clearer")]
        public void HasDynamicProperties(Expression<Func<TStructuralType, IDictionary<string, object>>> propertyExpression)
        {
            PropertyInfo propertyInfo = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);

            Configuration.AddDynamicPropertyDictionary(propertyInfo);
        }

        /// <summary>
        /// Adds the Instance annotation container property.
        /// </summary>
        /// <typeparam name="T">The instance annotation type.</typeparam>
        /// <param name="propertyExpression">A lambda expression representing the instance annotation property container for the relationship.</param>
        public void HasInstanceAnnotations<T>(Expression<Func<TStructuralType, T>> propertyExpression)
            where T : IODataInstanceAnnotationContainer
        {
            PropertyInfo propertyInfo = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);

            Configuration.AddInstanceAnnotationContainer(propertyInfo);
        }

        /// <summary>
        /// Configures a many relationship from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship. For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasMany<TTargetEntity>(Expression<Func<TStructuralType, IEnumerable<TTargetEntity>>> navigationPropertyExpression) where TTargetEntity : class
        {
            return GetOrCreateNavigationProperty(navigationPropertyExpression, EdmMultiplicity.Many);
        }

        /// <summary>
        /// Configures an optional relationship from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship. For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasOptional<TTargetEntity>(Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression) where TTargetEntity : class
        {
            return GetOrCreateNavigationProperty(navigationPropertyExpression, EdmMultiplicity.ZeroOrOne);
        }

        /// <summary>
        /// Configures an optional relationship with referential constraint from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t =&gt; t.Customer</c> and in Visual Basic .NET <c>Function(t) t.Customer</c>.</param>
        /// <param name="referentialConstraintExpression">A lambda expression representing the referential constraint. For example,
        ///  in C# <c>(o, c) =&gt; o.CustomerId == c.Id</c> and in Visual Basic .NET <c>Function(o, c) c.CustomerId == c.Id</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasOptional<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression,
            Expression<Func<TStructuralType, TTargetEntity, bool>> referentialConstraintExpression) where TTargetEntity : class
        {
            return HasNavigationProperty(
                navigationPropertyExpression,
                referentialConstraintExpression,
                EdmMultiplicity.ZeroOrOne,
                null);
        }

        /// <summary>
        /// Configures an optional relationship with referential constraint from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t =&gt; t.Customer</c> and in Visual Basic .NET <c>Function(t) t.Customer</c>.</param>
        /// <param name="referentialConstraintExpression">A lambda expression representing the referential constraint. For example,
        ///  in C# <c>(o, c) =&gt; o.CustomerId == c.Id</c> and in Visual Basic .NET <c>Function(o, c) c.CustomerId == c.Id</c>.</param>
        /// <param name="partnerExpression">The partner expression for this relationship.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasOptional<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression,
            Expression<Func<TStructuralType, TTargetEntity, bool>> referentialConstraintExpression,
            Expression<Func<TTargetEntity, IEnumerable<TStructuralType>>> partnerExpression) where TTargetEntity : class
        {
            return HasNavigationProperty(
                navigationPropertyExpression,
                referentialConstraintExpression,
                EdmMultiplicity.ZeroOrOne,
                partnerExpression);
        }

        /// <summary>
        /// Configures an optional relationship with referential constraint from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t =&gt; t.Customer</c> and in Visual Basic .NET <c>Function(t) t.Customer</c>.</param>
        /// <param name="referentialConstraintExpression">A lambda expression representing the referential constraint. For example,
        ///  in C# <c>(o, c) =&gt; o.CustomerId == c.Id</c> and in Visual Basic .NET <c>Function(o, c) c.CustomerId == c.Id</c>.</param>
        /// <param name="partnerExpression">The partner expression for this relationship.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasOptional<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression,
            Expression<Func<TStructuralType, TTargetEntity, bool>> referentialConstraintExpression,
            Expression<Func<TTargetEntity, TStructuralType>> partnerExpression) where TTargetEntity : class
        {
            return HasNavigationProperty(
                navigationPropertyExpression,
                referentialConstraintExpression,
                EdmMultiplicity.ZeroOrOne,
                partnerExpression);
        }

        /// <summary>
        /// Configures a required relationship from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship. For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters", Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasRequired<TTargetEntity>(Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression) where TTargetEntity : class
        {
            return GetOrCreateNavigationProperty(navigationPropertyExpression, EdmMultiplicity.One);
        }

        /// <summary>
        /// Configures a required relationship with referential constraint from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t =&gt; t.Customer</c> and in Visual Basic .NET <c>Function(t) t.Customer</c>.</param>
        /// <param name="referentialConstraintExpression">A lambda expression representing the referential constraint. For example,
        ///  in C# <c>(o, c) =&gt; o.CustomerId == c.Id</c> and in Visual Basic .NET <c>Function(o, c) c.CustomerId == c.Id</c>.</param>
        /// <param name="partnerExpression">The partner expression for this relationship.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasRequired<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression,
            Expression<Func<TStructuralType, TTargetEntity, bool>> referentialConstraintExpression,
            Expression<Func<TTargetEntity, IEnumerable<TStructuralType>>> partnerExpression) where TTargetEntity : class
        {
            return HasNavigationProperty(navigationPropertyExpression, referentialConstraintExpression, EdmMultiplicity.One, partnerExpression);
        }

        /// <summary>
        /// Configures a required relationship with referential constraint from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t =&gt; t.Customer</c> and in Visual Basic .NET <c>Function(t) t.Customer</c>.</param>
        /// <param name="referentialConstraintExpression">A lambda expression representing the referential constraint. For example,
        ///  in C# <c>(o, c) =&gt; o.CustomerId == c.Id</c> and in Visual Basic .NET <c>Function(o, c) c.CustomerId == c.Id</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasRequired<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression,
            Expression<Func<TStructuralType, TTargetEntity, bool>> referentialConstraintExpression) where TTargetEntity : class
        {
            return HasNavigationProperty(navigationPropertyExpression, referentialConstraintExpression, EdmMultiplicity.One, null);
        }

        /// <summary>
        /// Configures a required relationship with referential constraint from this structural type.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for the relationship.
        /// For example, in C# <c>t =&gt; t.Customer</c> and in Visual Basic .NET <c>Function(t) t.Customer</c>.</param>
        /// <param name="referentialConstraintExpression">A lambda expression representing the referential constraint. For example,
        ///  in C# <c>(o, c) =&gt; o.CustomerId == c.Id</c> and in Visual Basic .NET <c>Function(o, c) c.CustomerId == c.Id</c>.</param>
        /// <param name="partnerExpression"></param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration HasRequired<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression,
            Expression<Func<TStructuralType, TTargetEntity, bool>> referentialConstraintExpression,
            Expression<Func<TTargetEntity, TStructuralType>> partnerExpression) where TTargetEntity : class
        {
            return HasNavigationProperty(navigationPropertyExpression, referentialConstraintExpression, EdmMultiplicity.One, partnerExpression);
        }

        private NavigationPropertyConfiguration HasNavigationProperty<TTargetEntity>(Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression,
            Expression<Func<TStructuralType, TTargetEntity, bool>> referentialConstraintExpression, EdmMultiplicity multiplicity, Expression partnerProperty)
            where TTargetEntity : class
        {
            NavigationPropertyConfiguration navigation =
                GetOrCreateNavigationProperty(navigationPropertyExpression, multiplicity);

            IDictionary<PropertyInfo, PropertyInfo> referentialConstraints =
                PropertyPairSelectorVisitor.GetSelectedProperty(referentialConstraintExpression);

            foreach (KeyValuePair<PropertyInfo, PropertyInfo> constraint in referentialConstraints)
            {
                navigation.HasConstraint(constraint);
            }

            if (partnerProperty != null)
            {
                var partnerPropertyInfo = PropertySelectorVisitor.GetSelectedProperty(partnerProperty);
                if (typeof(IEnumerable).IsAssignableFrom(partnerPropertyInfo.PropertyType))
                {
                    Configuration.ModelBuilder
                        .EntityType<TTargetEntity>().HasMany((Expression<Func<TTargetEntity, IEnumerable<TStructuralType>>>)partnerProperty);
                }
                else
                {
                    Configuration.ModelBuilder
                        .EntityType<TTargetEntity>().HasRequired((Expression<Func<TTargetEntity, TStructuralType>>)partnerProperty);
                }
                var prop = Configuration.ModelBuilder
                        .EntityType<TTargetEntity>()
                        .Properties
                        .First(p => p.Name == partnerPropertyInfo.Name)
                    as NavigationPropertyConfiguration;

                navigation.Partner = prop;
            }

            return navigation;
        }

        /// <summary>
        /// Configures a relationship from this structural type to a contained collection navigation property.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for
        ///  the relationship. For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET
        ///  <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration ContainsMany<TTargetEntity>(
            Expression<Func<TStructuralType, IEnumerable<TTargetEntity>>> navigationPropertyExpression)
            where TTargetEntity : class
        {
            return GetOrCreateContainedNavigationProperty(navigationPropertyExpression, EdmMultiplicity.Many);
        }

        /// <summary>
        /// Configures an optional relationship from this structural type to a single contained navigation property.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for
        ///  the relationship. For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET
        ///  <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        [SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures",
            Justification = "Nested generic appropriate here")]
        [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters",
            Justification = "Explicit Expression generic type is more clear")]
        public NavigationPropertyConfiguration ContainsOptional<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression) where TTargetEntity : class
        {
            return GetOrCreateContainedNavigationProperty(navigationPropertyExpression, EdmMultiplicity.ZeroOrOne);
        }

        /// <summary>
        /// Configures a required relationship from this structural type to a single contained navigation property.
        /// </summary>
        /// <typeparam name="TTargetEntity">The type of the entity at the other end of the relationship.</typeparam>
        /// <param name="navigationPropertyExpression">A lambda expression representing the navigation property for
        ///  the relationship. For example, in C# <c>t => t.MyProperty</c> and in Visual Basic .NET
        ///  <c>Function(t) t.MyProperty</c>.</param>
        /// <returns>A configuration object that can be used to further configure the relationship.</returns>
        public NavigationPropertyConfiguration ContainsRequired<TTargetEntity>(
            Expression<Func<TStructuralType, TTargetEntity>> navigationPropertyExpression) where TTargetEntity : class
        {
            return GetOrCreateContainedNavigationProperty(navigationPropertyExpression, EdmMultiplicity.One);
        }


        /// <summary>
        /// Sets this property is countable of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Count()
        {
            Configuration.QueryConfiguration.SetCount(true);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets whether this property is countable of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Count(bool enabled)
        {
            Configuration.QueryConfiguration.SetCount(enabled);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets sortable properties depends on boolean value of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> OrderBy(bool enabled, params string[] properties)
        {
            Configuration.QueryConfiguration.SetOrderBy(properties, enabled);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets sortable properties of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> OrderBy(params string[] properties)
        {
            Configuration.QueryConfiguration.SetOrderBy(properties, true);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets whether all properties of this structural type is sortable.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> OrderBy(bool enabled)
        {
            Configuration.QueryConfiguration.SetOrderBy(null, enabled);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets all properties of this structural type is sortable.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> OrderBy()
        {
            Configuration.QueryConfiguration.SetOrderBy(null, true);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets filterable properties depends on boolean value of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Filter(bool enabled, params string[] properties)
        {
            Configuration.QueryConfiguration.SetFilter(properties, enabled);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets filterable properties of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Filter(params string[] properties)
        {
            Configuration.QueryConfiguration.SetFilter(properties, true);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets whether all properties of this structural type is filterable.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Filter(bool enabled)
        {
            Configuration.QueryConfiguration.SetFilter(null, enabled);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets all properties of this structural type is filterable.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Filter()
        {
            Configuration.QueryConfiguration.SetFilter(null, true);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets selectable properties depends on <see cref="SelectExpandType"/> of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Select(SelectExpandType selectType,
            params string[] properties)
        {
            Configuration.QueryConfiguration.SetSelect(properties, selectType);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets selectable properties of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Select(params string[] properties)
        {
            Configuration.QueryConfiguration.SetSelect(properties, SelectExpandType.Allowed);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets <see cref="SelectExpandType"/> of all properties of this structural type is selectable.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Select(SelectExpandType selectType)
        {
            Configuration.QueryConfiguration.SetSelect(null, selectType);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets all properties of this structural type is selectable.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Select()
        {
            Configuration.QueryConfiguration.SetSelect(null, SelectExpandType.Allowed);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets the max value of $top of this structural type that a client can request
        /// and the maximum number of query results of this entity type to return.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Page(int? maxTopValue, int? pageSizeValue)
        {
            Configuration.QueryConfiguration.SetMaxTop(maxTopValue);
            Configuration.QueryConfiguration.SetPageSize(pageSizeValue);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets the properties of this structural type enable paging.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Page()
        {
            Configuration.QueryConfiguration.SetMaxTop(null);
            Configuration.QueryConfiguration.SetPageSize(null);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets the maximum depth of expand result,
        /// expandable properties and their <see cref="SelectExpandType"/> of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand(int maxDepth, SelectExpandType expandType, params string[] properties)
        {
            Configuration.QueryConfiguration.SetExpand(properties, maxDepth, expandType);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets the expandable properties of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand(params string[] properties)
        {
            Configuration.QueryConfiguration.SetExpand(properties, null, SelectExpandType.Allowed);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets the maximum depth of expand result,
        /// expandable properties of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand(int maxDepth, params string[] properties)
        {
            Configuration.QueryConfiguration.SetExpand(properties, maxDepth, SelectExpandType.Allowed);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets the expandable properties and their <see cref="SelectExpandType"/> of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand(SelectExpandType expandType, params string[] properties)
        {
            Configuration.QueryConfiguration.SetExpand(properties, null, expandType);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets <see cref="SelectExpandType"/> of all properties with maximum depth of expand result of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand(SelectExpandType expandType, int maxDepth)
        {
            Configuration.QueryConfiguration.SetExpand(null, maxDepth, expandType);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets all properties expandable with maximum depth of expand result of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand(int maxDepth)
        {
            Configuration.QueryConfiguration.SetExpand(null, maxDepth, SelectExpandType.Allowed);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets <see cref="SelectExpandType"/> of all properties of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand(SelectExpandType expandType)
        {
            Configuration.QueryConfiguration.SetExpand(null, null, expandType);
            Configuration.AddedExplicitly = true;
            return this;
        }

        /// <summary>
        /// Sets all properties expandable of this structural type.
        /// </summary>
        public StructuralTypeConfiguration<TStructuralType> Expand()
        {
            Configuration.QueryConfiguration.SetExpand(null, null, SelectExpandType.Allowed);
            Configuration.AddedExplicitly = true;
            return this;
        }

        internal NavigationPropertyConfiguration GetOrCreateNavigationProperty(Expression navigationPropertyExpression, EdmMultiplicity multiplicity)
        {
            PropertyInfo navigationProperty = PropertySelectorVisitor.GetSelectedProperty(navigationPropertyExpression);
            return Configuration.AddNavigationProperty(navigationProperty, multiplicity);
        }

        internal NavigationPropertyConfiguration GetOrCreateContainedNavigationProperty(Expression navigationPropertyExpression, EdmMultiplicity multiplicity)
        {
            PropertyInfo navigationProperty = PropertySelectorVisitor.GetSelectedProperty(navigationPropertyExpression);
            return Configuration.AddContainedNavigationProperty(navigationProperty, multiplicity);
        }

        private PrimitivePropertyConfiguration GetPrimitivePropertyConfiguration(Expression propertyExpression, bool nullable)
        {
            PropertyInfo propertyInfo = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);
            PrimitivePropertyConfiguration property = Configuration.AddProperty(propertyInfo);
            if (nullable)
            {
                property.IsNullable();
            }

            return property;
        }

        private EnumPropertyConfiguration GetEnumPropertyConfiguration(Expression propertyExpression, bool nullable)
        {
            PropertyInfo propertyInfo = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);

            EnumPropertyConfiguration property = Configuration.AddEnumProperty(propertyInfo);
            if (nullable)
            {
                property.IsNullable();
            }

            return property;
        }

        private ComplexPropertyConfiguration GetComplexPropertyConfiguration(Expression propertyExpression, bool nullable = false)
        {
            PropertyInfo propertyInfo = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);
            ComplexPropertyConfiguration property = Configuration.AddComplexProperty(propertyInfo);
            if (nullable)
            {
                property.IsNullable();
            }
            else
            {
                property.IsRequired();
            }

            return property;
        }

        private CollectionPropertyConfiguration GetCollectionPropertyConfiguration(Expression propertyExpression, bool nullable = false)
        {
            PropertyInfo propertyInfo = PropertySelectorVisitor.GetSelectedProperty(propertyExpression);
            CollectionPropertyConfiguration property;

            property = Configuration.AddCollectionProperty(propertyInfo);

            if (nullable)
            {
                property.IsNullable();
            }
            else
            {
                property.IsRequired();
            }

            return property;
        }
    }
}
