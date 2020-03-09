// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using System;
using System.Globalization;

namespace Microsoft.OData.ModelBuilder.Tests.Commons
{
    public static class ODataConventionModelBuilderFactory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ODataConventionModelBuilder"/> class.
        /// </summary>
        /// <returns>A new instance of the <see cref="ODataConventionModelBuilder"/> class.</returns>
        public static ODataConventionModelBuilder Create()
        {
            return Create(isQueryCompositionMode: false);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ODataConventionModelBuilder"/> class.
        /// </summary>
        /// <returns>A new instance of the <see cref="ODataConventionModelBuilder"/> class.</returns>
        public static ODataConventionModelBuilder Create(bool isQueryCompositionMode)
        {
            MockAssemblyResolver resolver = new MockAssemblyResolver(
                typeof(ODataConventionModelBuilder).Assembly,
                typeof(ODataConventionModelBuilderFactory).Assembly,

                // Also, a few tests are built on CultureInfo so include it as well.
                typeof(CultureInfo).Assembly
                );

            return new ODataConventionModelBuilder(resolver, isQueryCompositionMode);
        }

        public static ODataConventionModelBuilder Create(Action<ODataConventionModelBuilder> settingAction)
        {
            ODataConventionModelBuilder builder = Create(false);
            settingAction?.Invoke(builder);
            return builder;
        }

        public static ODataConventionModelBuilder CreateWithTypes(params Type[] types)
        {
            MockAssembly assembly = new MockAssembly(types);
            MockAssemblyResolver resolver = new MockAssemblyResolver(assembly);
            return new ODataConventionModelBuilder(resolver);
        }

        public static ODataConventionModelBuilder CreateWithTypes(bool isQueryCompositionMode, params Type[] types)
        {
            MockAssembly assembly = new MockAssembly(types);
            MockAssemblyResolver resolver = new MockAssemblyResolver(assembly);
            return new ODataConventionModelBuilder(resolver, isQueryCompositionMode);
        }
    }
}
