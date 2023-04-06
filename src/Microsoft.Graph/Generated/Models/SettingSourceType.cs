using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum SettingSourceType {
        [EnumMember(Value = "deviceConfiguration")]
        DeviceConfiguration,
        [EnumMember(Value = "deviceIntent")]
        DeviceIntent,
    }
}
