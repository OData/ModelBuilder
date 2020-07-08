﻿// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;
using Microsoft.OData.ModelBuilder.Capabilities.V1;
using Microsoft.OData.ModelBuilder.Core.V1;

namespace Microsoft.OData.ModelBuilder
{
	/// <summary>
	/// Extension methods for vocabulary builders configurations
	/// </summary>
	public static class VocabularyTermConfigurationExtensions
	{
		internal static IEdmExpression ToEdmExpression(this string text)
			=> string.IsNullOrEmpty(text) ? null: new EdmStringConstant(text);
		/// <summary>
		/// <see cref="CallbackSupportedConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CallbackSupportedConfiguration"/></returns>
		public static CallbackSupportedConfiguration HasCallbackSupported<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<CallbackSupportedConfiguration>();

		/// <summary>
		/// <see cref="ChangeTrackingConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ChangeTrackingConfiguration"/></returns>
		public static ChangeTrackingConfiguration HasChangeTracking<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<ChangeTrackingConfiguration>();

		/// <summary>
		/// <see cref="ChangeTrackingConfiguration"/> configuration
		/// </summary>
		/// <param name="operationSource">The <see cref="IEdmOperation"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ChangeTrackingConfiguration"/></returns>
		public static ChangeTrackingConfiguration HasChangeTracking(this FunctionConfiguration operationSource)
			=> operationSource?.VocabularyTermConfigurations.GetOrCreateConfiguration<ChangeTrackingConfiguration>();

		/// <summary>
		/// <see cref="CountRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CountRestrictionsConfiguration"/></returns>
		public static CountRestrictionsConfiguration HasCountRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<CountRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="NavigationRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="NavigationRestrictionsConfiguration"/></returns>
		public static NavigationRestrictionsConfiguration HasNavigationRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<NavigationRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="IndexableByKeyConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="IndexableByKeyConfiguration"/></returns>
		public static IndexableByKeyConfiguration HasIndexableByKey<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<IndexableByKeyConfiguration>();

		/// <summary>
		/// <see cref="TopSupportedConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="TopSupportedConfiguration"/></returns>
		public static TopSupportedConfiguration HasTopSupported<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<TopSupportedConfiguration>();

		/// <summary>
		/// <see cref="SkipSupportedConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SkipSupportedConfiguration"/></returns>
		public static SkipSupportedConfiguration HasSkipSupported<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<SkipSupportedConfiguration>();

		/// <summary>
		/// <see cref="ComputeSupportedConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ComputeSupportedConfiguration"/></returns>
		public static ComputeSupportedConfiguration HasComputeSupported<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<ComputeSupportedConfiguration>();

		/// <summary>
		/// <see cref="SelectSupportConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public static SelectSupportConfiguration HasSelectSupport<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<SelectSupportConfiguration>();

		/// <summary>
		/// <see cref="FilterFunctionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="FilterFunctionsConfiguration"/></returns>
		public static FilterFunctionsConfiguration HasFilterFunctions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<FilterFunctionsConfiguration>();

		/// <summary>
		/// <see cref="FilterRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public static FilterRestrictionsConfiguration HasFilterRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<FilterRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="SortRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public static SortRestrictionsConfiguration HasSortRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<SortRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="ExpandRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ExpandRestrictionsConfiguration"/></returns>
		public static ExpandRestrictionsConfiguration HasExpandRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<ExpandRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="SearchRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SearchRestrictionsConfiguration"/></returns>
		public static SearchRestrictionsConfiguration HasSearchRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<SearchRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="InsertRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public static InsertRestrictionsConfiguration HasInsertRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<InsertRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="DeepInsertSupportConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeepInsertSupportConfiguration"/></returns>
		public static DeepInsertSupportConfiguration HasDeepInsertSupport<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<DeepInsertSupportConfiguration>();

		/// <summary>
		/// <see cref="UpdateRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public static UpdateRestrictionsConfiguration HasUpdateRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<UpdateRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="DeepUpdateSupportConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeepUpdateSupportConfiguration"/></returns>
		public static DeepUpdateSupportConfiguration HasDeepUpdateSupport<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<DeepUpdateSupportConfiguration>();

