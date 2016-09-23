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
    /// The type EventDeclineRequestBuilder.
    /// </summary>
    public partial class EventDeclineRequestBuilder : BaseActionMethodRequestBuilder<IEventDeclineRequest>, IEventDeclineRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="EventDeclineRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="Comment">A Comment parameter for the OData method call.</param>
        /// <param name="SendResponse">A SendResponse parameter for the OData method call.</param>
        public EventDeclineRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string Comment,
            bool? SendResponse)
            : base(requestUrl, client)
        {
            this.SetParameter("comment", Comment, true);
            this.SetParameter("sendResponse", SendResponse, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IEventDeclineRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new EventDeclineRequest(functionUrl, this.Client, options);

            if (this.HasParameter("comment"))
            {
                request.RequestBody.Comment = this.GetParameter<string>("comment");
            }

            if (this.HasParameter("sendResponse"))
            {
                request.RequestBody.SendResponse = this.GetParameter<bool?>("sendResponse");
            }

            return request;
        }
    }
}
