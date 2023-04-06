using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Indicates a collection of apps to target which can be one of several pre-defined lists of apps or a manually selected list of apps</summary>
    public enum TargetedManagedAppGroupType {
        /// <summary>Target the collection of apps manually selected by the admin.</summary>
        [EnumMember(Value = "selectedPublicApps")]
        SelectedPublicApps,
        /// <summary>Target the core set of Microsoft apps (Office, Edge, etc).</summary>
        [EnumMember(Value = "allCoreMicrosoftApps")]
        AllCoreMicrosoftApps,
        /// <summary>Target all apps with Microsoft as publisher.</summary>
        [EnumMember(Value = "allMicrosoftApps")]
        AllMicrosoftApps,
        /// <summary>Target all apps with an available assignment.</summary>
        [EnumMember(Value = "allApps")]
        AllApps,
    }
}
