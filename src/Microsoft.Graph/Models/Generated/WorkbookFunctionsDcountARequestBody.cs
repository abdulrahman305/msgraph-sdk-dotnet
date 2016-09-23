// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;

    /// <summary>
    /// The type WorkbookFunctionsDcountARequestBody.
    /// </summary>
    [DataContract]
    public partial class WorkbookFunctionsDcountARequestBody
    {
    
        /// <summary>
        /// Gets or sets Database.
        /// </summary>
        [DataMember(Name = "database", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Database { get; set; }
    
        /// <summary>
        /// Gets or sets Field.
        /// </summary>
        [DataMember(Name = "field", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Field { get; set; }
    
        /// <summary>
        /// Gets or sets Criteria.
        /// </summary>
        [DataMember(Name = "criteria", EmitDefaultValue = false, IsRequired = false)]
        public Newtonsoft.Json.Linq.JToken Criteria { get; set; }
    
    }
}
