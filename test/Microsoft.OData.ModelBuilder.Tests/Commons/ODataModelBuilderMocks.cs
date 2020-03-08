// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Edm;
using Moq;

namespace Microsoft.OData.ModelBuilder.Test.Commons
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
    }
}
