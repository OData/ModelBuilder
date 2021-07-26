// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// The <see cref="FunctionConfiguration"/> represents an OData function that you wish to expose via your service.
    /// <remarks>
    /// The <see cref="FunctionConfiguration"/> is exposed via $metadata as a <Function/> element for bound function and <FunctionImport/> element for unbound function.
    /// </remarks>
    /// </summary>
    public class FunctionConfiguration : OperationConfiguration
    {
        /// <summary>
        /// Initializes a new instance of <see cref="FunctionConfiguration" /> class.
        /// </summary>
        /// <param name="builder">The ODataModelBuilder to which this FunctionConfiguration should be added.</param>
        /// <param name="name">The name of this FunctionConfiguration.</param>
        internal FunctionConfiguration(ODataModelBuilder builder, string name) : base(builder, name)
        {
            // By default, function import is included in service document
            IncludeInServiceDocument = true;
        }

        /// <inheritdoc />
        public override OperationKind Kind => OperationKind.Function;

        /// <inheritdoc />
        public override bool IsSideEffecting => false;

        /// <summary>
        /// Can the function be composed upon.
        /// 
        /// For example can a URL that invokes the operation be used as the base URL for 
        /// a request that invokes the operation and does something else with the results
        /// </summary>
        public bool IsComposable { get; set; }

        /// <summary>
        /// Gets/Sets a value indicating whether the function is supported in $filter.
        /// </summary>
        public bool SupportedInFilter { get; set; }

        /// <summary>
        /// Gets/Sets a value indicating whether the function is supported in $orderby.
        /// </summary>
        public bool SupportedInOrderBy { get; set; }

        /// <summary>
        /// Gets/Set a value indicating whether the operation is included in service document or not.
        /// Meaningful only for function imports; ignore for bound functions.
        /// </summary>
        public bool IncludeInServiceDocument { get; set; }

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <typeparam name="TEntityType">The type that is an EntityType</typeparam>
        /// <param name="entitySetName">The entitySetName which contains the return EntityType instance.</param>
        /// <returns>A <see cref="FunctionConfiguration"/> object that can be used to further configure.</returns>
        public FunctionConfiguration ReturnsFromEntitySet<TEntityType>(string entitySetName)
            where TEntityType : class
            => ReturnsFromEntitySet(typeof(TEntityType), entitySetName);

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <param name="entityType">The entity type.</param>
        /// <param name="entitySetName">The entitySetName which contains the return EntityType instance.</param>
        /// <returns>A <see cref="FunctionConfiguration"/> object that can be used to further configure.</returns>
        public FunctionConfiguration ReturnsFromEntitySet(Type entityType, string entitySetName)
        {
            if (entityType == null)
            {
                throw Error.ArgumentNull("entityType");
            }

            ReturnsFromEntitySetImplementation(entityType, entitySetName);
            return this;
        }

        /// <summary>
        /// Sets the return type to a collection of EntityType instances.
        /// </summary>
        /// <typeparam name="TElementEntityType">The type that is an EntityType.</typeparam>
        /// <param name="entitySetName">The entitySetName which contains the returned EntityType instances.</param>
        public FunctionConfiguration ReturnsCollectionFromEntitySet<TElementEntityType>(string entitySetName)
            where TElementEntityType : class
            => ReturnsCollectionFromEntitySet(typeof(TElementEntityType), entitySetName);

        /// <summary>
        /// Sets the return type to a collection of EntityType instances.
        /// </summary>
        /// <param name="elementEntityType">The element entity type.</param>
        /// <param name="entitySetName">The entitySetName which contains the returned EntityType instances.</param>
        public FunctionConfiguration ReturnsCollectionFromEntitySet(Type elementEntityType, string entitySetName)
        {
            ReturnsCollectionFromEntitySetImplementation(elementEntityType, entitySetName);
            return this;
        }

        /// <summary>
        /// Established the return type of the Function.
        /// <remarks>Used when the return type is a single Primitive or ComplexType.</remarks>
        /// </summary>
        public FunctionConfiguration Returns<TReturnType>()
            => Returns(typeof(TReturnType));

        /// <summary>
        /// Established the return type of the Function.
        /// <remarks>Used when the return type is a single Primitive or ComplexType.</remarks>
        /// </summary>
        public FunctionConfiguration Returns(Type clrReturnType)
        {
            if (clrReturnType == null)
            {
                throw Error.ArgumentNull("clrReturnType");
            }

            ReturnsImplementation(clrReturnType);
            return this;
        }

        /// <summary>
        /// Establishes the return type of the Function
        /// <remarks>Used when the return type is a collection of either Primitive or ComplexTypes.</remarks>
        /// </summary>
        public FunctionConfiguration ReturnsCollection<TReturnElementType>()
            => ReturnsCollection(typeof(TReturnElementType));

        /// <summary>
        /// Establishes the return type of the Function
        /// <remarks>Used when the return type is a collection of either Primitive or ComplexTypes.</remarks>
        /// </summary>
        public FunctionConfiguration ReturnsCollection(Type clrElementType)
        {
            if (clrElementType == null)
            {
                throw Error.ArgumentNull("clrElementType");
            }

            ReturnsCollectionImplementation(clrElementType);
            return this;
        }

        /// <summary>
        /// Specifies the bindingParameter name, type and whether it is alwaysBindable, use only if the Function "isBindable".
        /// </summary>
        public FunctionConfiguration SetBindingParameter(string name, IEdmTypeConfiguration bindingParameterType)
        {
            SetBindingParameterImplementation(name, bindingParameterType);
            return this;
        }

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <typeparam name="TEntityType">The type that is an EntityType.</typeparam>
        /// <param name="entitySetPath">The entitySetPath which contains the return EntityType instance.</param>
        public FunctionConfiguration ReturnsEntityViaEntitySetPath<TEntityType>(string entitySetPath) where TEntityType : class
            => ReturnsEntityViaEntitySetPath(typeof(TEntityType), entitySetPath);

        /// <summary>
        /// Sets the return type to a single EntityType instance.
        /// </summary>
        /// <param name="entityType">The entity type.</param>
        /// <param name="entitySetPath">The entitySetPath which contains the return EntityType instance.</param>
        public FunctionConfiguration ReturnsEntityViaEntitySetPath(Type entityType, string entitySetPath)
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
        /// <typeparam name="TEntityType">The type that is an EntityType.</typeparam>
        /// <param name="entitySetPath">The entitySetPath which contains the return EntityType instance.</param>
        public FunctionConfiguration ReturnsEntityViaEntitySetPath<TEntityType>(params string[] entitySetPath)
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
        public FunctionConfiguration ReturnsCollectionViaEntitySetPath<TElementEntityType>(string entitySetPath)
            where TElementEntityType : class
            => ReturnsCollectionViaEntitySetPath(typeof(TElementEntityType), entitySetPath);

        /// <summary>
        /// Sets the return type to a collection of EntityType instances.
        /// </summary>
        /// <param name="clrElementEntityType">The element entity type.</param>
        /// <param name="entitySetPath">The entitySetPath which contains the returned EntityType instances.</param>
        public FunctionConfiguration ReturnsCollectionViaEntitySetPath(Type clrElementEntityType, string entitySetPath)
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
        public FunctionConfiguration ReturnsCollectionViaEntitySetPath<TElementEntityType>(params string[] entitySetPath)
            where TElementEntityType : class
        {
            ReturnsCollectionViaEntitySetPathImplementation(typeof(TElementEntityType), entitySetPath);
            return this;
        }
    }
}
