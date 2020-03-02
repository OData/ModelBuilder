// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

using Microsoft.OData.Extensions.Builder;

namespace Microsoft.OData.Extensions.ModelBuilder.Tests
{
    public static class ODataModelBuilderExtensions
    {
        public static ODataModelBuilder Add_Color_EnumType(this ODataModelBuilder builder)
        {
            var color = builder.EnumType<Color>();
            color.Member(Color.Red);
            color.Member(Color.Green);
            color.Member(Color.Blue);
            return builder;
        }

        public static ODataModelBuilder Add_SimpleEnum_EnumType(this ODataModelBuilder builder)
        {
            var simpleEnum = builder.EnumType<SimpleEnum>();
            simpleEnum.Member(SimpleEnum.First);
            simpleEnum.Member(SimpleEnum.Second);
            simpleEnum.Member(SimpleEnum.Third);
            return builder;
        }

        public static ODataModelBuilder Add_FlagsEnum_EnumType(this ODataModelBuilder builder)
        {
            var flagsEnum = builder.EnumType<FlagsEnum>();
            flagsEnum.Member(FlagsEnum.One);
            flagsEnum.Member(FlagsEnum.Two);
            flagsEnum.Member(FlagsEnum.Four);
            return builder;
        }

        public static ODataModelBuilder Add_LongEnum_EnumType(this ODataModelBuilder builder)
        {
            var longEnum = builder.EnumType<LongEnum>();
            longEnum.Member(LongEnum.FirstLong);
            longEnum.Member(LongEnum.SecondLong);
            longEnum.Member(LongEnum.ThirdLong);
            return builder;
        }
    }
}
