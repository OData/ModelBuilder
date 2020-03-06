// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.OData.Edm;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// <see cref="ODataConventionModelBuilder"/> is used to automatically map CLR classes to an EDM model based on a set of <see cref="IODataModelConvention"/>.
    /// </summary>
    public class ODataConventionModelBuilder : ODataModelBuilder
    {
        // build the mapping between type and its derived types to be used later.
        private Lazy<IDictionary<Type, List<Type>>> _allTypesWithDerivedTypeMapping;
        private bool _isModelBeingBuilt;
        private HashSet<Type> _ignoredTypes;
        private bool _isQueryCompositionMode;

        /// <summary>
        /// Initializes a new instance of the <see cref="ODataConventionModelBuilder"/> class.
        /// This constructor will work stand-alone scenarios and require using the
        /// <see cref="AppDomain"/> to get a list of assemblies in the domain.
        /// </summary>
        public ODataConventionModelBuilder()
            : this(DefaultAssemblyResolver.Default)
        {
        }

        /// <summary>
        /// Initializes a new <see cref="ODataConventionModelBuilder"/>.
        /// </summary>
        /// <param name="resolver">The <see cref="IAssemblyResolver"/> to use.</param>
        public ODataConventionModelBuilder(IAssemblyResolver resolver)
            : this(resolver, isQueryCompositionMode: false)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ODataConventionModelBuilder"/> class.
        /// </summary>
        /// <param name="resolver">The <see cref="IAssemblyResolver"/> to use.</param>
        /// <param name="isQueryCompositionMode">If the model is being built for only querying.</param>
        /// <remarks>The model built if <paramref name="isQueryCompositionMode"/> is <c>true</c> has more relaxed
        /// inference rules and also treats all types as entity types. This constructor is intended for use by unit testing only.</remarks>
        public ODataConventionModelBuilder(IAssemblyResolver resolver, bool isQueryCompositionMode)
        {
            if (resolver == null)
            {
                throw Error.ArgumentNull("resolver");
            }

            Initialize(resolver, isQueryCompositionMode);
        }

        /// <summary>
        /// Gets or sets if model aliasing is enabled or not. The default value is true.
        /// </summary>
        public bool ModelAliasingEnabled { get; set; }

        /// <summary>
        /// This action is invoked after the <see cref="ODataConventionModelBuilder"/> has run all the conventions, but before the configuration is locked
        /// down and used to build the <see cref="IEdmModel"/>.
        /// </summary>
        /// <remarks>Use this action to modify the <see cref="ODataModelBuilder"/> configuration that has been inferred by convention.</remarks>
        public Action<ODataConventionModelBuilder> OnModelCreating { get; set; }

        internal void Initialize(IAssemblyResolver assembliesResolver, bool isQueryCompositionMode)
        {
            _isModelBeingBuilt = false;
            _ignoredTypes = new HashSet<Type>();
            
            _isQueryCompositionMode = isQueryCompositionMode;/*
            _configuredNavigationSources = new HashSet<NavigationSourceConfiguration>();
            _mappedTypes = new HashSet<StructuralTypeConfiguration>();
            
            ModelAliasingEnabled = true;*/
            _allTypesWithDerivedTypeMapping = new Lazy<IDictionary<Type, List<Type>>>(
                () => BuildDerivedTypesMapping(assembliesResolver),
                isThreadSafe: false);
        }

        /// <summary>
        /// Excludes a type from the model. This is used to remove types from the model that were added by convention during initial model discovery.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>The same <c ref="ODataConventionModelBuilder"/> so that multiple calls can be chained.</returns>
        [SuppressMessage("Microsoft.Design", "CA1004: GenericMethodsShouldProvideTypeParameter",
            Justification = "easier to call the generic version than using typeof().")]
        public ODataConventionModelBuilder Ignore<T>()
        {
            _ignoredTypes.Add(typeof(T));
            return this;
        }

        /// <summary>
        /// Excludes a type or types from the model. This is used to remove types from the model that were added by convention during initial model discovery.
        /// </summary>
        /// <param name="types">The types to be excluded from the model.</param>
        /// <returns>The same <c ref="ODataConventionModelBuilder"/> so that multiple calls can be chained.</returns>
        public ODataConventionModelBuilder Ignore(params Type[] types)
        {
            foreach (Type type in types)
            {
                _ignoredTypes.Add(type);
            }

            return this;
        }

        /// <inheritdoc />
        public override EntityTypeConfiguration AddEntityType(Type type)
        {
            EntityTypeConfiguration entityTypeConfiguration = base.AddEntityType(type);

            if (_isModelBeingBuilt)
            {
                //MapType(entityTypeConfiguration);
            }

            return entityTypeConfiguration;
        }

        /// <inheritdoc />
        public override ComplexTypeConfiguration AddComplexType(Type type)
        {
            ComplexTypeConfiguration complexTypeConfiguration = base.AddComplexType(type);
            /*
            if (_isModelBeingBuilt)
            {
                MapType(complexTypeConfiguration);
            }
            */
            return complexTypeConfiguration;
        }

        /// <inheritdoc />
        public override EntitySetConfiguration AddEntitySet(string name, EntityTypeConfiguration entityType)
        {
            EntitySetConfiguration entitySetConfiguration = base.AddEntitySet(name, entityType);
            /*
            if (_isModelBeingBuilt)
            {
                ApplyNavigationSourceConventions(entitySetConfiguration);
            }
            */
            return entitySetConfiguration;
        }

        /// <inheritdoc />
        public override SingletonConfiguration AddSingleton(string name, EntityTypeConfiguration entityType)
        {
            SingletonConfiguration singletonConfiguration = base.AddSingleton(name, entityType);
            /*
            if (_isModelBeingBuilt)
            {
                ApplyNavigationSourceConventions(singletonConfiguration);
            }
            */
            return singletonConfiguration;
        }

        /// <inheritdoc />
        public override EnumTypeConfiguration AddEnumType(Type type)
        {
            if (type == null)
            {
                throw Error.ArgumentNull("type");
            }

            if (!TypeHelper.IsEnum(type))
            {
                throw Error.Argument("type", SRResources.TypeCannotBeEnum, type.FullName);
            }

            EnumTypeConfiguration enumTypeConfiguration = EnumTypes.SingleOrDefault(e => e.ClrType == type);

            if (enumTypeConfiguration == null)
            {
                enumTypeConfiguration = base.AddEnumType(type);

                foreach (object member in Enum.GetValues(type))
                {
                    bool addedExplicitly = enumTypeConfiguration.Members.Any(m => m.Name.Equals(member.ToString(), StringComparison.Ordinal));
                    EnumMemberConfiguration enumMemberConfiguration = enumTypeConfiguration.AddMember((Enum)member);
                    enumMemberConfiguration.AddedExplicitly = addedExplicitly;
                }

                // ApplyEnumTypeConventions(enumTypeConfiguration);
            }

            return enumTypeConfiguration;
        }

        private static Dictionary<Type, List<Type>> BuildDerivedTypesMapping(IAssemblyResolver assemblyResolver)
        {
            IEnumerable<Type> allTypes = TypeHelper.GetLoadedTypes(assemblyResolver)
                .Where(t => TypeHelper.IsVisible(t) && TypeHelper.IsClass(t) && t != typeof(object));

            Dictionary<Type, List<Type>> allTypeMapping = allTypes.Distinct()
                .ToDictionary(k => k, k => new List<Type>());

            foreach (Type type in allTypes)
            {
                List<Type> derivedTypes;
                if (TypeHelper.GetBaseType(type) != null && allTypeMapping.TryGetValue(TypeHelper.GetBaseType(type), out derivedTypes))
                {
                    derivedTypes.Add(type);
                }
            }

            return allTypeMapping;
        }
    }
}
