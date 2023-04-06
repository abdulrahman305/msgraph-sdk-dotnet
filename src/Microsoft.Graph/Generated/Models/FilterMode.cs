using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum FilterMode {
        [EnumMember(Value = "include")]
        Include,
        [EnumMember(Value = "exclude")]
        Exclude,
    }
}
