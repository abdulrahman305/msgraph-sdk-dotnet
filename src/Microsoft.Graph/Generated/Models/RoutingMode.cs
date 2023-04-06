using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum RoutingMode {
        [EnumMember(Value = "oneToOne")]
        OneToOne,
        [EnumMember(Value = "multicast")]
        Multicast,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
