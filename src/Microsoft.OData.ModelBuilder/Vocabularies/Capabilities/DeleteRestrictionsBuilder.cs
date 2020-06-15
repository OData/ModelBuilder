using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Allows building restrictions on delete operations;
    /// </summary>
    public class DeleteRestrictionsBuilder : VocabularyBuilder<DeleteRestrictionsType>
    {
        /// <summary>
        /// Initializes a new <see cref="DeleteRestrictionsBuilder"/>
        /// </summary>
        public DeleteRestrictionsBuilder()
            : base("Org.OData.Capabilities.V1.DeleteRestrictions", new DeleteRestrictionsType())
        {
        }

        /// <summary>
        /// Entities can be deleted.
        /// </summary>
        /// <param name="deletable">Entities can be deleted.</param>
        /// <returns><see cref="DeleteRestrictionsBuilder" /></returns>
        public DeleteRestrictionsBuilder IsDeletable(bool deletable)
        {
            Data.Deletable = deletable;
            return this;
        }

        /// <summary>
        /// Required permissions. One of the specified sets of scopes is required to perform the delete.
        /// </summary>
        /// <param name="permissions">Required permissions. One of the specified sets of scopes is required to perform the delete.</param>
        /// <returns><see cref="DeleteRestrictionsBuilder" /></returns>
        public DeleteRestrictionsBuilder HasPermissions(IEnumerable<PermissionType> permissions)
        {
            Data.Permissions.AddRange(permissions);
            return this;
        }

        /// <summary>
        /// A brief description of the request.
        /// </summary>
        /// <param name="description">A brief description of the request.</param>
        /// <returns><see cref="DeleteRestrictionsBuilder" /></returns>
        public DeleteRestrictionsBuilder HasDescription(string description)
        {
            Data.Description = description;
            return this;
        }

        /// <summary>
        /// A lengthy description of the request
        /// </summary>
        /// <param name="longDescription">A lengthy description of the request.</param>
        /// <returns><see cref="DeleteRestrictionsBuilder" /></returns>
        public DeleteRestrictionsBuilder HasLongDescription(string longDescription)
        {
            Data.LongDescription = longDescription;
            return this;
        }
    }
}
