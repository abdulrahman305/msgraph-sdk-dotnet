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
    /// The type WorkbookApplicationCalculateRequestBuilder.
    /// </summary>
    public partial class WorkbookApplicationCalculateRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookApplicationCalculateRequest>, IWorkbookApplicationCalculateRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookApplicationCalculateRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="calculationType">A calculationType parameter for the OData method call.</param>
        public WorkbookApplicationCalculateRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string calculationType)
            : base(requestUrl, client)
        {
            this.SetParameter("calculationType", calculationType, false);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookApplicationCalculateRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookApplicationCalculateRequest(functionUrl, this.Client, options);

            if (this.HasParameter("calculationType"))
            {
                request.RequestBody.CalculationType = this.GetParameter<string>("calculationType");
            }

            return request;
        }
    }
}
