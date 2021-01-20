// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Managed IOSStore App.
    /// </summary>
    public partial class ManagedIOSStoreApp : ManagedApp
    {
    
		///<summary>
		/// The ManagedIOSStoreApp constructor
		///</summary>
        public ManagedIOSStoreApp()
        {
            this.ODataType = "microsoft.graph.managedIOSStoreApp";
        }
	
        /// <summary>
        /// Gets or sets applicable device type.
        /// The iOS architecture for which this app can run on.
        /// </summary>
        [JsonPropertyName("applicableDeviceType")]
        public IosDeviceType ApplicableDeviceType { get; set; }
    
        /// <summary>
        /// Gets or sets app store url.
        /// The Apple AppStoreUrl.
        /// </summary>
        [JsonPropertyName("appStoreUrl")]
        public string AppStoreUrl { get; set; }
    
        /// <summary>
        /// Gets or sets bundle id.
        /// The app's Bundle ID.
        /// </summary>
        [JsonPropertyName("bundleId")]
        public string BundleId { get; set; }
    
        /// <summary>
        /// Gets or sets minimum supported operating system.
        /// The value for the minimum supported operating system.
        /// </summary>
        [JsonPropertyName("minimumSupportedOperatingSystem")]
        public IosMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
    
    }
}

