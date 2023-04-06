using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum PlannerPreviewType {
        [EnumMember(Value = "automatic")]
        Automatic,
        [EnumMember(Value = "noPreview")]
        NoPreview,
        [EnumMember(Value = "checklist")]
        Checklist,
        [EnumMember(Value = "description")]
        Description,
        [EnumMember(Value = "reference")]
        Reference,
    }
}
