using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>Movies rating labels in Canada</summary>
    public enum RatingCanadaMoviesType {
        /// <summary>Default value, allow all movies content</summary>
        [EnumMember(Value = "allAllowed")]
        AllAllowed,
        /// <summary>Do not allow any movies content</summary>
        [EnumMember(Value = "allBlocked")]
        AllBlocked,
        /// <summary>The G classification is suitable for all ages</summary>
        [EnumMember(Value = "general")]
        General,
        /// <summary>The PG classification advises parental guidance</summary>
        [EnumMember(Value = "parentalGuidance")]
        ParentalGuidance,
        /// <summary>The 14A classification is suitable for viewers above 14 or older</summary>
        [EnumMember(Value = "agesAbove14")]
        AgesAbove14,
        /// <summary>The 18A classification is suitable for viewers above 18 or older</summary>
        [EnumMember(Value = "agesAbove18")]
        AgesAbove18,
        /// <summary>The R classification is restricted to 18 years and older</summary>
        [EnumMember(Value = "restricted")]
        Restricted,
    }
}
