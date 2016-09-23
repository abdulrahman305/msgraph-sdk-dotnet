// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookChartLineFormatRequestBuilder.
    /// </summary>
    public partial class WorkbookChartLineFormatRequestBuilder : EntityRequestBuilder, IWorkbookChartLineFormatRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookChartLineFormatRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartLineFormatRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookChartLineFormatRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookChartLineFormatRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartLineFormatRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookChartLineFormatClear.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartLineFormatClearRequestBuilder"/>.</returns>
        public IWorkbookChartLineFormatClearRequestBuilder Clear()
        {
            return new WorkbookChartLineFormatClearRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.clear"),
                this.Client);
        }
    
    }
}
