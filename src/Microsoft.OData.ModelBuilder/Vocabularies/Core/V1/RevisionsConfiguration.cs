// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.
// <auto-generated />

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

namespace Microsoft.OData.ModelBuilder.Core.V1
{
    /// <summary>
    /// List of revisions of a model element
    /// </summary>
    public partial class RevisionsConfiguration : VocabularyTermConfiguration
    {
        private readonly HashSet<RevisionTypeConfiguration> _revisions = new HashSet<RevisionTypeConfiguration>();

        /// <inheritdoc/>
        public override string TermName => "Org.OData.Core.V1.Revisions";

        /// <summary>
        /// List of revisions of a model element
        /// </summary>
        /// <param name="revisionsConfiguration">The configuration to set</param>
        /// <returns><see cref="RevisionsConfiguration"/></returns>
        public RevisionsConfiguration HasRevisions(Func<RevisionTypeConfiguration, RevisionTypeConfiguration> revisionsConfiguration)
        {
            var instance = new RevisionTypeConfiguration();
            instance = revisionsConfiguration?.Invoke(instance);
            return HasRevisions(instance);
        }

        /// <summary>
        /// List of revisions of a model element
        /// </summary>
        /// <param name="revisions">The value(s) to set</param>
        /// <returns><see cref="RevisionsConfiguration"/></returns>
        public RevisionsConfiguration HasRevisions(params RevisionTypeConfiguration[] revisions)
        {
            _revisions.UnionWith(revisions);
            return this;
        }

        /// <inheritdoc/>
        public override IEdmExpression ToEdmExpression()
        {
            if (!_revisions.Any())
            {
                return null;
            }

            var records = _revisions.Select(item => item.ToEdmExpression());
            return new EdmCollectionExpression(records);
        }
    }
}
