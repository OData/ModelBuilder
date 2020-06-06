// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Csdl;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder.Vocabularies.Capabilities;

namespace Microsoft.OData.ModelBuilder.Vocabularies
{
    /// <summary>
    /// Contains extension methods for <see cref="EdmModel"/> to set the query capabilities vocabulary.
    /// </summary>
    internal static class CapabilitiesVocabularyExtensionMethods
    {
        private static readonly IEnumerable<IEdmStructuralProperty> EmptyStructuralProperties = Enumerable.Empty<IEdmStructuralProperty>();
        private static readonly IEnumerable<IEdmNavigationProperty> EmptyNavigationProperties = Enumerable.Empty<IEdmNavigationProperty>();

        private static IEdmEnumType _navigationType;

        /// <summary>
        /// Set Org.OData.Capabilities.V1.CountRestrictions to target.
        /// </summary>
        /// <param name="model">The model referenced to.</param>
        /// <param name="target">The target entity set to set the inline annotation.</param>
        /// <param name="isCountable">This entity set can be counted.</param>
        /// <param name="nonCountableProperties">These collection properties do not allow /$count segments.</param>
        /// <param name="nonCountableNavigationProperties">These navigation properties do not allow /$count segments.</param>
        public static void SetCountRestrictionsAnnotation(this EdmModel model, IEdmEntitySet target, bool isCountable,
            IEnumerable<IEdmProperty> nonCountableProperties,
            IEnumerable<IEdmNavigationProperty> nonCountableNavigationProperties)
        {
            if (model == null)
            {
                throw Error.ArgumentNull("model");
            }

            if (target == null)
            {
                throw Error.ArgumentNull("target");
            }

            nonCountableProperties = nonCountableProperties ?? EmptyStructuralProperties;
            nonCountableNavigationProperties = nonCountableNavigationProperties ?? EmptyNavigationProperties;

            IList<IEdmPropertyConstructor> properties = new List<IEdmPropertyConstructor>
            {
                new EdmPropertyConstructor(Constants.CountRestrictions.Countable,
                    new EdmBooleanConstant(isCountable)),

                new EdmPropertyConstructor(Constants.CountRestrictions.NonCountableProperties,
                    new EdmCollectionExpression(
                        nonCountableProperties.Select(p => new EdmPropertyPathExpression(p.Name)).ToArray())),

                new EdmPropertyConstructor(Constants.CountRestrictions.NonCountableNavigationProperties,
                    new EdmCollectionExpression(
                        nonCountableNavigationProperties.Select(p => new EdmNavigationPropertyPathExpression(p.Name)).ToArray()))
            };

            model.SetVocabularyAnnotation(target, properties, Constants.CountRestrictions.Term);
        }

        /// <summary>
        /// Set Org.OData.Capabilities.V1.NavigationRestrictions to target.
        /// </summary>
        /// <param name="model">The model referenced to.</param>
        /// <param name="target">The target entity set to set the inline annotation.</param>
        /// <param name="navigability">This entity set supports navigability.</param>
        /// <param name="restrictedProperties">These properties have navigation restrictions on.</param>
        public static void SetNavigationRestrictionsAnnotation(this EdmModel model, IEdmEntitySet target,
            NavigationType navigability,
            IEnumerable<Tuple<IEdmNavigationProperty, NavigationType>> restrictedProperties)
        {
            if (model == null)
            {
                throw Error.ArgumentNull("model");
            }

            if (target == null)
            {
                throw Error.ArgumentNull("target");
            }

            IEdmEnumType navigationType = model.GetCapabilitiesNavigationType();
            if (navigationType == null)
            {
                return;
            }

            restrictedProperties = restrictedProperties ?? Array.Empty<Tuple<IEdmNavigationProperty, NavigationType>>();

            string type = new EdmEnumTypeReference(navigationType, false).ToStringLiteral((long)navigability);

            IEnumerable<EdmRecordExpression> propertiesExpression = restrictedProperties.Select(p =>
            {
                var name = new EdmEnumTypeReference(navigationType, false).ToStringLiteral((long)p.Item2);
                return new EdmRecordExpression(new IEdmPropertyConstructor[]
                {
                    new EdmPropertyConstructor(
                        Constants.NavigationPropertyRestriction.NavigationProperty,
                        new EdmNavigationPropertyPathExpression(p.Item1.Name)),
                    new EdmPropertyConstructor(Constants.NavigationRestrictions.Navigability,
                        new EdmEnumMemberExpression(navigationType.Members.Single(m => m.Name == name)))
                });
            });

            IList<IEdmPropertyConstructor> properties = new List<IEdmPropertyConstructor>
            {
                new EdmPropertyConstructor(Constants.NavigationRestrictions.Navigability,
                    new EdmEnumMemberExpression(navigationType.Members.Single(m => m.Name == type))),

                new EdmPropertyConstructor(Constants.NavigationRestrictions.RestrictedProperties,
                    new EdmCollectionExpression(propertiesExpression))
            };

            model.SetVocabularyAnnotation(target, properties, Constants.NavigationRestrictions.Term);
        }

