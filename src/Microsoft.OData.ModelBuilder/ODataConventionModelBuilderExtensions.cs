// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.ModelBuilder.Providers;

namespace Microsoft.OData.ModelBuilder
{
    /// <summary>
    /// Provides extension methods for the <see cref="ODataConventionModelBuilder"/> class.
    /// </summary>
    public static class ODataConventionModelBuilderExtensions
    {
        /// <summary>
        /// Enable lower camel case with default <see cref="NameResolverOptions"/>
        /// NameResolverOptions.ProcessReflectedPropertyNames |
        /// NameResolverOptions.ProcessDataMemberAttributePropertyNames |
        /// NameResolverOptions.ProcessExplicitPropertyNames.
        /// </summary>
        /// <param name="builder">The <see cref="ODataConventionModelBuilder"/> to be enabled with lower camel case.</param>
        /// <returns>Returns itself so that multiple calls can be chained.</returns>
        public static ODataConventionModelBuilder EnableLowerCamelCase(this ODataConventionModelBuilder builder)
        {
            if (builder == null)
            {
                throw Error.ArgumentNull("builder");
            }

            return builder.EnableLowerCamelCase(
                NameResolverOptions.ProcessReflectedPropertyNames |
                NameResolverOptions.ProcessDataMemberAttributePropertyNames |
                NameResolverOptions.ProcessExplicitPropertyNames
                );
        }

        /// <summary>
        /// Enable lower camel case with default <see cref="NameResolverOptions"/>
        /// NameResolverOptions.ProcessReflectedPropertyNames |
        /// NameResolverOptions.ProcessDataMemberAttributePropertyNames |
        /// NameResolverOptions.ProcessExplicitPropertyNames |
        /// NameResolverOptions.ProcessEnumMemberNames
        /// </summary>
        /// <param name="builder">The <see cref="ODataConventionModelBuilder"/> to be enabled with lower camel case.</param>
        /// <returns>Returns itself so that multiple calls can be chained.</returns>
        public static ODataConventionModelBuilder EnableLowerCamelCaseForPropertiesAndEnums(this ODataConventionModelBuilder builder)
        {
            if (builder == null)
            {
                throw Error.ArgumentNull("builder");
            }

            return builder.EnableLowerCamelCase(
                NameResolverOptions.ProcessReflectedPropertyNames |
                NameResolverOptions.ProcessDataMemberAttributePropertyNames |
                NameResolverOptions.ProcessExplicitPropertyNames |
                NameResolverOptions.ProcessEnumMemberNames
                );
        }

        /// <summary>
        /// Enable lower camel case with given <see cref="NameResolverOptions"/>.
        /// </summary>
        /// <param name="builder">The <see cref="ODataConventionModelBuilder"/> to be enabled with lower camel case.</param>
        /// <param name="options">The <see cref="NameResolverOptions"/> for the lower camel case.</param>
        /// <returns>Returns itself so that multiple calls can be chained.</returns>
        public static ODataConventionModelBuilder EnableLowerCamelCase(
            this ODataConventionModelBuilder builder,
            NameResolverOptions options)
        {
            if (builder == null)
            {
                throw Error.ArgumentNull("builder");
            }

            builder.OnModelCreating += new LowerCamelCaser(options).ApplyLowerCamelCase;
            return builder;
        }

        public static ODataConventionModelBuilder AddEdmTypeMappingProvider(
            this ODataConventionModelBuilder builder,
            IEdmTypeMappingProvider edmTypeMappingProvider)
        {
            if (builder == null)
            {
                throw Error.ArgumentNull("builder");
            }

            if (edmTypeMappingProvider == null)
            {
                throw Error.ArgumentNull("edmTypeMappingProvider");
            }

            builder.EdmTypeMappingProviders.Add(edmTypeMappingProvider);

            return builder;
        }

        public static ODataConventionModelBuilder AddModelConventions(
            this ODataConventionModelBuilder builder,
            params IODataModelConvention[] conventions)
        {
            if (builder == null)
            {
                throw Error.ArgumentNull("builder");
            }
            if (conventions == null)
            {
                throw Error.ArgumentNull("conventions");
            }
            foreach (IODataModelConvention convention in conventions)
            {
                builder.AddConvention(convention);
            }

            return builder;
        }
    }
}
