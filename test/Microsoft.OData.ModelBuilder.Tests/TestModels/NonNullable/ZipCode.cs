// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Tests.TestModels.NonNullable
{
#nullable enable
    //
    // Most of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //     Part2           Nullable by annotation
    //
    // NullableContextAttribute{1}
    public class ZipCode
    {
        public string Part1 { get; set; } = string.Empty;
        // NullableAttribute{2}
        public string? Part2 { get; set; }
    }

    //
    // Most of the properties in this class will be set to NonNullable through the NullableContextAttribute
    //     RecursiveZipCode       Nullable by annotation
    //
    // NullableContextAttribute{1}
    public class RecursiveZipCode
    {
        public string Part1 { get; set; } = string.Empty;
        public string Part2 { get; set; } = string.Empty;
        public RecursiveZipCode? Recursive { get; set; }
    }
#nullable restore
}
