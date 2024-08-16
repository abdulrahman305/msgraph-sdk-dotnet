// <auto-generated/>
using Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.Count;
using Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.Item;
using Microsoft.Graph.Models.ODataErrors;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications
{
    /// <summary>
    /// Provides operations to manage the includeApplications property of the microsoft.graph.authenticationConditionsApplications entity.
    /// </summary>
    public class IncludeApplicationsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.Count.CountRequestBuilder Count
        {
            get => new Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the includeApplications property of the microsoft.graph.authenticationConditionsApplications entity.</summary>
        /// <param name="position">The unique identifier of authenticationConditionApplication</param>
        /// <returns>A <see cref="Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.Item.AuthenticationConditionApplicationAppItemRequestBuilder"/></returns>
        public Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.Item.AuthenticationConditionApplicationAppItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("authenticationConditionApplication%2DappId", position);
                return new Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.Item.AuthenticationConditionApplicationAppItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IncludeApplicationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/conditions/applications/includeApplications{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IncludeApplicationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/identity/authenticationEventsFlows/{authenticationEventsFlow%2Did}/conditions/applications/includeApplications{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// List the applications linked to an authenticationEventsFlow. These are the applications for which the authentication experience defined by the user flow is enabled.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/authenticationconditionsapplications-list-includeapplications?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.AuthenticationConditionApplicationCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.AuthenticationConditionApplicationCollectionResponse?> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder.IncludeApplicationsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.AuthenticationConditionApplicationCollectionResponse> GetAsync(Action<RequestConfiguration<Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder.IncludeApplicationsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.AuthenticationConditionApplicationCollectionResponse>(requestInfo, Microsoft.Graph.Models.AuthenticationConditionApplicationCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Add or link an application to a user flow, or authenticationEventsFlow. This enables the authentication experience defined by the user flow to be enabled for the application. An application can only be linked to one user flow.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/authenticationconditionsapplications-post-includeapplications?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.AuthenticationConditionApplication"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="Microsoft.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Microsoft.Graph.Models.AuthenticationConditionApplication?> PostAsync(Microsoft.Graph.Models.AuthenticationConditionApplication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<Microsoft.Graph.Models.AuthenticationConditionApplication> PostAsync(Microsoft.Graph.Models.AuthenticationConditionApplication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", Microsoft.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<Microsoft.Graph.Models.AuthenticationConditionApplication>(requestInfo, Microsoft.Graph.Models.AuthenticationConditionApplication.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// List the applications linked to an authenticationEventsFlow. These are the applications for which the authentication experience defined by the user flow is enabled.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder.IncludeApplicationsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder.IncludeApplicationsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Add or link an application to a user flow, or authenticationEventsFlow. This enables the authentication experience defined by the user flow to be enabled for the application. An application can only be linked to one user flow.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Models.AuthenticationConditionApplication body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Microsoft.Graph.Models.AuthenticationConditionApplication body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder WithUrl(string rawUrl)
        {
            return new Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// List the applications linked to an authenticationEventsFlow. These are the applications for which the authentication experience defined by the user flow is enabled.
        /// </summary>
        public class IncludeApplicationsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class IncludeApplicationsRequestBuilderGetRequestConfiguration : RequestConfiguration<Microsoft.Graph.Identity.AuthenticationEventsFlows.Item.Conditions.Applications.IncludeApplications.IncludeApplicationsRequestBuilder.IncludeApplicationsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class IncludeApplicationsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}