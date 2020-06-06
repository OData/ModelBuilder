// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder.Vocabularies.Capabilities;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Represents an <see cref="IEdmEntitySet"/> that can be built using <see cref="ODataModelBuilder"/>.
    /// <typeparam name="TEntityType">The element type of the entity set.</typeparam>
    /// </summary>
    public class EntitySetConfiguration<TEntityType> : NavigationSourceConfiguration<TEntityType>
        where TEntityType : class
    {
        internal EntitySetConfiguration(ODataModelBuilder modelBuilder, string name)
            : base(modelBuilder, new EntitySetConfiguration(modelBuilder, typeof(TEntityType), name))
        {
        }

        internal EntitySetConfiguration(ODataModelBuilder modelBuilder, EntitySetConfiguration configuration)
            : base(modelBuilder, configuration)
        {
        }

        internal EntitySetConfiguration EntitySet
        {
            get { return (EntitySetConfiguration)Configuration; }
        }

        /// <summary>
        /// Configures the insert restrictions for this navigation source.
        /// </summary>
        /// <param name="insertRestrictions">The insert restrictions to configure.</param>
        /// <returns></returns>
        public NavigationSourceConfiguration<TEntityType> AddInsertRestrictions(InsertRestrictionsType insertRestrictions)
        {
            EntitySet.InsertRestrictions = insertRestrictions;
            return this;
        }

        /// <summary>
        /// Configures the update restrictions for this navigation source.
        /// </summary>
        /// <param name="updateRestrictions">The update restrictions to configure.</param>
        /// <returns></returns>
        public NavigationSourceConfiguration<TEntityType> AddUpdateRestrictions(UpdateRestrictionsType updateRestrictions)
        {
            EntitySet.UpdateRestrictions = updateRestrictions;
            return this;
        }

        /// <summary>
        /// Configures the delete restrictions for this navigation source.
        /// </summary>
        /// <param name="deleteRestrictions">The delete restrictions to configure.</param>
        /// <returns></returns>
        public NavigationSourceConfiguration<TEntityType> AddDeleteRestrictions(DeleteRestrictionsType deleteRestrictions)
        {
            EntitySet.DeleteRestrictions = deleteRestrictions;
            return this;
        }
    }
}
