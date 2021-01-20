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
    /// The type Alert.
    /// </summary>
    public partial class Alert : Entity
    {
    
		///<summary>
		/// The Alert constructor
		///</summary>
        public Alert()
        {
            this.ODataType = "microsoft.graph.alert";
        }
	
        /// <summary>
        /// Gets or sets activity group name.
        /// Name or alias of the activity group (attacker) this alert is attributed to.
        /// </summary>
        [JsonPropertyName("activityGroupName")]
        public string ActivityGroupName { get; set; }
    
        /// <summary>
        /// Gets or sets alert detections.
        /// </summary>
        [JsonPropertyName("alertDetections")]
        public IEnumerable<AlertDetection> AlertDetections { get; set; }
    
        /// <summary>
        /// Gets or sets assigned to.
        /// Name of the analyst the alert is assigned to for triage, investigation, or remediation (supports update).
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public string AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets azure subscription id.
        /// Azure subscription ID, present if this alert is related to an Azure resource.
        /// </summary>
        [JsonPropertyName("azureSubscriptionId")]
        public string AzureSubscriptionId { get; set; }
    
        /// <summary>
        /// Gets or sets azure tenant id.
        /// Azure Active Directory tenant ID. Required.
        /// </summary>
        [JsonPropertyName("azureTenantId")]
        public string AzureTenantId { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// Category of the alert (for example, credentialTheft, ransomware, etc.).
        /// </summary>
        [JsonPropertyName("category")]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or sets closed date time.
        /// Time at which the alert was closed. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z' (supports update).
        /// </summary>
        [JsonPropertyName("closedDateTime")]
        public DateTimeOffset? ClosedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets cloud app states.
        /// Security-related stateful information generated by the provider about the cloud application/s related to this alert.
        /// </summary>
        [JsonPropertyName("cloudAppStates")]
        public IEnumerable<CloudAppSecurityState> CloudAppStates { get; set; }
    
        /// <summary>
        /// Gets or sets comments.
        /// Customer-provided comments on alert (for customer alert management) (supports update).
        /// </summary>
        [JsonPropertyName("comments")]
        public IEnumerable<string> Comments { get; set; }
    
        /// <summary>
        /// Gets or sets confidence.
        /// Confidence of the detection logic (percentage between 1-100).
        /// </summary>
        [JsonPropertyName("confidence")]
        public Int32? Confidence { get; set; }
    
        /// <summary>
        /// Gets or sets created date time.
        /// Time at which the alert was created by the alert provider. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
        /// </summary>
        [JsonPropertyName("createdDateTime")]
        public DateTimeOffset? CreatedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets description.
        /// Alert description.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets detection ids.
        /// Set of alerts related to this alert entity (each alert is pushed to the SIEM as a separate record).
        /// </summary>
        [JsonPropertyName("detectionIds")]
        public IEnumerable<string> DetectionIds { get; set; }
    
        /// <summary>
        /// Gets or sets event date time.
        /// Time at which the event(s) that served as the trigger(s) to generate the alert occurred. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'. Required.
        /// </summary>
        [JsonPropertyName("eventDateTime")]
        public DateTimeOffset? EventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets feedback.
        /// Analyst feedback on the alert. Possible values are: unknown, truePositive, falsePositive, benignPositive. (supports update)
        /// </summary>
        [JsonPropertyName("feedback")]
        public AlertFeedback? Feedback { get; set; }
    
        /// <summary>
        /// Gets or sets file states.
        /// Security-related stateful information generated by the provider about the file(s) related to this alert.
        /// </summary>
        [JsonPropertyName("fileStates")]
        public IEnumerable<FileSecurityState> FileStates { get; set; }
    
        /// <summary>
        /// Gets or sets history states.
        /// </summary>
        [JsonPropertyName("historyStates")]
        public IEnumerable<AlertHistoryState> HistoryStates { get; set; }
    
        /// <summary>
        /// Gets or sets host states.
        /// Security-related stateful information generated by the provider about the host(s) related to this alert.
        /// </summary>
        [JsonPropertyName("hostStates")]
        public IEnumerable<HostSecurityState> HostStates { get; set; }
    
        /// <summary>
        /// Gets or sets incident ids.
        /// IDs of incidents related to current alert.
        /// </summary>
        [JsonPropertyName("incidentIds")]
        public IEnumerable<string> IncidentIds { get; set; }
    
        /// <summary>
        /// Gets or sets investigation security states.
        /// </summary>
        [JsonPropertyName("investigationSecurityStates")]
        public IEnumerable<InvestigationSecurityState> InvestigationSecurityStates { get; set; }
    
        /// <summary>
        /// Gets or sets last event date time.
        /// </summary>
        [JsonPropertyName("lastEventDateTime")]
        public DateTimeOffset? LastEventDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets last modified date time.
        /// Time at which the alert entity was last modified. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 would look like this: '2014-01-01T00:00:00Z'.
        /// </summary>
        [JsonPropertyName("lastModifiedDateTime")]
        public DateTimeOffset? LastModifiedDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets malware states.
        /// Threat Intelligence pertaining to malware related to this alert.
        /// </summary>
        [JsonPropertyName("malwareStates")]
        public IEnumerable<MalwareState> MalwareStates { get; set; }
    
        /// <summary>
        /// Gets or sets message security states.
        /// </summary>
        [JsonPropertyName("messageSecurityStates")]
        public IEnumerable<MessageSecurityState> MessageSecurityStates { get; set; }
    
        /// <summary>
        /// Gets or sets network connections.
        /// Security-related stateful information generated by the provider about the network connection(s) related to this alert.
        /// </summary>
        [JsonPropertyName("networkConnections")]
        public IEnumerable<NetworkConnection> NetworkConnections { get; set; }
    
        /// <summary>
        /// Gets or sets processes.
        /// Security-related stateful information generated by the provider about the process or processes related to this alert.
        /// </summary>
        [JsonPropertyName("processes")]
        public IEnumerable<Process> Processes { get; set; }
    
        /// <summary>
        /// Gets or sets recommended actions.
        /// Vendor/provider recommended action(s) to take as a result of the alert (for example, isolate machine, enforce2FA, reimage host).
        /// </summary>
        [JsonPropertyName("recommendedActions")]
        public IEnumerable<string> RecommendedActions { get; set; }
    
        /// <summary>
        /// Gets or sets registry key states.
        /// Security-related stateful information generated by the provider about the registry keys related to this alert.
        /// </summary>
        [JsonPropertyName("registryKeyStates")]
        public IEnumerable<RegistryKeyState> RegistryKeyStates { get; set; }
    
        /// <summary>
        /// Gets or sets security resources.
        /// Resources related to current alert. For example, for some alerts this can have the Azure Resource value.
        /// </summary>
        [JsonPropertyName("securityResources")]
        public IEnumerable<SecurityResource> SecurityResources { get; set; }
    
        /// <summary>
        /// Gets or sets severity.
        /// Alert severity - set by vendor/provider. Possible values are: unknown, informational, low, medium, high. Required.
        /// </summary>
        [JsonPropertyName("severity")]
        public AlertSeverity? Severity { get; set; }
    
        /// <summary>
        /// Gets or sets source materials.
        /// Hyperlinks (URIs) to the source material related to the alert, for example, provider's user interface for alerts or log search, etc.
        /// </summary>
        [JsonPropertyName("sourceMaterials")]
        public IEnumerable<string> SourceMaterials { get; set; }
    
        /// <summary>
        /// Gets or sets status.
        /// Alert lifecycle status (stage). Possible values are: unknown, newAlert, inProgress, resolved. (supports update). Required.
        /// </summary>
        [JsonPropertyName("status")]
        public AlertStatus? Status { get; set; }
    
        /// <summary>
        /// Gets or sets tags.
        /// User-definable labels that can be applied to an alert and can serve as filter conditions (for example 'HVA', 'SAW', etc.) (supports update).
        /// </summary>
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
    
        /// <summary>
        /// Gets or sets title.
        /// Alert title. Required.
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or sets triggers.
        /// Security-related information about the specific properties that triggered the alert (properties appearing in the alert). Alerts might contain information about multiple users, hosts, files, ip addresses. This field indicates which properties triggered the alert generation.
        /// </summary>
        [JsonPropertyName("triggers")]
        public IEnumerable<AlertTrigger> Triggers { get; set; }
    
        /// <summary>
        /// Gets or sets uri click security states.
        /// </summary>
        [JsonPropertyName("uriClickSecurityStates")]
        public IEnumerable<UriClickSecurityState> UriClickSecurityStates { get; set; }
    
        /// <summary>
        /// Gets or sets user states.
        /// Security-related stateful information generated by the provider about the user accounts related to this alert.
        /// </summary>
        [JsonPropertyName("userStates")]
        public IEnumerable<UserSecurityState> UserStates { get; set; }
    
        /// <summary>
        /// Gets or sets vendor information.
        /// Complex type containing details about the security product/service vendor, provider, and subprovider (for example, vendor=Microsoft; provider=Windows Defender ATP; subProvider=AppLocker). Required.
        /// </summary>
        [JsonPropertyName("vendorInformation")]
        public SecurityVendorInformation VendorInformation { get; set; }
    
        /// <summary>
        /// Gets or sets vulnerability states.
        /// Threat intelligence pertaining to one or more vulnerabilities related to this alert.
        /// </summary>
        [JsonPropertyName("vulnerabilityStates")]
        public IEnumerable<VulnerabilityState> VulnerabilityStates { get; set; }
    
    }
}

