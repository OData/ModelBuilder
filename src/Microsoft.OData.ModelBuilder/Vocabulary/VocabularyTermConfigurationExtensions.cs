// Copyright (c) Microsoft Corporation.  All rights reserved.
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
			=> navigationSource?.GetVocabularyConfiguration<CallbackSupportedConfiguration, TEntity>();

		/// <summary>
		/// <see cref="ChangeTrackingConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ChangeTrackingConfiguration"/></returns>
		public static ChangeTrackingConfiguration HasChangeTracking<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<ChangeTrackingConfiguration, TEntity>();

		/// <summary>
		/// <see cref="CountRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CountRestrictionsConfiguration"/></returns>
		public static CountRestrictionsConfiguration HasCountRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<CountRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="NavigationRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="NavigationRestrictionsConfiguration"/></returns>
		public static NavigationRestrictionsConfiguration HasNavigationRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<NavigationRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="IndexableByKeyConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="IndexableByKeyConfiguration"/></returns>
		public static IndexableByKeyConfiguration HasIndexableByKey<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<IndexableByKeyConfiguration, TEntity>();

		/// <summary>
		/// <see cref="TopSupportedConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="TopSupportedConfiguration"/></returns>
		public static TopSupportedConfiguration HasTopSupported<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<TopSupportedConfiguration, TEntity>();

		/// <summary>
		/// <see cref="SkipSupportedConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SkipSupportedConfiguration"/></returns>
		public static SkipSupportedConfiguration HasSkipSupported<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<SkipSupportedConfiguration, TEntity>();

		/// <summary>
		/// <see cref="ComputeSupportedConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ComputeSupportedConfiguration"/></returns>
		public static ComputeSupportedConfiguration HasComputeSupported<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<ComputeSupportedConfiguration, TEntity>();

		/// <summary>
		/// <see cref="SelectSupportConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SelectSupportConfiguration"/></returns>
		public static SelectSupportConfiguration HasSelectSupport<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<SelectSupportConfiguration, TEntity>();

		/// <summary>
		/// <see cref="FilterFunctionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="FilterFunctionsConfiguration"/></returns>
		public static FilterFunctionsConfiguration HasFilterFunctions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<FilterFunctionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="FilterRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="FilterRestrictionsConfiguration"/></returns>
		public static FilterRestrictionsConfiguration HasFilterRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<FilterRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="SortRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SortRestrictionsConfiguration"/></returns>
		public static SortRestrictionsConfiguration HasSortRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<SortRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="ExpandRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ExpandRestrictionsConfiguration"/></returns>
		public static ExpandRestrictionsConfiguration HasExpandRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<ExpandRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="SearchRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SearchRestrictionsConfiguration"/></returns>
		public static SearchRestrictionsConfiguration HasSearchRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<SearchRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="InsertRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="InsertRestrictionsConfiguration"/></returns>
		public static InsertRestrictionsConfiguration HasInsertRestrictions<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<InsertRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="DeepInsertSupportConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeepInsertSupportConfiguration"/></returns>
		public static DeepInsertSupportConfiguration HasDeepInsertSupport<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<DeepInsertSupportConfiguration, TEntity>();

		/// <summary>
		/// <see cref="UpdateRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="UpdateRestrictionsConfiguration"/></returns>
		public static UpdateRestrictionsConfiguration HasUpdateRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<UpdateRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="DeepUpdateSupportConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeepUpdateSupportConfiguration"/></returns>
		public static DeepUpdateSupportConfiguration HasDeepUpdateSupport<TEntity>(this EntitySetConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<DeepUpdateSupportConfiguration, TEntity>();

		/// <summary>
		/// <see cref="DeleteRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeleteRestrictionsConfiguration"/></returns>
		public static DeleteRestrictionsConfiguration HasDeleteRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<DeleteRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="CollectionPropertyRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CollectionPropertyRestrictionsConfiguration"/></returns>
		public static CollectionPropertyRestrictionsConfiguration HasCollectionPropertyRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<CollectionPropertyRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// <see cref="ReadRestrictionsConfiguration"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ReadRestrictionsConfiguration"/></returns>
		public static ReadRestrictionsConfiguration HasReadRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyConfiguration<ReadRestrictionsConfiguration, TEntity>();

		/// <summary>
		/// Apply all builders as configured
		/// </summary>
        public static void SetVocabularyConfigurationAnnotations(this EdmModel model, EdmNavigationSource target, NavigationSourceConfiguration navigationConfiguration)
        {
            _ = model ?? throw Error.ArgumentNull(nameof(model));
            if (target == null || navigationConfiguration == null)
            {
                return;
            }

			foreach (var configuration in navigationConfiguration.VocabularyTermConfigurations.Values)
			{
				configuration.SetVocabularyAnnotations(model, (IEdmVocabularyAnnotatable)target);
			}
        }

		private static TConfiguration GetVocabularyConfiguration<TConfiguration, TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TConfiguration : VocabularyTermConfiguration, new() where TEntity : class
        {
            var vocabularyConfigurations = navigationSource.Configuration.VocabularyTermConfigurations;
            if (vocabularyConfigurations.TryGetValue(typeof(TConfiguration), out var configuration))
            {
                return configuration as TConfiguration;
            }

            configuration = new TConfiguration();
            vocabularyConfigurations.Add(typeof(TConfiguration), configuration);

            return (TConfiguration)configuration;
        }
	}
}

