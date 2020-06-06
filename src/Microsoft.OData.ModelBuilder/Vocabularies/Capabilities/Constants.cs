// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License.  See License.txt in the project root for license information.

namespace Microsoft.OData.ModelBuilder.Vocabularies.Capabilities
{
    /// <summary>
    /// Constant values for Capabilities Vocabulary
    /// </summary>
    internal static class Constants
    {
        internal static class CountRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.CountRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.CountRestrictions";

            /// <summary>Property Countable of Org.OData.Capabilities.V1.CountRestrictions</summary>
            public const string Countable = "Countable";

            /// <summary>Property NonCountableProperties of Org.OData.Capabilities.V1.CountRestrictions</summary>
            public const string NonCountableProperties = "NonCountableProperties";

            /// <summary>Property NonCountableNavigationProperties of Org.OData.Capabilities.V1.CountRestrictions</summary>
            public const string NonCountableNavigationProperties = "NonCountableNavigationProperties";
        }

        internal static class NavigationRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.NavigationRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.NavigationRestrictions";

            /// <summary>Property Navigability of Org.OData.Capabilities.V1.NavigationRestrictions</summary>
            public const string Navigability = "Navigability";

            /// <summary>Property RestrictedProperties of Org.OData.Capabilities.V1.NavigationRestrictions</summary>
            public const string RestrictedProperties = "RestrictedProperties";
        }

        internal static class NavigationPropertyRestriction
        {
            /// <summary>Property NavigationProperty of Org.OData.Capabilities.V1.NavigationPropertyRestriction</summary>
            public const string NavigationProperty = "NavigationProperty";
        }

        internal static class NavigationType
        {
            /// <summary>Org.OData.Capabilities.V1.NavigationType</summary>
            public const string EnumType = "Org.OData.Capabilities.V1.NavigationType";
        }

        internal static class FilterRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.FilterRestrictions";

            /// <summary>Property Filterable of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string Filterable = "Filterable";

            /// <summary>Property RequiresFilter of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string RequiresFilter = "RequiresFilter";

            /// <summary>Property RequiredProperties of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string RequiredProperties = "RequiredProperties";

            /// <summary>Property NonFilterableProperties of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string NonFilterableProperties = "NonFilterableProperties";
        }

        internal static class SortRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.SortRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.SortRestrictions";

            /// <summary>Property Sortable of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string Sortable = "Sortable";

            /// <summary>Property AscendingOnlyProperties of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string AscendingOnlyProperties = "AscendingOnlyProperties";

            /// <summary>Property DescendingOnlyProperties of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string DescendingOnlyProperties = "DescendingOnlyProperties";

            /// <summary>Property NonSortableProperties of Org.OData.Capabilities.V1.FilterRestrictions</summary>
            public const string NonSortableProperties = "NonSortableProperties";
        }

        internal static class ExpandRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.ExpandRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.ExpandRestrictions";

            /// <summary>Property Expandable of Org.OData.Capabilities.V1.ExpandRestrictions</summary>
            public const string Expandable = "Expandable";

            /// <summary>Property NonExpandableProperties of Org.OData.Capabilities.V1.ExpandRestrictions</summary>
            public const string NonExpandableProperties = "NonExpandableProperties";
        }

        internal static class InsertRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.InsertRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.InsertRestrictions";

            /// <summary>Property Insertable of Org.OData.Capabilities.V1.InsertRestrictions</summary>
            public const string Insertable = "Insertable";

            /// <summary>Property Permissions of Org.OData.Capabilities.V1.InsertRestrictions.</summary>
            public const string Permissions = "Permissions";

            /// <summary>Property Description of Org.OData.Capabilities.V1.InsertRestrictions.</summary>
            public const string Description = "Description";

            /// <summary>Property LongDescription of Org.OData.Capabilities.V1.InsertRestrictions.</summary>
            public const string LongDescription = "LongDescription";
        }

        internal static class UpdateRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.UpdateRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.UpdateRestrictions";

            /// <summary>Property Updatable of Org.OData.Capabilities.V1.UpdateRestrictions</summary>
            public const string Updatable = "Updatable";

            /// <summary>Property Upsertable of Org.OData.Capabilities.V1.UpdateRestrictions</summary>
            public const string Upsertable = "Upsertable";

            /// <summary>Property DeltaUpdateSupported of Org.OData.Capabilities.V1.UpdateRestrictions</summary>
            public const string DeltaUpdateSupported = "DeltaUpdateSupported";

            /// <summary>Property Permissions of Org.OData.Capabilities.V1.UpdateRestrictions.</summary>
            public const string Permissions = "Permissions";

            /// <summary>Property Description of Org.OData.Capabilities.V1.UpdateRestrictions.</summary>
            public const string Description = "Description";

            /// <summary>Property LongDescription of Org.OData.Capabilities.V1.UpdateRestrictions.</summary>
            public const string LongDescription = "LongDescription";
        }

        internal static class DeleteRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.DeleteRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.DeleteRestrictions";

            /// <summary>Property Deletable of Org.OData.Capabilities.V1.DeleteRestrictions</summary>
            public const string Deletable = "Deletable";

            /// <summary>Property Permissions of Org.OData.Capabilities.V1.DeleteRestrictions.</summary>
            public const string Permissions = "Permissions";

            /// <summary>Property Description of Org.OData.Capabilities.V1.DeleteRestrictions.</summary>
            public const string Description = "Description";

            /// <summary>Property LongDescription of Org.OData.Capabilities.V1.DeleteRestrictions.</summary>
            public const string LongDescription = "LongDescription";
        }

        internal static class ReadRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.ReadRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.ReadRestrictions";

            /// <summary>Property ReadByKeyRestrictions of Org.OData.Capabilities.V1.ReadRestrictions.</summary>
            public const string ReadByKeyRestrictions = "ReadByKeyRestrictions";
        }

        internal static class ReadRestrictionsBase
        {
            /// <summary>Property Readable of Org.OData.Capabilities.V1.ReadRestrictionsBase</summary>
            public const string Readable = "Readable";

            /// <summary>Property Permissions of Org.OData.Capabilities.V1.ReadRestrictionsBase.</summary>
            public const string Permissions = "Permissions";

            /// <summary>Property Description of Org.OData.Capabilities.V1.ReadRestrictionsBase.</summary>
            public const string Description = "Description";

            /// <summary>Property LongDescription of Org.OData.Capabilities.V1.ReadRestrictionsBase.</summary>
            public const string LongDescription = "LongDescription";
        }

        internal static class OperationRestrictions
        {
            /// <summary>Org.OData.Capabilities.V1.OperationRestrictions</summary>
            public const string Term = "Org.OData.Capabilities.V1.OperationRestrictions";

            /// <summary>Property FilterSegmentSupported of Org.OData.Capabilities.V1.InsertRestrictions.</summary>
            public const string FilterSegmentSupported = "FilterSegmentSupported";

            /// <summary>Property Permissions of Org.OData.Capabilities.V1.InsertRestrictions.</summary>
            public const string Permissions = "Permissions";
        }

        internal static class PermissionType
        {
            /// <summary>Property SchemeName of Org.OData.Capabilities.V1.PermissionType.</summary>
            public const string SchemeName = "SchemeName";

            /// <summary>Property Scopes of Org.OData.Capabilities.V1.PermissionType.</summary>
            public const string Scopes = "Scopes";
        }

        internal static class ScopeType
        {
            /// <summary>Property Scope of Org.OData.Capabilities.V1.ScopeType.</summary>
            public const string Scope = "Scope";

            /// <summary>Property RestrictedProperties of Org.OData.Capabilities.V1.ScopeType.</summary>
            public const string RestrictedProperties = "RestrictedProperties";
        }
    }
}
