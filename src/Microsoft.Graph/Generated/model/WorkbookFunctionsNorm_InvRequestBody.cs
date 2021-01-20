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
    /// The type WorkbookFunctionsNorm_InvRequestBody.
    /// </summary>
    public partial class WorkbookFunctionsNorm_InvRequestBody
    {
    
        /// <summary>
        /// Gets or sets Probability.
        /// </summary>
        [JsonPropertyName("probability")]
        public System.Text.Json.JsonDocument Probability { get; set; }
    
        /// <summary>
        /// Gets or sets Mean.
        /// </summary>
        [JsonPropertyName("mean")]
        public System.Text.Json.JsonDocument Mean { get; set; }
    
        /// <summary>
        /// Gets or sets StandardDev.
        /// </summary>
        [JsonPropertyName("standardDev")]
        public System.Text.Json.JsonDocument StandardDev { get; set; }
    
    }
}
