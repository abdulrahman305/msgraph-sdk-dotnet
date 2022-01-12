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
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type AccessReviewInstanceDecisionItemAzureRoleResource.
    /// </summary>
    public partial class AccessReviewInstanceDecisionItemAzureRoleResource : AccessReviewInstanceDecisionItemResource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessReviewInstanceDecisionItemAzureRoleResource"/> class.
        /// </summary>
        public AccessReviewInstanceDecisionItemAzureRoleResource()
        {
            this.ODataType = "microsoft.graph.accessReviewInstanceDecisionItemAzureRoleResource";
        }

        /// <summary>
        /// Gets or sets scope.
        /// </summary>
        [JsonPropertyName("scope")]
        public AccessReviewInstanceDecisionItemResource Scope { get; set; }
    
    }
}