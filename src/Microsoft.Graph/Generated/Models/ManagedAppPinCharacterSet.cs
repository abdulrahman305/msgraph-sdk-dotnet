using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Character set which is to be used for a user&apos;s app PIN</summary>
    public enum ManagedAppPinCharacterSet {
        /// <summary>Numeric characters</summary>
        [EnumMember(Value = "numeric")]
        Numeric,
        /// <summary>Alphanumeric and symbolic characters</summary>
        [EnumMember(Value = "alphanumericAndSymbol")]
        AlphanumericAndSymbol,
    }
}
