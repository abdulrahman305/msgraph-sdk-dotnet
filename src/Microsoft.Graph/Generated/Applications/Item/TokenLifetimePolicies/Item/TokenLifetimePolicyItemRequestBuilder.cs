using Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item.Ref;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Microsoft.Graph.Applications.Item.TokenLifetimePolicies.Item {
    /// <summary>
    /// Builds and executes requests for operations under \applications\{application-id}\tokenLifetimePolicies\{tokenLifetimePolicy-id}
    /// </summary>
    public class TokenLifetimePolicyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>Provides operations to manage the collection of application entities.</summary>
        public RefRequestBuilder Ref { get =>
            new RefRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new TokenLifetimePolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenLifetimePolicyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/tokenLifetimePolicies/{tokenLifetimePolicy%2Did}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new TokenLifetimePolicyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public TokenLifetimePolicyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/applications/{application%2Did}/tokenLifetimePolicies/{tokenLifetimePolicy%2Did}", rawUrl) {
        }
    }
}