        /// <summary>
        /// Set Org.OData.Capabilities.V1.FilterRestrictions to target.
        /// </summary>
        /// <param name="model">The model referenced to.</param>
        /// <param name="target">The target entity set to set the inline annotation.</param>
        /// <param name="isFilterable">This entity set supports the $filter expressions.</param>
        /// <param name="isRequiresFilter">This entity set requires $filter expressions.</param>
        /// <param name="requiredProperties">These properties must be specified in the $filter clause.</param>
        /// <param name="nonFilterableProperties">These properties cannot be used in $filter expressions.</param>
        public static void SetFilterRestrictionsAnnotation(this EdmModel model, IEdmEntitySet target, bool isFilterable,
            bool isRequiresFilter, IEnumerable<IEdmProperty> requiredProperties,
            IEnumerable<IEdmProperty> nonFilterableProperties)
        {
            if (model == null)
            {
                throw Error.ArgumentNull("model");
            }

            if (target == null)
            {
                throw Error.ArgumentNull("target");
            }

            requiredProperties = requiredProperties ?? EmptyStructuralProperties;
            nonFilterableProperties = nonFilterableProperties ?? EmptyStructuralProperties;

            IList<IEdmPropertyConstructor> properties = new List<IEdmPropertyConstructor>
            {
                new EdmPropertyConstructor(Constants.FilterRestrictions.Filterable,
                    new EdmBooleanConstant(isFilterable)),

                new EdmPropertyConstructor(Constants.FilterRestrictions.RequiresFilter,
                    new EdmBooleanConstant(isRequiresFilter)),

                new EdmPropertyConstructor(Constants.FilterRestrictions.RequiredProperties,
                    new EdmCollectionExpression(
                        requiredProperties.Select(p => new EdmPropertyPathExpression(p.Name)).ToArray())),

                new EdmPropertyConstructor(Constants.FilterRestrictions.NonFilterableProperties,
                    new EdmCollectionExpression(
                        nonFilterableProperties.Select(p => new EdmPropertyPathExpression(p.Name)).ToArray()))
            };

            model.SetVocabularyAnnotation(target, properties, Constants.FilterRestrictions.Term);
        }

        /// <summary>
        /// Set Org.OData.Capabilities.V1.SortRestrictions to target.
        /// </summary>
        /// <param name="model">The model referenced to.</param>
        /// <param name="target">The target entity set to set the inline annotation.</param>
        /// <param name="isSortable">This entity set supports the $orderby expressions.</param>
        /// <param name="ascendingOnlyProperties">These properties can only be used for sorting in ascending order.</param>
        /// <param name="descendingOnlyProperties">These properties can only be used for sorting in descending order.</param>
        /// <param name="nonSortableProperties">These properties cannot be used in $orderby expressions.</param>
        public static void SetSortRestrictionsAnnotation(this EdmModel model, IEdmEntitySet target, bool isSortable,
            IEnumerable<IEdmProperty> ascendingOnlyProperties, IEnumerable<IEdmProperty> descendingOnlyProperties,
            IEnumerable<IEdmProperty> nonSortableProperties)
        {
            if (model == null)
            {
                throw Error.ArgumentNull("model");
            }

            if (target == null)
            {
                throw Error.ArgumentNull("target");
            }

            ascendingOnlyProperties = ascendingOnlyProperties ?? EmptyStructuralProperties;
            descendingOnlyProperties = descendingOnlyProperties ?? EmptyStructuralProperties;
            nonSortableProperties = nonSortableProperties ?? EmptyStructuralProperties;

            IList<IEdmPropertyConstructor> properties = new List<IEdmPropertyConstructor>
            {
                new EdmPropertyConstructor(Constants.SortRestrictions.Sortable,
                    new EdmBooleanConstant(isSortable)),

                new EdmPropertyConstructor(Constants.SortRestrictions.AscendingOnlyProperties,
                    new EdmCollectionExpression(
                        ascendingOnlyProperties.Select(p => new EdmPropertyPathExpression(p.Name)).ToArray())),

                new EdmPropertyConstructor(Constants.SortRestrictions.DescendingOnlyProperties,
                    new EdmCollectionExpression(
                        descendingOnlyProperties.Select(p => new EdmPropertyPathExpression(p.Name)).ToArray())),

                new EdmPropertyConstructor(Constants.SortRestrictions.NonSortableProperties,
                    new EdmCollectionExpression(
                        nonSortableProperties.Select(p => new EdmPropertyPathExpression(p.Name)).ToArray()))
            };

            model.SetVocabularyAnnotation(target, properties, Constants.SortRestrictions.Term);
        }

