// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type SignInFrequencySessionControl.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<SignInFrequencySessionControl>))]
    public partial class SignInFrequencySessionControl : ConditionalAccessSessionControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignInFrequencySessionControl"/> class.
        /// </summary>
        public SignInFrequencySessionControl()
        {
            this.ODataType = "microsoft.graph.signInFrequencySessionControl";
        }

        /// <summary>
        /// Gets or sets type.
        /// Possible values are: days, hours, or null if frequencyInterval is everyTime .
        /// </summary>
        [JsonPropertyName("type")]
        public SigninFrequencyType? Type { get; set; }
    
        /// <summary>
        /// Gets or sets value.
        /// The number of days or hours.
        /// </summary>
        [JsonPropertyName("value")]
        public Int32? Value { get; set; }
    
    }
}
