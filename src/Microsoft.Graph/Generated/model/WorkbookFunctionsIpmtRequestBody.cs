// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBody.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsIpmtRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsIpmtRequestBody
    {
    
        /// <summary>
        /// Gets or sets Rate.
        /// </summary>
        [JsonPropertyName("rate")]
        public System.Text.Json.JsonDocument Rate { get; set; }
    
        /// <summary>
        /// Gets or sets Per.
        /// </summary>
        [JsonPropertyName("per")]
        public System.Text.Json.JsonDocument Per { get; set; }
    
        /// <summary>
        /// Gets or sets Nper.
        /// </summary>
        [JsonPropertyName("nper")]
        public System.Text.Json.JsonDocument Nper { get; set; }
    
        /// <summary>
        /// Gets or sets Pv.
        /// </summary>
        [JsonPropertyName("pv")]
        public System.Text.Json.JsonDocument Pv { get; set; }
    
        /// <summary>
        /// Gets or sets Fv.
        /// </summary>
        [JsonPropertyName("fv")]
        public System.Text.Json.JsonDocument Fv { get; set; }
    
        /// <summary>
        /// Gets or sets Type.
        /// </summary>
        [JsonPropertyName("type")]
        public System.Text.Json.JsonDocument Type { get; set; }
    
    }
}
