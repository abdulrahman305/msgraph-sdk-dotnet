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
    /// The type Secure Score Control Profile.
    /// </summary>
    public partial class SecureScoreControlProfile : Entity
    {
    
		///<summary>
		/// The SecureScoreControlProfile constructor
		///</summary>
        public SecureScoreControlProfile()
        {
            this.ODataType = "microsoft.graph.secureScoreControlProfile";
        }
	
        /// <summary>
        /// Gets or sets action type.
        /// Control action type (Config, Review, Behavior).
        /// </summary>
        [JsonPropertyName("actionType")]
        public string ActionType { get; set; }
    
        /// <summary>
        /// Gets or sets action url.
        /// URL to where the control can be actioned.
        /// </summary>
        [JsonPropertyName("actionUrl")]
        public string ActionUrl { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// GUID string for tenant ID.
        /// </summary>
        [JsonPropertyName("azureTenantId")]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets compliance information.
        /// </summary>
        [JsonPropertyName("complianceInformation")]
        public IEnumerable<ComplianceInformation> ComplianceInformation { get; set; }
    
        /// <summary>
        /// Gets or sets control category.
        /// Control action category (Identity, Data, Device, Apps, Infrastructure).
        /// </summary>
        [JsonPropertyName("controlCategory")]
        public string ControlCategory { get; set; }
    
        /// <summary>
        /// Gets or sets control state updates.
        /// </summary>
        [JsonPropertyName("controlStateUpdates")]
        public IEnumerable<SecureScoreControlStateUpdate> ControlStateUpdates { get; set; }
    
        /// <summary>
        /// Gets or sets deprecated.
        /// Flag to indicate if a control is depreciated.
        /// </summary>
        [JsonPropertyName("deprecated")]
        public bool? Deprecated { get; set; }
    
        /// <summary>
        /// Gets or sets implementation cost.
        /// Resource cost of implemmentating control (low, moderate, high).
        /// </summary>
        [JsonPropertyName("implementationCost")]
        public string ImplementationCost { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Time at which the control profile entity was last modified. The Timestamp type represents date and time
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets max score.
        /// max attainable score for the control.
        /// </summary>
        [JsonPropertyName("maxScore")]
        public double? MaxScore { get; set; }
    
        /// <summary>
        /// Gets or sets rank.
        /// Microsoft's stack ranking of control.
        /// </summary>
        [JsonPropertyName("rank")]
        public Int32? Rank { get; set; }
    
        /// <summary>
        /// Gets or sets remediation.
        /// Description of what the control will help remediate.
        /// </summary>
        [JsonPropertyName("remediation")]
        public string Remediation { get; set; }
    
        /// <summary>
        /// Gets or sets remediation impact.
        /// Description of the impact on users of the remediation.
        /// </summary>
        [JsonPropertyName("remediationImpact")]
        public string RemediationImpact { get; set; }
    
        /// <summary>
        /// Gets or sets service.
        /// Service that owns the control (Exchange, Sharepoint, Azure AD).
        /// </summary>
        [JsonPropertyName("service")]
        public string Service { get; set; }
    
        /// <summary>
        /// Gets or sets threats.
        /// List of threats the control mitigates (accountBreach,dataDeletion,dataExfiltration,dataSpillage,
        /// </summary>
        [JsonPropertyName("threats")]
        public IEnumerable<string> Threats { get; set; }
    
        /// <summary>
        /// Gets or sets tier.
        /// </summary>
        [JsonPropertyName("tier")]
        public string Tier { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Title of the control.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets user impact.
        /// </summary>
        [JsonPropertyName("userImpact")]
        public string UserImpact { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// </summary>
        [JsonPropertyName("vendorInformation")]
        public SecurityVendorInformation VendorInformation { get; set; }
    
    }
}

