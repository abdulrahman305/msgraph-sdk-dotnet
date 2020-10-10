// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum Status.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum Status
    {
    
        /// <summary>
        /// Active
        /// </summary>
        Active = 0,
	
        /// <summary>
        /// Updated
        /// </summary>
        Updated = 1,
	
        /// <summary>
        /// Deleted
        /// </summary>
        Deleted = 2,
	
        /// <summary>
        /// Ignored
        /// </summary>
        Ignored = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}