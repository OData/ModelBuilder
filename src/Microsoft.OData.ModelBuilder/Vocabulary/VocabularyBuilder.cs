// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.
// This is an auto generated file. Please run the template to modify it.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.OData.Edm;
using Microsoft.OData.Edm.Vocabularies;

using Microsoft.OData.ModelBuilder.Capabilities.V1;

namespace Microsoft.OData.ModelBuilder
{
	/// <summary>
	/// Interface for clr types that can be converted into <see cref="EdmRecordExpression" />
	/// </summary>
	public interface IRecord
	{
        /// <summary>
        /// Convert a clr type to an <see cref="IEdmExpression" />
        /// </summary>
        /// <returns><see cref="IEdmExpression" /></returns>
		IEdmExpression ToEdmExpression();
	}

    /// <summary>
    /// Base vocabulary builder.
    /// </summary>
	public abstract partial class VocabularyBuilder : IRecord
	{
		private readonly string _termName;

        /// <summary>
        /// Creates a new instance of <see cref="VocabularyBuilder"/>
        /// </summary>
        /// <param name="termName">The name of the <see cref="IEdmTerm"/> being built.</param>
		public VocabularyBuilder(string termName) => _termName = termName;

		/// <inheritdoc/>
		public abstract IEdmExpression ToEdmExpression();

        /// <summary>
        /// Sets the vocabulary annotation on the model's target.
        /// </summary>
        /// <param name="model">The <see cref="IEdmModel"/> having reference vocabulary models.</param>
        /// <param name="target">The <see cref="IEdmVocabularyAnnotatable"/> to set annotations on.</param>
		public virtual void SetVocabularyAnnotations(EdmModel model, IEdmVocabularyAnnotatable target)
		{
			_ = model ?? throw new ArgumentNullException(nameof(model));
			_ = target ?? throw new ArgumentNullException(nameof(target));

			var expression = ToEdmExpression();
			if (expression == null)
			{
				return;
			}

			var term = model.FindTerm(_termName);
			if (term == null)
			{
				return;
			}

			var annotation = new EdmVocabularyAnnotation(target, term, expression);
			model.SetVocabularyAnnotation(annotation);
		}
	}

	/// <summary>
	/// Extension methods for vocabulary builders configurations
	/// </summary>
	public static class VocabularyBuilderExtensions
	{
		/// <summary>
		/// <see cref="ConformanceLevelBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ConformanceLevelBuilder"/></returns>
		public static ConformanceLevelBuilder HasConformanceLevel<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<ConformanceLevelBuilder, TEntity>();

		/// <summary>
		/// <see cref="SupportedFormatsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SupportedFormatsBuilder"/></returns>
		public static SupportedFormatsBuilder HasSupportedFormats<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<SupportedFormatsBuilder, TEntity>();

		/// <summary>
		/// <see cref="SupportedMetadataFormatsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SupportedMetadataFormatsBuilder"/></returns>
		public static SupportedMetadataFormatsBuilder HasSupportedMetadataFormats<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<SupportedMetadataFormatsBuilder, TEntity>();

		/// <summary>
		/// <see cref="AcceptableEncodingsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="AcceptableEncodingsBuilder"/></returns>
		public static AcceptableEncodingsBuilder HasAcceptableEncodings<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<AcceptableEncodingsBuilder, TEntity>();

		/// <summary>
		/// <see cref="AsynchronousRequestsSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="AsynchronousRequestsSupportedBuilder"/></returns>
		public static AsynchronousRequestsSupportedBuilder HasAsynchronousRequestsSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<AsynchronousRequestsSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="BatchContinueOnErrorSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="BatchContinueOnErrorSupportedBuilder"/></returns>
		public static BatchContinueOnErrorSupportedBuilder HasBatchContinueOnErrorSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<BatchContinueOnErrorSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="IsolationSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="IsolationSupportedBuilder"/></returns>
		public static IsolationSupportedBuilder HasIsolationSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<IsolationSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="CrossJoinSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CrossJoinSupportedBuilder"/></returns>
		public static CrossJoinSupportedBuilder HasCrossJoinSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<CrossJoinSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="CallbackSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CallbackSupportedBuilder"/></returns>
		public static CallbackSupportedBuilder HasCallbackSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<CallbackSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="ChangeTrackingBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ChangeTrackingBuilder"/></returns>
		public static ChangeTrackingBuilder HasChangeTracking<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<ChangeTrackingBuilder, TEntity>();

		/// <summary>
		/// <see cref="CountRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CountRestrictionsBuilder"/></returns>
		public static CountRestrictionsBuilder HasCountRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<CountRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="NavigationRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="NavigationRestrictionsBuilder"/></returns>
		public static NavigationRestrictionsBuilder HasNavigationRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<NavigationRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="IndexableByKeyBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="IndexableByKeyBuilder"/></returns>
		public static IndexableByKeyBuilder HasIndexableByKey<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<IndexableByKeyBuilder, TEntity>();

		/// <summary>
		/// <see cref="TopSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="TopSupportedBuilder"/></returns>
		public static TopSupportedBuilder HasTopSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<TopSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="SkipSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SkipSupportedBuilder"/></returns>
		public static SkipSupportedBuilder HasSkipSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<SkipSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="ComputeSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ComputeSupportedBuilder"/></returns>
		public static ComputeSupportedBuilder HasComputeSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<ComputeSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="SelectSupportBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SelectSupportBuilder"/></returns>
		public static SelectSupportBuilder HasSelectSupport<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<SelectSupportBuilder, TEntity>();

