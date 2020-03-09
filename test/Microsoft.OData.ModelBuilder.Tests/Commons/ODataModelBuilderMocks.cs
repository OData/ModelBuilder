// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using Moq;
using System;

namespace Microsoft.OData.ModelBuilder.Tests.Commons
{
    public static class ODataModelBuilderMocks
    {
        // Creates a mock of an ODataModelBuilder or any subclass of it that disables model validation
        // in order to reduce verbosity on tests.
        public static ODataModelBuilder GetModelBuilderMock()
        {
            Mock<ODataModelBuilder> mock = new Mock<ODataModelBuilder>();
            mock.Setup(b => b.ValidateModel(It.IsAny<IEdmModel>())).Callback(() => { });
            mock.CallBase = true;
            return mock.Object;
        }

        public static ODataConventionModelBuilder GetConventionModelBuilder()
        {
            Mock<ODataConventionModelBuilder> mock = new Mock<ODataConventionModelBuilder>();
            mock.Setup(b => b.ValidateModel(It.IsAny<IEdmModel>())).Callback(() => { });
            mock.CallBase = true;
            return mock.Object;
        }

        public static ODataConventionModelBuilder MockConventionModelBuilder(params Type[] types)
        {
            MockAssembly assembly = new MockAssembly(types);
            MockAssemblyResolver resolver = new MockAssemblyResolver(assembly);
            Mock<ODataConventionModelBuilder> mock = new Mock<ODataConventionModelBuilder>(resolver);
            mock.Setup(b => b.ValidateModel(It.IsAny<IEdmModel>())).Callback(() => { });
            mock.CallBase = true;
            return mock.Object;
        }
    }
}
