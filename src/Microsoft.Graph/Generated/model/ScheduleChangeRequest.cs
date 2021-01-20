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
    /// The type Schedule Change Request.
    /// </summary>
    public partial class ScheduleChangeRequestObject : ChangeTrackedEntity
    {
    
		///<summary>
		/// The internal ScheduleChangeRequest constructor
		///</summary>
        protected internal ScheduleChangeRequestObject()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets assigned to.
        /// </summary>
        [JsonPropertyName("assignedTo")]
        public ScheduleChangeRequestActor? AssignedTo { get; set; }
    
        /// <summary>
        /// Gets or sets manager action date time.
        /// </summary>
        [JsonPropertyName("managerActionDateTime")]
        public DateTimeOffset? ManagerActionDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets manager action message.
        /// </summary>
        [JsonPropertyName("managerActionMessage")]
        public string ManagerActionMessage { get; set; }
    
        /// <summary>
        /// Gets or sets manager user id.
        /// </summary>
        [JsonPropertyName("managerUserId")]
        public string ManagerUserId { get; set; }
    
        /// <summary>
        /// Gets or sets sender date time.
        /// </summary>
        [JsonPropertyName("senderDateTime")]
        public DateTimeOffset? SenderDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets sender message.
        /// </summary>
        [JsonPropertyName("senderMessage")]
        public string SenderMessage { get; set; }
    
        /// <summary>
        /// Gets or sets sender user id.
        /// </summary>
        [JsonPropertyName("senderUserId")]
        public string SenderUserId { get; set; }
    
        /// <summary>
        /// Gets or sets state.
        /// </summary>
        [JsonPropertyName("state")]
        public ScheduleChangeState? State { get; set; }
    
    }
}

