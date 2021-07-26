// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// The <see cref="ActionConfiguration"/> represents an OData action that you wish to expose via your service.
    /// <remarks>
    /// The <see cref="ActionConfiguration"/> is exposed via $metadata as a <Action/> element for bound action and <ActionImport/> element for unbound action.
    /// </remarks> 
    /// </summary>
    public class ActionConfiguration : OperationConfiguration
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ActionConfiguration" /> class.
        /// </summary>
        /// <param name="builder">The ODataModelBuilder to which this ActionConfiguration should be added.</param>
        /// <param name="name">The name of this ActionConfiguration.</param>
        internal ActionConfiguration(ODataModelBuilder builder, string name)
            : base(builder, name)
        {
        }

        /// <inheritdoc />
        public override OperationKind Kind => OperationKind.Action;

        /// <inheritdoc />
        public override bool IsSideEffecting => true;

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <typeparam name="TEntityType">The type that is an EntityType</typeparam>
        /// <param name="entitySetName">The name of the entity set which contains the returned entity.</param>
        /// <returns>A <see cref="ActionConfiguration"/> object that can be used to further configure.</returns>
        public ActionConfiguration ReturnsFromEntitySet<TEntityType>(string entitySetName)
            where TEntityType : class
            => ReturnsFromEntitySet(typeof(TEntityType), entitySetName);

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <param name="entityType">The entity type.</param>
        /// <param name="entitySetName">The name of the entity set which contains the returned entity.</param>
        /// <returns>A <see cref="ActionConfiguration"/> object that can be used to further configure.</returns>
        public ActionConfiguration ReturnsFromEntitySet(Type entityType, string entitySetName)
        {
            if (entityType == null)
            {
                throw Error.ArgumentNull("entityType");
            }

            ReturnsFromEntitySetImplementation(entityType, entitySetName);
            return this;
        }

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <typeparam name="TEntityType">The type that is an EntityType</typeparam>
        /// <param name="entitySetConfiguration">The entity set which contains the returned entity.</param>
        public ActionConfiguration ReturnsFromEntitySet<TEntityType>(EntitySetConfiguration<TEntityType> entitySetConfiguration)
            where TEntityType : class
        {
            if (entitySetConfiguration == null)
            {
                throw Error.ArgumentNull("entitySetConfiguration");
            }

            NavigationSource = entitySetConfiguration.EntitySet;
            ReturnType = ModelBuilder.GetTypeConfigurationOrNull(typeof(TEntityType));
            return this;
        }

        /// <summary>
        /// Sets the return type to a collection of entities.
        /// </summary>
        /// <typeparam name="TElementEntityType">The entity type.</typeparam>
        /// <param name="entitySetName">The name of the entity set which contains the returned entities.</param>
        public ActionConfiguration ReturnsCollectionFromEntitySet<TElementEntityType>(string entitySetName)
            where TElementEntityType : class
            => ReturnsCollectionFromEntitySet(typeof(TElementEntityType), entitySetName);

        /// <summary>
        /// Sets the return type to a collection of entities.
        /// </summary>
        /// <param name="elementEntityType">The element entity type.</param>
        /// <param name="entitySetName">The name of the entity set which contains the returned entities.</param>
        public ActionConfiguration ReturnsCollectionFromEntitySet(Type elementEntityType, string entitySetName)
        {
            ReturnsCollectionFromEntitySetImplementation(elementEntityType, entitySetName);
            return this;
        }

        /// <summary>
        /// Sets the return type to a collection of entities.
        /// </summary>
        /// <typeparam name="TElementEntityType">The entity type.</typeparam>
        /// <param name="entitySetConfiguration">The entity set which contains the returned entities.</param>
        public ActionConfiguration ReturnsCollectionFromEntitySet<TElementEntityType>(
            EntitySetConfiguration<TElementEntityType> entitySetConfiguration)
            where TElementEntityType : class
        {
            if (entitySetConfiguration == null)
            {
                throw Error.ArgumentNull("entitySetConfiguration");
            }

            Type clrCollectionType = typeof(IEnumerable<TElementEntityType>);
            NavigationSource = entitySetConfiguration.EntitySet;
            IEdmTypeConfiguration elementType = ModelBuilder.GetTypeConfigurationOrNull(typeof(TElementEntityType));
            ReturnType = new CollectionTypeConfiguration(elementType, clrCollectionType);
            return this;
        }

        /// <summary>
        /// Established the return type of the Action.
        /// <remarks>Used when the return type is a single Primitive or ComplexType.</remarks>
        /// </summary>
        public ActionConfiguration Returns<TReturnType>()
            => Returns(typeof(TReturnType));

        /// <summary>
        /// Established the return type of the Action.
        /// <remarks>Used when the return type is a single Primitive or ComplexType.</remarks>
        /// </summary>
        public ActionConfiguration Returns(Type clrReturnType)
        {
            if (clrReturnType == null)
            {
                throw Error.ArgumentNull("clrReturnType");
            }

            IEdmTypeConfiguration configuration = ModelBuilder.GetTypeConfigurationOrNull(clrReturnType);

            if (configuration is EntityTypeConfiguration)
            {
                throw Error.InvalidOperation(SRResources.ReturnEntityWithoutEntitySet, configuration.FullName);
            }

            ReturnsImplementation(clrReturnType);
            return this;
        }

        /// <summary>
        /// Establishes the return type of the Action
        /// <remarks>Used when the return type is a collection of either Primitive or ComplexTypes.</remarks>
        /// </summary>
        public ActionConfiguration ReturnsCollection<TReturnElementType>()
            => ReturnsCollection(typeof(TReturnElementType));

        /// <summary>
        /// Establishes the return type of the Action
        /// <remarks>Used when the return type is a collection of either Primitive or ComplexTypes.</remarks>
        /// </summary>
        public ActionConfiguration ReturnsCollection(Type clrElementType)
        {
            if (clrElementType == null)
            {
                throw Error.ArgumentNull("clrElementType");
            }

            IEdmTypeConfiguration edmElementType = ModelBuilder.GetTypeConfigurationOrNull(clrElementType);
            if (edmElementType is EntityTypeConfiguration)
            {
                throw Error.InvalidOperation(SRResources.ReturnEntityCollectionWithoutEntitySet, edmElementType.FullName);
            }

            ReturnsCollectionImplementation(clrElementType);
            return this;
        }

        /// <summary>
        /// Specifies the bindingParameter name, type and whether it is alwaysBindable, use only if the Action "isBindable".
        /// </summary>
        public ActionConfiguration SetBindingParameter(string name, IEdmTypeConfiguration bindingParameterType)
        {
            SetBindingParameterImplementation(name, bindingParameterType);
            return this;
        }

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <typeparam name="TEntityType">The type that is an EntityType</typeparam>
        /// <param name="entitySetPath">The entitySetPath which contains the return EntityType instance</param>
        public ActionConfiguration ReturnsEntityViaEntitySetPath<TEntityType>(string entitySetPath) where TEntityType : class
            => ReturnsEntityViaEntitySetPath(typeof(TEntityType), entitySetPath);

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <param name="entityType">The entity type.</param>
        /// <param name="entitySetPath">The entitySetPath which contains the return EntityType instance.</param>
        public ActionConfiguration ReturnsEntityViaEntitySetPath(Type entityType, string entitySetPath)
        {
            if (entityType == null)
            {
                throw Error.ArgumentNull("entityType");
            }

            if (string.IsNullOrEmpty(entitySetPath))
            {
                throw Error.ArgumentNull("entitySetPath");
            }

            ReturnsEntityViaEntitySetPathImplementation(entityType, entitySetPath.Split('/'));
            return this;
        }

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <typeparam name="TEntityType">The type that is an EntityType</typeparam>
        /// <param name="entitySetPath">The entitySetPath which contains the return EntityType instance</param>
        public ActionConfiguration ReturnsEntityViaEntitySetPath<TEntityType>(params string[] entitySetPath)
            where TEntityType : class
        {
            ReturnsEntityViaEntitySetPathImplementation(typeof(TEntityType), entitySetPath);
            return this;
        }

        /// <summary>
        /// Sets the return type to a collection of EntityType instances.
        /// </summary>
        /// <typeparam name="TElementEntityType">The type that is an EntityType.</typeparam>
        /// <param name="entitySetPath">The entitySetPath which contains the returned EntityType instances.</param>
        public ActionConfiguration ReturnsCollectionViaEntitySetPath<TElementEntityType>(string entitySetPath)
            where TElementEntityType : class
            => ReturnsCollectionViaEntitySetPath(typeof(TElementEntityType), entitySetPath);

        /// <summary>
        /// Sets the return type to a collection of EntityType instances.
        /// </summary>
        /// <param name="clrElementEntityType">The element entity type.</param>
        /// <param name="entitySetPath">The entitySetPath which contains the returned EntityType instances.</param>
        public ActionConfiguration ReturnsCollectionViaEntitySetPath(Type clrElementEntityType, string entitySetPath)
        {
            if (clrElementEntityType == null)
            {
                throw Error.ArgumentNull("clrElementEntityType");
            }

            if (string.IsNullOrEmpty(entitySetPath))
            {
                throw Error.ArgumentNull("entitySetPath");
            }

            ReturnsCollectionViaEntitySetPathImplementation(clrElementEntityType, entitySetPath.Split('/'));
            return this;
        }

        /// <summary>
        /// Sets the return type to a collection of EntityType instances.
        /// </summary>
        /// <typeparam name="TElementEntityType">The type that is an EntityType.</typeparam>
        /// <param name="entitySetPath">The entitySetPath which contains the returned EntityType instances.</param>
        public ActionConfiguration ReturnsCollectionViaEntitySetPath<TElementEntityType>(params string[] entitySetPath)
            where TElementEntityType : class
        {
            ReturnsCollectionViaEntitySetPathImplementation(typeof(TElementEntityType), entitySetPath);
            return this;
        }
    }
}
