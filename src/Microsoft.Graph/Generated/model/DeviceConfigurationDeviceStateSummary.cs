// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Device Configuration Device State Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class DeviceConfigurationDeviceStateSummary : Entity
    {
    
		///<summary>
		/// The DeviceConfigurationDeviceStateSummary constructor
		///</summary>
        public DeviceConfigurationDeviceStateSummary()
        {
            this.ODataType = "microsoft.graph.deviceConfigurationDeviceStateSummary";
        }
	
        /// <summary>
        /// Gets or sets compliant device count.
        /// Number of compliant devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "compliantDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? CompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets conflict device count.
        /// Number of conflict devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "conflictDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ConflictDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets error device count.
        /// Number of error devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "errorDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ErrorDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets non compliant device count.
        /// Number of NonCompliant devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nonCompliantDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NonCompliantDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets not applicable device count.
        /// Number of not applicable devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "notApplicableDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? NotApplicableDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets remediated device count.
        /// Number of remediated devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "remediatedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? RemediatedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets unknown device count.
        /// Number of unknown devices
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "unknownDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UnknownDeviceCount { get; set; }
    
    }
}
