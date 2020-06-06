﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.ModelBuilder.Vocabularies.Capabilities;
using System;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Allows configuration to be performed for an entity set in a model.
    /// A <see cref="EntitySetConfiguration"/> can be obtained by using the method <see cref="ODataModelBuilder.EntitySet"/>.
    /// </summary>
    public class EntitySetConfiguration : NavigationSourceConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySetConfiguration"/> class.
        /// The default constructor is intended for use by unit testing only.
        /// </summary>
        public EntitySetConfiguration()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySetConfiguration"/> class.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ODataModelBuilder"/>.</param>
        /// <param name="entityClrType">The <see cref="Type"/> of the entity type contained in this entity set.</param>
        /// <param name="name">The name of the entity set.</param>
        public EntitySetConfiguration(ODataModelBuilder modelBuilder, Type entityClrType, string name)
            : base(modelBuilder, entityClrType, name)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySetConfiguration"/> class.
        /// </summary>
        /// <param name="modelBuilder">The <see cref="ODataModelBuilder"/>.</param>
        /// <param name="entityType">The entity type <see cref="EntityTypeConfiguration"/> contained in this entity set.</param>
        /// <param name="name">The name of the entity set.</param>
        public EntitySetConfiguration(ODataModelBuilder modelBuilder, EntityTypeConfiguration entityType, string name)
            : base(modelBuilder, entityType, name)
        {
        }

        /// <summary>
        /// Restrictions on insert operations.
        /// </summary>
        public InsertRestrictionsType InsertRestrictions { get; set; }

        /// <summary>
        /// Restrictions on update operations.
        /// </summary>
        public UpdateRestrictionsType UpdateRestrictions { get; set; }

        /// <summary>
        /// Restrictions on delete operations.
        /// </summary>
        public DeleteRestrictionsType DeleteRestrictions { get; set; }
    }
}
