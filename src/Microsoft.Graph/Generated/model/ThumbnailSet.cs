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
    /// The type Thumbnail Set.
    /// </summary>
    public partial class ThumbnailSet : Entity
    {
    
		///<summary>
		/// The ThumbnailSet constructor
		///</summary>
        public ThumbnailSet()
        {
            this.ODataType = "microsoft.graph.thumbnailSet";
        }
	
        /// <summary>
        /// Gets or sets large.
        /// A 1920x1920 scaled thumbnail.
        /// </summary>
        [JsonPropertyName("large")]
        public Thumbnail Large { get; set; }
    
        /// <summary>
        /// Gets or sets medium.
        /// A 176x176 scaled thumbnail.
        /// </summary>
        [JsonPropertyName("medium")]
        public Thumbnail Medium { get; set; }
    
        /// <summary>
        /// Gets or sets small.
        /// A 48x48 cropped thumbnail.
        /// </summary>
        [JsonPropertyName("small")]
        public Thumbnail Small { get; set; }
    
        /// <summary>
        /// Gets or sets source.
        /// A custom thumbnail image or the original image used to generate other thumbnails.
        /// </summary>
        [JsonPropertyName("source")]
        public Thumbnail Source { get; set; }
    
    }
}