		/// <summary>
		/// <see cref="BatchSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="BatchSupportedBuilder"/></returns>
		public static BatchSupportedBuilder HasBatchSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<BatchSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="BatchSupportBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="BatchSupportBuilder"/></returns>
		public static BatchSupportBuilder HasBatchSupport<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<BatchSupportBuilder, TEntity>();

		/// <summary>
		/// <see cref="FilterFunctionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="FilterFunctionsBuilder"/></returns>
		public static FilterFunctionsBuilder HasFilterFunctions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<FilterFunctionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="FilterRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="FilterRestrictionsBuilder"/></returns>
		public static FilterRestrictionsBuilder HasFilterRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<FilterRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="SortRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SortRestrictionsBuilder"/></returns>
		public static SortRestrictionsBuilder HasSortRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<SortRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="ExpandRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ExpandRestrictionsBuilder"/></returns>
		public static ExpandRestrictionsBuilder HasExpandRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<ExpandRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="SearchRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="SearchRestrictionsBuilder"/></returns>
		public static SearchRestrictionsBuilder HasSearchRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<SearchRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="KeyAsSegmentSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="KeyAsSegmentSupportedBuilder"/></returns>
		public static KeyAsSegmentSupportedBuilder HasKeyAsSegmentSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<KeyAsSegmentSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="QuerySegmentSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="QuerySegmentSupportedBuilder"/></returns>
		public static QuerySegmentSupportedBuilder HasQuerySegmentSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<QuerySegmentSupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="InsertRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="InsertRestrictionsBuilder"/></returns>
		public static InsertRestrictionsBuilder HasInsertRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<InsertRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="DeepInsertSupportBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeepInsertSupportBuilder"/></returns>
		public static DeepInsertSupportBuilder HasDeepInsertSupport<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<DeepInsertSupportBuilder, TEntity>();

		/// <summary>
		/// <see cref="UpdateRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="UpdateRestrictionsBuilder"/></returns>
		public static UpdateRestrictionsBuilder HasUpdateRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<UpdateRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="DeepUpdateSupportBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeepUpdateSupportBuilder"/></returns>
		public static DeepUpdateSupportBuilder HasDeepUpdateSupport<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<DeepUpdateSupportBuilder, TEntity>();

		/// <summary>
		/// <see cref="DeleteRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="DeleteRestrictionsBuilder"/></returns>
		public static DeleteRestrictionsBuilder HasDeleteRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<DeleteRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="CollectionPropertyRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CollectionPropertyRestrictionsBuilder"/></returns>
		public static CollectionPropertyRestrictionsBuilder HasCollectionPropertyRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<CollectionPropertyRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="OperationRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="OperationRestrictionsBuilder"/></returns>
		public static OperationRestrictionsBuilder HasOperationRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<OperationRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="AnnotationValuesInQuerySupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="AnnotationValuesInQuerySupportedBuilder"/></returns>
		public static AnnotationValuesInQuerySupportedBuilder HasAnnotationValuesInQuerySupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<AnnotationValuesInQuerySupportedBuilder, TEntity>();

		/// <summary>
		/// <see cref="ModificationQueryOptionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ModificationQueryOptionsBuilder"/></returns>
		public static ModificationQueryOptionsBuilder HasModificationQueryOptions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<ModificationQueryOptionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="ReadRestrictionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="ReadRestrictionsBuilder"/></returns>
		public static ReadRestrictionsBuilder HasReadRestrictions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<ReadRestrictionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="CustomHeadersBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CustomHeadersBuilder"/></returns>
		public static CustomHeadersBuilder HasCustomHeaders<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<CustomHeadersBuilder, TEntity>();

		/// <summary>
		/// <see cref="CustomQueryOptionsBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="CustomQueryOptionsBuilder"/></returns>
		public static CustomQueryOptionsBuilder HasCustomQueryOptions<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<CustomQueryOptionsBuilder, TEntity>();

		/// <summary>
		/// <see cref="MediaLocationUpdateSupportedBuilder"/> configuration
		/// </summary>
		/// <typeparam name="TEntity">The entity type of the navigation source.</typeparam>
		/// <param name="navigationSource">The <see cref="IEdmNavigationSource"/> that can be built using <see cref="ODataModelBuilder"/>.</param>
		/// <returns><see cref="MediaLocationUpdateSupportedBuilder"/></returns>
		public static MediaLocationUpdateSupportedBuilder HasMediaLocationUpdateSupported<TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TEntity : class
			=> navigationSource?.GetVocabularyBuilder<MediaLocationUpdateSupportedBuilder, TEntity>();

		/// <summary>
		/// Apply all builders as configured
		/// </summary>
        public static void SetVocabularyBuilderAnnotations(this EdmModel model, EdmNavigationSource target, NavigationSourceConfiguration configuration)
        {
            _ = model ?? throw Error.ArgumentNull(nameof(model));
            if (target == null || configuration == null)
            {
                return;
            }

			foreach (var builder in configuration.VocabularyBuilders.Values)
			{
				builder.SetVocabularyAnnotations(model, (IEdmVocabularyAnnotatable)target);
			}
        }

		private static TBuilder GetVocabularyBuilder<TBuilder, TEntity>(this NavigationSourceConfiguration<TEntity> navigationSource) where TBuilder : VocabularyBuilder, new() where TEntity : class
        {
            var vocabularyBuilders = navigationSource.Configuration.VocabularyBuilders;
            if (vocabularyBuilders.TryGetValue(typeof(TBuilder), out var builder))
            {
                return builder as TBuilder;
            }

            builder = new TBuilder();
            vocabularyBuilders.Add(typeof(TBuilder), builder);

            return (TBuilder)builder;
        }
	}
}

