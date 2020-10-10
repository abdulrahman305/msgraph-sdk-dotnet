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
    /// The enum WindowsStartMenuModeType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum WindowsStartMenuModeType
    {
    
        /// <summary>
        /// User Defined
        /// </summary>
        UserDefined = 0,
	
        /// <summary>
        /// Full Screen
        /// </summary>
        FullScreen = 1,
	
        /// <summary>
        /// Non Full Screen
        /// </summary>
        NonFullScreen = 2,
	
    }
}