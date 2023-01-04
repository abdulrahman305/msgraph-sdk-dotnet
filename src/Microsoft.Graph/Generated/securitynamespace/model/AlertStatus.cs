// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph.SecurityNamespace
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum AlertStatus.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum AlertStatus
    {
    
        /// <summary>
        /// Unknown
        /// </summary>
        Unknown = 0,
	
        /// <summary>
        /// New
        /// </summary>
        New = 2,
	
        /// <summary>
        /// In Progress
        /// </summary>
        InProgress = 4,
	
        /// <summary>
        /// Resolved
        /// </summary>
        Resolved = 8,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 31,
	
    }
}