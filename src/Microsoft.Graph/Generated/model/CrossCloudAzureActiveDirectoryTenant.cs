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
    /// The type CrossCloudAzureActiveDirectoryTenant.
    /// </summary>
    public partial class CrossCloudAzureActiveDirectoryTenant : IdentitySource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrossCloudAzureActiveDirectoryTenant"/> class.
        /// </summary>
        public CrossCloudAzureActiveDirectoryTenant()
        {
            this.ODataType = "microsoft.graph.crossCloudAzureActiveDirectoryTenant";
        }

        /// <summary>
        /// Gets or sets cloudInstance.
        /// </summary>
        [JsonPropertyName("cloudInstance")]
        public string CloudInstance { get; set; }
    
        /// <summary>
        /// Gets or sets displayName.
        /// </summary>
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets tenantId.
        /// </summary>
        [JsonPropertyName("tenantId")]
        public string TenantId { get; set; }
    
    }
}