        /// <summary>
        /// Set Org.OData.Capabilities.V1.ExpandRestrictions to target.
        /// </summary>
        /// <param name="model">The model referenced to.</param>
        /// <param name="target">The target entity set to set the inline annotation.</param>
        /// <param name="isExpandable">This entity set supports the expand expressions.</param>
        /// <param name="nonExpandableProperties">These properties cannot be used in $expand expressions.</param>
        public static void SetExpandRestrictionsAnnotation(this EdmModel model, IEdmEntitySet target, bool isExpandable,
            IEnumerable<IEdmNavigationProperty> nonExpandableProperties)
        {
            if (model == null)
            {
                throw Error.ArgumentNull("model");
            }

            if (target == null)
            {
                throw Error.ArgumentNull("target");
            }

            nonExpandableProperties = nonExpandableProperties ?? EmptyNavigationProperties;

            IList<IEdmPropertyConstructor> properties = new List<IEdmPropertyConstructor>
            {
                new EdmPropertyConstructor(Constants.ExpandRestrictions.Expandable,
                    new EdmBooleanConstant(isExpandable)),

                new EdmPropertyConstructor(Constants.ExpandRestrictions.NonExpandableProperties,
                    new EdmCollectionExpression(
                        nonExpandableProperties.Select(p => new EdmNavigationPropertyPathExpression(p.Name)).ToArray()))
            };

            model.SetVocabularyAnnotation(target, properties, Constants.ExpandRestrictions.Term);
        }

        public static void SetPermissionsRestrictionsAnnotations(this EdmModel model, EdmNavigationSource target, NavigationSourceConfiguration configuration)
        {
            _ = model ?? throw Error.ArgumentNull(nameof(model));
            if (target == null || configuration == null)
            {
                return;
            }

            if (target is EdmEntitySet entitySet && configuration is EntitySetConfiguration entitySetConfiguration)
            {
                model.SetInsertRestrictionsAnnotations(entitySet, entitySetConfiguration.InsertRestrictions);
                model.SetUpdateRestrictionsAnnotations(entitySet, entitySetConfiguration.UpdateRestrictions);
                model.SetDeleteRestrictionsAnnotations(entitySet, entitySetConfiguration.DeleteRestrictions);
            }

            model.SetReadRestrictionsAnnotations(target, configuration.ReadRestrictions);
        }

        public static void SetPermissionsRestrictionsAnnotations(this EdmModel model, EdmOperation target, OperationConfiguration configuration)
        {
            _ = model ?? throw Error.ArgumentNull(nameof(model));
            if (target == null || configuration == null)
            {
                return;
            }

            var restrictions = configuration.OperationRestrictions;
            if (restrictions == null)
            {
                return;
            }

            var properties = new List<IEdmPropertyConstructor>();
            if (restrictions.FilterSegmentSupported.HasValue)
            {
                properties.Add(new EdmPropertyConstructor(Constants.OperationRestrictions.FilterSegmentSupported, new EdmBooleanConstant(restrictions.FilterSegmentSupported.Value)));
            }

            var permissions = restrictions
                .Permissions
                .Select(ConvertToRecordExpression)
                .ToArray();

            properties.Add(new EdmPropertyConstructor(Constants.OperationRestrictions.Permissions, new EdmCollectionExpression(permissions)));

            model.SetVocabularyAnnotation(target, properties, Constants.OperationRestrictions.Term);
        }