		/// <summary>
		/// <see cref="DeleteRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public static DeleteRestrictionsConfiguration HasDeleteRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<DeleteRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="CollectionPropertyRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CollectionPropertyRestrictionsConfiguration"/></returns>
		public static CollectionPropertyRestrictionsConfiguration HasCollectionPropertyRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<CollectionPropertyRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="OperationRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <param name="operationSource">The <see cref="IEdmOperation"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="OperationRestrictionsConfiguration"/></returns>
		public static OperationRestrictionsConfiguration HasOperationRestrictions(this OperationConfiguration operationSource)
			=> operationSource?.VocabularyTermConfigurations.GetOrCreateConfiguration<OperationRestrictionsConfiguration>();

		/// <summary>
		/// <see cref="ModificationQueryOptionsConfiguration"/> configuration
		/// </summary>
		/// <param name="operationSource">The <see cref="IEdmOperation"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ModificationQueryOptionsConfiguration"/></returns>
		public static ModificationQueryOptionsConfiguration HasModificationQueryOptions(this ActionConfiguration operationSource)
			=> operationSource?.VocabularyTermConfigurations.GetOrCreateConfiguration<ModificationQueryOptionsConfiguration>();

		/// <summary>
		/// <see cref="ReadRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public static ReadRestrictionsConfiguration HasReadRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.Configuration.VocabularyTermConfigurations.GetOrCreateConfiguration<ReadRestrictionsConfiguration>();

		/// <summary>
		/// Add vocabulary annotations to a model target.
		/// </summary>
		/// <param name="model"><see cref="EdmModel"/> to add annotations to</param>
		/// <param name="target"><see cref="EdmNavigationSource"/> to annotate</param>
		/// <param name="navigationSourceConfiguration"><see cref="NavigationSourceConfiguration"/> containing the collection of <see cref="VocabularyTermConfiguration"/> annotation configurations</param>
		public static void SetVocabularyConfigurationAnnotations(this EdmModel model, EdmNavigationSource target, NavigationSourceConfiguration navigationSourceConfiguration)
			=> model.SetVocabularyConfigurationAnnotations(target as IEdmVocabularyAnnotatable, navigationSourceConfiguration?.VocabularyTermConfigurations.Values);

        /// <summary>
        /// Add vocabulary annotations to a model target.
        /// </summary>
        /// <param name="model"><see cref="EdmModel"/> to add annotations to</param>
        /// <param name="target"><see cref="EdmOperation"/> to annotate</param>
        /// <param name="operationConfiguration"><see cref="OperationConfiguration"/> containing the collection of <see cref="VocabularyTermConfiguration"/> annotation configurations</param>
        public static void SetVocabularyConfigurationAnnotations(this EdmModel model, EdmOperation target, OperationConfiguration operationConfiguration)
            => model.SetVocabularyConfigurationAnnotations(target as IEdmVocabularyAnnotatable, operationConfiguration?.VocabularyTermConfigurations.Values);

        /// <summary>
        /// Add vocabulary annotations to a model target.
        /// </summary>
        /// <param name="model"><see cref="EdmModel"/> to add annotations to</param>
        /// <param name="target"><see cref="IEdmVocabularyAnnotatable"/> to annotate</param>
        /// <param name="configurations">Collection of <see cref="VocabularyTermConfiguration"/> annotation configurations</param>
        public static void SetVocabularyConfigurationAnnotations(this EdmModel model, IEdmVocabularyAnnotatable target, IEnumerable<VocabularyTermConfiguration> configurations)
        {
            _ = model ?? throw Error.ArgumentNull(nameof(model));
            if (target == null || configurations == null)
            {
                return;
            }

            foreach (var configuration in configurations)
            {
                configuration.SetVocabularyAnnotations(model, target);
            }
        }

        private static TConfiguration GetOrCreateConfiguration<TConfiguration>(this Dictionary<Type, VocabularyTermConfiguration> vocabularyConfigurations)
            where TConfiguration : VocabularyTermConfiguration, new()
        {
            if (vocabularyConfigurations.TryGetValue(typeof(TConfiguration), out var configuration))
            {
                return (TConfiguration)configuration;
            }

            configuration = new TConfiguration();
            vocabularyConfigurations.Add(typeof(TConfiguration), configuration);

            return (TConfiguration)configuration;
        }
	}
}

