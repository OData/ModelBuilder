﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder.Helpers;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// <see cref="ODataModelBuilder"/> is used to map CLR classes to an EDM model.
    /// </summary>
    public class ODataModelBuilder
    {
        private const string DefaultNamespace = "Default";

        private static readonly Version _defaultDataServiceVersion = EdmConstants.EdmVersion4;
        private static readonly Version _defaultMaxDataServiceVersion = EdmConstants.EdmVersion4;

        private Dictionary<Type, EnumTypeConfiguration> _enumTypes = new Dictionary<Type, EnumTypeConfiguration>();
        private Dictionary<Type, StructuralTypeConfiguration> _structuralTypes = new Dictionary<Type, StructuralTypeConfiguration>();
        private Dictionary<string, NavigationSourceConfiguration> _navigationSources = new Dictionary<string, NavigationSourceConfiguration>();
        private Dictionary<Type, PrimitiveTypeConfiguration> _primitiveTypes = new Dictionary<Type, PrimitiveTypeConfiguration>();
        private List<OperationConfiguration> _operations = new List<OperationConfiguration>();

        private Version _dataServiceVersion;
        private Version _maxDataServiceVersion;
        private string _namespace;

        /// <summary>
        /// Initializes a new instance of the <see cref="ODataModelBuilder"/> class.
        /// </summary>
        public ODataModelBuilder()
        {
            _namespace = DefaultNamespace;
            ContainerName = "Container";
            DataServiceVersion = _defaultDataServiceVersion;
            MaxDataServiceVersion = _defaultMaxDataServiceVersion;
            BindingOptions = NavigationPropertyBindingOption.None;
            HasAssignedNamespace = false;
        }

        /// <summary>
        /// Gets or sets the namespace that will be used for the resulting model
        /// </summary>
        public string Namespace
        {
            get
            {
                return _namespace;
            }
            set
            {
                // If user chooses to set the namespace to null, we revert back to 'Default' namespace.
                if (String.IsNullOrEmpty(value))
                {
                    this.HasAssignedNamespace = false;
                    _namespace = DefaultNamespace;
                }
                else
                {
                    this.HasAssignedNamespace = true;
                    _namespace = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the navigation property binding options.
        /// </summary>
        public NavigationPropertyBindingOption BindingOptions { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the <see cref="Namespace"/> was auto assigned or is using a value assigned by user.
        /// </summary>
        /// <value>
        ///   <c>true</c> if the <see cref="Namespace"/> is using user assigned value; otherwise, <c>false</c>.
        /// </value>
        internal bool HasAssignedNamespace { get; private set; }

        /// <summary>
        /// Gets or sets the name of the container that will hold all the navigation sources, actions and functions
        /// </summary>
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets the data service version of the model. The default value is 4.0.
        /// </summary>
        public Version DataServiceVersion
        {
            get
            {
                return _dataServiceVersion;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _dataServiceVersion = value;
            }
        }

        /// <summary>
        /// Gets or sets the maximum data service version of the model. The default value is 4.0.
        /// </summary>
        public Version MaxDataServiceVersion
        {
            get
            {
                return _maxDataServiceVersion;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }

                _maxDataServiceVersion = value;
            }
        }

        /// <summary>
        /// Gets the collection of EDM entity sets in the model to be built.
        /// </summary>
        public virtual IEnumerable<EntitySetConfiguration> EntitySets
        {
            get { return _navigationSources.Values.OfType<EntitySetConfiguration>(); }
        }

        /// <summary>
        /// Gets the collection of EDM singletons in the model to be built.
        /// </summary>
        public virtual IEnumerable<SingletonConfiguration> Singletons
        {
            get { return _navigationSources.Values.OfType<SingletonConfiguration>(); }
        }

        /// <summary>
        /// Gets the collection of EDM navigation sources (entity sets and singletons) in the model to be built.
        /// </summary>
        public virtual IEnumerable<NavigationSourceConfiguration> NavigationSources
        {
            get { return _navigationSources.Values; }
        }

        /// <summary>
        /// Gets the collection of EDM types in the model to be built.
        /// </summary>
        public virtual IEnumerable<StructuralTypeConfiguration> StructuralTypes
        {
            get { return _structuralTypes.Values; }
        }

        /// <summary>
        /// Gets the collection of EDM types in the model to be built.
        /// </summary>
        public virtual IEnumerable<EnumTypeConfiguration> EnumTypes
        {
            get { return _enumTypes.Values; }
        }

        /// <summary>
        /// Gets the collection of Operations (i.e. Actions, Functions) in the model to be built.
        /// </summary>
        public virtual IEnumerable<OperationConfiguration> Operations
        {
            get { return _operations; }
        }

        /// <summary>
        /// Registers an entity type as part of the model and returns an object that can be used to configure the entity type.
        /// This method can be called multiple times for the same entity to perform multiple lines of configuration.
        /// </summary>
        /// <typeparam name="TEntityType">The type to be registered or configured.</typeparam>
        /// <returns>The configuration object for the specified entity type.</returns>
        public EntityTypeConfiguration<TEntityType> EntityType<TEntityType>() where TEntityType : class
        {
            return new EntityTypeConfiguration<TEntityType>(this, AddEntityType(typeof(TEntityType)));
        }

        /// <summary>
        /// Registers a type as a complex type in the model and returns an object that can be used to configure the complex type.
        /// This method can be called multiple times for the same type to perform multiple lines of configuration.
        /// </summary>
        /// <typeparam name="TComplexType">The type to be registered or configured.</typeparam>
        /// <returns>The configuration object for the specified complex type.</returns>
        public ComplexTypeConfiguration<TComplexType> ComplexType<TComplexType>() where TComplexType : class
        {
            return new ComplexTypeConfiguration<TComplexType>(this, AddComplexType(typeof(TComplexType)));
        }

        /// <summary>
        /// Registers an enum type as part of the model and returns an object that can be used to configure the enum.
        /// </summary>
        /// <typeparam name="TEnumType">The enum type to be registered or configured.</typeparam>
        /// <returns>The configuration object for the specified enum type.</returns>
        public EnumTypeConfiguration<TEnumType> EnumType<TEnumType>()
        {
            return new EnumTypeConfiguration<TEnumType>(AddEnumType(typeof(TEnumType)));
        }

        /// <summary>
        /// Registers an entity set as a part of the model and returns an object that can be used to configure the entity set.
        /// This method can be called multiple times for the same type to perform multiple lines of configuration.
        /// </summary>
        /// <typeparam name="TEntityType">The entity type of the entity set.</typeparam>
        /// <param name="name">The name of the entity set.</param>
        /// <returns>The configuration object for the specified entity set.</returns>
        public EntitySetConfiguration<TEntityType> EntitySet<TEntityType>(string name) where TEntityType : class
        {
            EntityTypeConfiguration entity = AddEntityType(typeof(TEntityType));
            return new EntitySetConfiguration<TEntityType>(this, AddEntitySet(name, entity));
        }

        /// <summary>
        /// Registers a singleton as a part of the model and returns an object that can be used to configure the singleton.
        /// This method can be called multiple times for the same type to perform multiple lines of configuration.
        /// </summary>
        /// <typeparam name="TEntityType">The entity type of the singleton.</typeparam>
        /// <param name="name">The name of the singleton.</param>
        /// <returns>The configuration object for the specified singleton.</returns>
        public SingletonConfiguration<TEntityType> Singleton<TEntityType>(string name) where TEntityType : class
        {
            EntityTypeConfiguration entity = AddEntityType(typeof(TEntityType));
            return new SingletonConfiguration<TEntityType>(this, AddSingleton(name, entity));
        }

        /// <summary>
        /// Adds an unbound action to the builder.
        /// </summary>
        /// <param name="name">The name of the action.</param>
        /// <returns>The configuration object for the specified action.</returns>
        public virtual ActionConfiguration Action(string name)
        {
            ActionConfiguration action = new ActionConfiguration(this, name);
            _operations.Add(action);
            return action;
        }

        /// <summary>
        /// Adds an unbound function to the builder.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <returns>The configuration object for the specified function.</returns>
        [SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", Justification = "Consistent with term in EdmLib.")]
        public virtual FunctionConfiguration Function(string name)
        {
            FunctionConfiguration function = new FunctionConfiguration(this, name);
            _operations.Add(function);
            return function;
        }

        /// <summary>
        /// Registers an entity type as part of the model and returns an object that can be used to configure the entity.
        /// This method can be called multiple times for the same entity to perform multiple lines of configuration.
        /// </summary>
        /// <param name="clrType">The type to be registered or configured.</param>
        /// <returns>The configuration object for the specified entity type.</returns>
        public virtual EntityTypeConfiguration AddEntityType(Type clrType)
        {
            if (clrType == null)
            {
                throw new ArgumentNullException(nameof(clrType));
            }

            if (!_structuralTypes.ContainsKey(clrType))
            {
                EntityTypeConfiguration entityTypeConfig = new EntityTypeConfiguration(this, clrType);
                _structuralTypes.Add(clrType, entityTypeConfig);
                return entityTypeConfig;
            }
            else
            {
                EntityTypeConfiguration config = _structuralTypes[clrType] as EntityTypeConfiguration;
                if (config == null || config.ClrType != clrType)
                {
                    throw Error.Argument("type", SRResources.TypeCannotBeEntityWasComplex, clrType.FullName);
                }

                return config;
            }
        }

        /// <summary>
        /// Registers an complex type as part of the model and returns an object that can be used to configure the entity.
        /// This method can be called multiple times for the same entity to perform multiple lines of configuration.
        /// </summary>
        /// <param name="clrType">The type to be registered or configured.</param>
        /// <returns>The configuration object for the specified complex type.</returns>
        public virtual ComplexTypeConfiguration AddComplexType(Type clrType)
        {
            if (clrType == null)
            {
                throw new ArgumentNullException(nameof(clrType));
            }

            if (!_structuralTypes.ContainsKey(clrType))
            {
                ComplexTypeConfiguration complexTypeConfig = new ComplexTypeConfiguration(this, clrType);
                _structuralTypes.Add(clrType, complexTypeConfig);
                return complexTypeConfig;
            }
            else
            {
                ComplexTypeConfiguration complexTypeConfig = _structuralTypes[clrType] as ComplexTypeConfiguration;
                if (complexTypeConfig == null || complexTypeConfig.ClrType != clrType)
                {
                    throw Error.Argument("type", SRResources.TypeCannotBeComplexWasEntity, clrType.FullName);
                }

                return complexTypeConfig;
            }
        }

        /// <summary>
        /// Registers an enum type as part of the model and returns an object that can be used to configure the enum type.
        /// </summary>
        /// <param name="clrType">The type to be registered or configured.</param>
        /// <returns>The configuration object for the specified enum type.</returns>
        public virtual EnumTypeConfiguration AddEnumType(Type clrType)
        {
            if (clrType == null)
            {
                throw new ArgumentNullException(nameof(clrType));
            }

            if (!TypeHelper.IsEnum(clrType))
            {
                throw Error.Argument("type", SRResources.TypeCannotBeEnum, clrType.FullName);
            }

            if (!_enumTypes.ContainsKey(clrType))
            {
                EnumTypeConfiguration enumTypeConfig = new EnumTypeConfiguration(this, clrType);
                _enumTypes.Add(clrType, enumTypeConfig);
                return enumTypeConfig;
            }
            else
            {
                EnumTypeConfiguration enumTypeConfig = _enumTypes[clrType];
                if (enumTypeConfig.ClrType != clrType)
                {
                    throw Error.Argument("type", SRResources.TypeCannotBeEnum, clrType.FullName);
                }

                return enumTypeConfig;
            }
        }

        /// <summary>
        /// Adds an operation to the model.
        /// </summary>
        public virtual void AddOperation(OperationConfiguration operation)
        {
            _operations.Add(operation);
        }


        /// <summary>
        /// Registers an entity set as a part of the model and returns an object that can be used to configure the entity set.
        /// This method can be called multiple times for the same type to perform multiple lines of configuration.
        /// </summary>
        /// <param name="name">The name of the entity set.</param>
        /// <param name="entityType">The type to be registered or configured.</param>
        /// <returns>The configuration object for the specified entity set.</returns>
        [SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = "<Pending>")]
        public virtual EntitySetConfiguration AddEntitySet(string name, EntityTypeConfiguration entityType)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw Error.ArgumentNullOrEmpty("name");
            }

            if (entityType == null)
            {
                throw Error.ArgumentNull("entityType");
            }

            if (name.Contains('.'))
            {
                throw Error.NotSupported(SRResources.InvalidEntitySetName, name);
            }

            EntitySetConfiguration entitySet = null;
            if (_navigationSources.ContainsKey(name))
            {
                entitySet = _navigationSources[name] as EntitySetConfiguration;
                if (entitySet == null)
                {
                    throw Error.Argument("name", SRResources.EntitySetNameAlreadyConfiguredAsSingleton, name);
                }

                if (entitySet.EntityType != entityType)
                {
                    throw Error.Argument("entityType", SRResources.EntitySetAlreadyConfiguredDifferentEntityType,
                        entitySet.Name, entitySet.EntityType.Name);
                }
            }
            else
            {
                entitySet = new EntitySetConfiguration(this, entityType, name);
                _navigationSources[name] = entitySet;
            }

            return entitySet;
        }


        /// <summary>
        /// Registers a singleton as a part of the model and returns an object that can be used to configure the singleton.
        /// This method can be called multiple times for the same type to perform multiple lines of configuration.
        /// </summary>
        /// <param name="name">The name of the singleton.</param>
        /// <param name="entityType">The type to be registered or configured.</param>
        /// <returns>The configuration object for the specified singleton.</returns>
        [SuppressMessage("Globalization", "CA1307:Specify StringComparison", Justification = "<Pending>")]
        public virtual SingletonConfiguration AddSingleton(string name, EntityTypeConfiguration entityType)
        {
            if (String.IsNullOrWhiteSpace(name))
            {
                throw Error.ArgumentNullOrEmpty("name");
            }

            if (entityType == null)
            {
                throw new ArgumentNullException(nameof(entityType));
            }

            if (name.Contains('.'))
            {
                throw Error.NotSupported(SRResources.InvalidSingletonName, name);
            }

            SingletonConfiguration singleton;
            if (_navigationSources.ContainsKey(name))
            {
                singleton = _navigationSources[name] as SingletonConfiguration;
                if (singleton == null)
                {
                    throw Error.Argument("name", SRResources.SingletonNameAlreadyConfiguredAsEntitySet, name);
                }

                if (singleton.EntityType != entityType)
                {
                    throw Error.Argument("entityType", SRResources.SingletonAlreadyConfiguredDifferentEntityType,
                        singleton.Name, singleton.EntityType.Name);
                }
            }
            else
            {
                singleton = new SingletonConfiguration(this, entityType, name);
                _navigationSources[name] = singleton;
            }

            return singleton;
        }

        /// <summary>
        /// Removes the type from the model.
        /// </summary>
        /// <param name="clrType">The type to be removed.</param>
        /// <returns><c>true</c> if the type is present in the model and <c>false</c> otherwise.</returns>
        public virtual bool RemoveStructuralType(Type clrType)
        {
            if (clrType == null)
            {
                throw new ArgumentNullException(nameof(clrType));
            }

            return _structuralTypes.Remove(clrType);
        }

        /// <summary>
        /// Removes the type from the model.
        /// </summary>
        /// <param name="clrType">The type to be removed.</param>
        /// <returns><c>true</c> if the type is present in the model and <c>false</c> otherwise.</returns>
        public virtual bool RemoveEnumType(Type clrType)
        {
            if (clrType == null)
            {
                throw new ArgumentNullException(nameof(clrType));
            }

            return _enumTypes.Remove(clrType);
        }

        /// <summary>
        /// Removes the entity set from the model.
        /// </summary>
        /// <param name="name">The name of the entity set to be removed.</param>
        /// <returns><c>true</c> if the entity set is present in the model and <c>false</c> otherwise.</returns>
        public virtual bool RemoveEntitySet(string name)
        {
            if (_navigationSources.ContainsKey(name))
            {
                EntitySetConfiguration entitySet = _navigationSources[name] as EntitySetConfiguration;
                if (entitySet != null)
                {
                    return _navigationSources.Remove(name);
                }
            }

            return false;
        }

        /// <summary>
        /// Removes the singleton from the model.
        /// </summary>
        /// <param name="name">The name of the singleton to be removed.</param>
        /// <returns><c>true</c> if the singleton is present in the model and <c>false</c> otherwise.</returns>
        public virtual bool RemoveSingleton(string name)
        {
            if (_navigationSources.ContainsKey(name))
            {
                SingletonConfiguration singleton = _navigationSources[name] as SingletonConfiguration;
                if (singleton != null)
                {
                    return _navigationSources.Remove(name);
                }
            }

            return false;
        }

        /// <summary>
        /// Remove the operation from the model
        /// <remarks>
        /// If there is more than one operation with the name specified this method will not work.
        /// You need to use the other RemoveOperation(..) overload instead.
        /// </remarks>
        /// </summary>
        /// <param name="name">The name of the operation to be removed.</param>
        /// <returns><c>true</c> if the operation is present in the model and <c>false</c> otherwise.</returns>
        public virtual bool RemoveOperation(string name)
        {
            OperationConfiguration[] toRemove = _operations.Where(p => p.Name == name).ToArray();
            int count = toRemove.Length;
            if (count == 1)
            {
                return RemoveOperation(toRemove[0]);
            }
            else if (count == 0)
            {
                // For consistency with RemoveStructuralType().
                // uses same semantics as Dictionary.Remove(key).
                return false;
            }
            else
            {
                throw Error.InvalidOperation(SRResources.MoreThanOneOperationFound, name);
            }
        }

        /// <summary>
        /// Remove the operation from the model
        /// </summary>
        /// <param name="operation">The operation to be removed.</param>
        /// <returns><c>true</c> if the operation is present in the model and <c>false</c> otherwise.</returns>
        public virtual bool RemoveOperation(OperationConfiguration operation)
        {
            if (operation == null)
            {
                throw Error.ArgumentNull("operation");
            }
            return _operations.Remove(operation);
        }

        /// <summary>
        /// Attempts to find a pre-configured structural type or a primitive type or an enum type that matches the T.
        /// If no matches are found NULL is returned.
        /// </summary>
        public IEdmTypeConfiguration GetTypeConfigurationOrNull(Type type)
        {
            if (_primitiveTypes.ContainsKey(type))
            {
                return _primitiveTypes[type];
            }
            else
            {
                IEdmPrimitiveType edmType = EdmLibHelpers.GetEdmPrimitiveTypeOrNull(type);
                PrimitiveTypeConfiguration primitiveType = null;
                if (edmType != null)
                {
                    primitiveType = new PrimitiveTypeConfiguration(this, edmType, type);
                    _primitiveTypes[type] = primitiveType;
                    return primitiveType;
                }
                else if (_structuralTypes.ContainsKey(type))
                {
                    return _structuralTypes[type];
                }
                else if (_enumTypes.ContainsKey(type))
                {
                    return _enumTypes[type];
                }
            }

            return null;
        }

        /// <summary>
        /// Creates a <see cref="IEdmModel"/> based on the configuration performed using this builder.
        /// </summary>
        /// <returns>The model that was built.</returns>
        [SuppressMessage("Microsoft.Design", "CA1024:UsePropertiesWhereAppropriate", Justification = "Property is not appropriate, method does work")]
        public virtual IEdmModel GetEdmModel()
        {
            IEdmModel model = EdmModelHelperMethods.BuildEdmModel(this);
            ValidateModel(model);
            return model;
        }

        /// <summary>
        /// Validates the <see cref="IEdmModel"/> that is being created.
        /// </summary>
        /// <param name="model">The <see cref="IEdmModel"/> that will be validated.</param>
        public virtual void ValidateModel(IEdmModel model)
        {
            if (model == null)
            {
                throw Error.ArgumentNull("model");
            }

            // The type of entity set should have key(s) defined.
            foreach (IEdmEntitySet entitySet in model.EntityContainer.Elements.OfType<IEdmEntitySet>())
            {
                if (!entitySet.EntityType.Key().Any())
                {
                    throw Error.InvalidOperation(SRResources.EntitySetTypeHasNoKeys, entitySet.Name,
                        entitySet.EntityType.FullName());
                }
            }

            // The type of collection navigation property should have key(s) defined.
            foreach (IEdmStructuredType structuredType in model.SchemaElementsAcrossModels().OfType<IEdmStructuredType>())
            {
                foreach (var navigationProperty in structuredType.DeclaredNavigationProperties())
                {
                    if (navigationProperty.TargetMultiplicity() == EdmMultiplicity.Many)
                    {
                        IEdmEntityType entityType = navigationProperty.ToEntityType();
                        if (!entityType.Key().Any())
                        {
                            throw Error.InvalidOperation(SRResources.CollectionNavigationPropertyEntityTypeDoesntHaveKeyDefined, entityType.FullTypeName(), navigationProperty.Name, structuredType.FullTypeName());
                        }
                    }
                }
            }
        }
    }
}