        private static void SetInsertRestrictionsAnnotations(this EdmModel model, EdmEntitySet target, InsertRestrictionsType restrictions)
        {
            if (restrictions == null || !restrictions.Insertable.HasValue)
            {
                return;
            }

            var properties = new List<IEdmPropertyConstructor>();
            properties.Add(new EdmPropertyConstructor(Constants.InsertRestrictions.Insertable, new EdmBooleanConstant(restrictions.Insertable.Value)));

            if (!String.IsNullOrWhiteSpace(restrictions.Description))
            {
                properties.Add(new EdmPropertyConstructor(Constants.InsertRestrictions.Description, new EdmStringConstant(restrictions.Description)));
            }

            if (!String.IsNullOrWhiteSpace(restrictions.LongDescription))
            {
                properties.Add(new EdmPropertyConstructor(Constants.InsertRestrictions.LongDescription, new EdmStringConstant(restrictions.LongDescription)));
            }

            var permissions = restrictions
                .Permissions
                .Select(ConvertToRecordExpression)
                .ToArray();

            properties.Add(new EdmPropertyConstructor(Constants.InsertRestrictions.Permissions, new EdmCollectionExpression(permissions)));

            model.SetVocabularyAnnotation(target, properties, Constants.InsertRestrictions.Term);
        }

        private static void SetUpdateRestrictionsAnnotations(this EdmModel model, EdmEntitySet target, UpdateRestrictionsType restrictions)
        {
            if (restrictions == null || !restrictions.Updatable.HasValue || !restrictions.Upsertable.HasValue || !restrictions.DeltaUpdateSupported.HasValue)
            {
                return;
            }

            var properties = new List<IEdmPropertyConstructor>();
            if (restrictions.Updatable.HasValue)
            {
                properties.Add(new EdmPropertyConstructor(Constants.UpdateRestrictions.Updatable, new EdmBooleanConstant(restrictions.Updatable.Value)));
            }

            if (restrictions.Upsertable.HasValue)
            {
                properties.Add(new EdmPropertyConstructor(Constants.UpdateRestrictions.Upsertable, new EdmBooleanConstant(restrictions.Upsertable.Value)));
            }

            if (restrictions.DeltaUpdateSupported.HasValue)
            {
                properties.Add(new EdmPropertyConstructor(Constants.UpdateRestrictions.DeltaUpdateSupported, new EdmBooleanConstant(restrictions.DeltaUpdateSupported.Value)));
            }

            if (!String.IsNullOrWhiteSpace(restrictions.Description))
            {
                properties.Add(new EdmPropertyConstructor(Constants.UpdateRestrictions.Description, new EdmStringConstant(restrictions.Description)));
            }

            if (!String.IsNullOrWhiteSpace(restrictions.LongDescription))
            {
                properties.Add(new EdmPropertyConstructor(Constants.UpdateRestrictions.LongDescription, new EdmStringConstant(restrictions.LongDescription)));
            }

            var permissions = restrictions
                .Permissions
                .Select(ConvertToRecordExpression)
                .ToArray();

            properties.Add(new EdmPropertyConstructor(Constants.UpdateRestrictions.Permissions, new EdmCollectionExpression(permissions)));

            model.SetVocabularyAnnotation(target, properties, Constants.UpdateRestrictions.Term);
        }

        private static void SetDeleteRestrictionsAnnotations(this EdmModel model, EdmEntitySet target, DeleteRestrictionsType restrictions)
        {
            if (restrictions == null || !restrictions.Deletable.HasValue)
            {
                return;
            }

            var properties = new List<IEdmPropertyConstructor>();
            properties.Add(new EdmPropertyConstructor(Constants.DeleteRestrictions.Deletable, new EdmBooleanConstant(restrictions.Deletable.Value)));

            if (!String.IsNullOrWhiteSpace(restrictions.Description))
            {
                properties.Add(new EdmPropertyConstructor(Constants.DeleteRestrictions.Description, new EdmStringConstant(restrictions.Description)));
            }

            if (!String.IsNullOrWhiteSpace(restrictions.LongDescription))
            {
                properties.Add(new EdmPropertyConstructor(Constants.DeleteRestrictions.LongDescription, new EdmStringConstant(restrictions.LongDescription)));
            }

            var permissions = restrictions
                .Permissions
                .Select(ConvertToRecordExpression)
                .ToArray();

            properties.Add(new EdmPropertyConstructor(Constants.DeleteRestrictions.Permissions, new EdmCollectionExpression(permissions)));

            model.SetVocabularyAnnotation(target, properties, Constants.DeleteRestrictions.Term);
        }

