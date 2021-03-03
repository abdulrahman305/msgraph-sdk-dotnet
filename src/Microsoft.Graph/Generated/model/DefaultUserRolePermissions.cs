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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type DefaultUserRolePermissions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class DefaultUserRolePermissions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultUserRolePermissions"/> class.
        /// </summary>
        public DefaultUserRolePermissions()
        {
            this.ODataType = "microsoft.graph.defaultUserRolePermissions";
        }

        /// <summary>
        /// Gets or sets allowedToCreateApps.
        /// Indicates whether the default user role can create applications.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedToCreateApps", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowedToCreateApps { get; set; }
    
        /// <summary>
        /// Gets or sets allowedToCreateSecurityGroups.
        /// Indicates whether the default user role can create security groups.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedToCreateSecurityGroups", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowedToCreateSecurityGroups { get; set; }
    
        /// <summary>
        /// Gets or sets allowedToReadOtherUsers.
        /// Indicates whether the default user role can read other users.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowedToReadOtherUsers", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowedToReadOtherUsers { get; set; }
    
        /// <summary>
        /// Gets or sets permissionGrantPoliciesAssigned.
        /// Indicates if user consent to apps is allowed, and if it is, which permission to grant consent and which app consent policy (permissionGrantPolicy) govern the permission for users to grant consent. Value should be in the format managePermissionGrantsForSelf.{id}, where {id} is the id of a built-in or custom app consent policy. An empty list indicates user consent to apps is disabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "permissionGrantPoliciesAssigned", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> PermissionGrantPoliciesAssigned { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}