        private static void SetReadRestrictionsAnnotations(this EdmModel model, EdmNavigationSource navigationSource, ReadRestrictionsType restrictions)
        {
            if (!(navigationSource is IEdmVocabularyAnnotatable target))
            {
                return;
            }

            var properties = GetReadRestrictionsProperties(restrictions);
            if (!properties.Any())
            {
                return;
            }

            model.SetVocabularyAnnotation(target, properties, Constants.ReadRestrictions.Term);
        }

        private static List<IEdmPropertyConstructor> GetReadRestrictionsProperties(ReadRestrictionsBase restrictions)
        {
            if (restrictions == null || !restrictions.Readable.HasValue)
            {
                return new List<IEdmPropertyConstructor>(0);
            }

            var properties = new List<IEdmPropertyConstructor>();
            properties.Add(new EdmPropertyConstructor(Constants.ReadRestrictionsBase.Readable, new EdmBooleanConstant(restrictions.Readable.Value)));

            if (!String.IsNullOrWhiteSpace(restrictions.Description))
            {
                properties.Add(new EdmPropertyConstructor(Constants.ReadRestrictionsBase.Description, new EdmStringConstant(restrictions.Description)));
            }

            if (!String.IsNullOrWhiteSpace(restrictions.LongDescription))
            {
                properties.Add(new EdmPropertyConstructor(Constants.ReadRestrictionsBase.LongDescription, new EdmStringConstant(restrictions.LongDescription)));
            }

            var permissions = restrictions
                .Permissions
                .Select(ConvertToRecordExpression)
                .ToArray();

            properties.Add(new EdmPropertyConstructor(Constants.ReadRestrictionsBase.Permissions, new EdmCollectionExpression(permissions)));

            if (!(restrictions is ReadRestrictionsType readRestrictions))
            {
                return properties;
            }

            var readByKeyProperties = GetReadRestrictionsProperties(readRestrictions.ReadByKeyRestrictions);
            if (!readByKeyProperties.Any())
            {
                return properties;
            }

            properties.Add(new EdmPropertyConstructor(Constants.ReadRestrictions.ReadByKeyRestrictions, new EdmRecordExpression(readByKeyProperties)));

            return properties;
        }

        private static EdmRecordExpression ConvertToRecordExpression(PermissionType permission)
        {
            var schemNameProperty = new EdmPropertyConstructor(Constants.PermissionType.SchemeName, new EdmStringConstant(permission.SchemeName));

            var scopes = permission
                .Scopes
                .Select(scope => new EdmRecordExpression(
                    new EdmPropertyConstructor(Constants.ScopeType.Scope, new EdmStringConstant(scope.Scope)),
                    new EdmPropertyConstructor(Constants.ScopeType.RestrictedProperties, new EdmStringConstant(scope.RestrictedProperties))))
                .ToArray();

            var scopesProperty = new EdmPropertyConstructor(Constants.PermissionType.Scopes, new EdmCollectionExpression(scopes));

            return new EdmRecordExpression(schemNameProperty, scopesProperty);
        }

        private static void SetVocabularyAnnotation(this EdmModel model, IEdmVocabularyAnnotatable target,
            IList<IEdmPropertyConstructor> properties, string qualifiedName)
        {
            Contract.Assert(model != null);
            Contract.Assert(target != null);

            IEdmTerm term = model.FindTerm(qualifiedName);
            if (term != null)
            {
                IEdmRecordExpression record = new EdmRecordExpression(properties);
                EdmVocabularyAnnotation annotation = new EdmVocabularyAnnotation(target, term, record);
                annotation.SetSerializationLocation(model, EdmVocabularyAnnotationSerializationLocation.Inline);
                model.SetVocabularyAnnotation(annotation);
            }
        }

        private static IEdmEnumType GetCapabilitiesNavigationType(this EdmModel model)
        {
            return _navigationType ??
                   (_navigationType = model.FindType(Constants.NavigationType.EnumType) as IEdmEnumType);
        }
    }
}
