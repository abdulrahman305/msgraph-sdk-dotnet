// <auto-generated/>
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.Axes;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.DataLabels;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.Format;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.Image;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidth;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidthWithHeight;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.ImageWithWidthWithHeightWithFittingMode;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.Legend;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.Series;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.SetData;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.SetPosition;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.Title;
using Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName.Worksheet;
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
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.ItemWithName
{
    /// <summary>
    /// Provides operations to call the item method.
    /// </summary>
    public class ItemWithNameRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to manage the axes property of the microsoft.graph.workbookChart entity.</summary>
        public AxesRequestBuilder Axes
        {
            get => new AxesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the dataLabels property of the microsoft.graph.workbookChart entity.</summary>
        public DataLabelsRequestBuilder DataLabels
        {
            get => new DataLabelsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the format property of the microsoft.graph.workbookChart entity.</summary>
        public FormatRequestBuilder Format
        {
            get => new FormatRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the image method.</summary>
        public ImageRequestBuilder Image
        {
            get => new ImageRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the legend property of the microsoft.graph.workbookChart entity.</summary>
        public LegendRequestBuilder Legend
        {
            get => new LegendRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the series property of the microsoft.graph.workbookChart entity.</summary>
        public SeriesRequestBuilder Series
        {
            get => new SeriesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setData method.</summary>
        public SetDataRequestBuilder SetData
        {
            get => new SetDataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the setPosition method.</summary>
        public SetPositionRequestBuilder SetPosition
        {
            get => new SetPositionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the title property of the microsoft.graph.workbookChart entity.</summary>
        public TitleRequestBuilder Title
        {
            get => new TitleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the worksheet property of the microsoft.graph.workbookChart entity.</summary>
        public WorksheetRequestBuilder Worksheet
        {
            get => new WorksheetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="ItemWithNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="name">Usage: name=&apos;{name}&apos;</param>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemWithNameRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter, string name = "") : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/item(name='{name}')", pathParameters)
        {
            if (!string.IsNullOrWhiteSpace(name)) PathParameters.Add("name", name);
        }
        /// <summary>
        /// Instantiates a new <see cref="ItemWithNameRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemWithNameRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/drives/{drive%2Did}/items/{driveItem%2Did}/workbook/worksheets/{workbookWorksheet%2Did}/charts/item(name='{name}')", rawUrl)
        {
        }
        /// <summary>
        /// Invoke function item
        /// </summary>
        /// <returns>A <see cref="WorkbookChart"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkbookChart?> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<WorkbookChart> GetAsync(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<WorkbookChart>(requestInfo, WorkbookChart.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <returns>A <see cref="ImageWithWidthRequestBuilder"/></returns>
        /// <param name="width">Usage: width={width}</param>
        public ImageWithWidthRequestBuilder ImageWithWidth(int? width)
        {
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthRequestBuilder(PathParameters, RequestAdapter, width);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <returns>A <see cref="ImageWithWidthWithHeightRequestBuilder"/></returns>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        public ImageWithWidthWithHeightRequestBuilder ImageWithWidthWithHeight(int? height, int? width)
        {
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightRequestBuilder(PathParameters, RequestAdapter, height, width);
        }
        /// <summary>
        /// Provides operations to call the image method.
        /// </summary>
        /// <returns>A <see cref="ImageWithWidthWithHeightWithFittingModeRequestBuilder"/></returns>
        /// <param name="fittingMode">Usage: fittingMode=&apos;{fittingMode}&apos;</param>
        /// <param name="height">Usage: height={height}</param>
        /// <param name="width">Usage: width={width}</param>
        public ImageWithWidthWithHeightWithFittingModeRequestBuilder ImageWithWidthWithHeightWithFittingMode(string fittingMode, int? height, int? width)
        {
            if(string.IsNullOrEmpty(fittingMode)) throw new ArgumentNullException(nameof(fittingMode));
            _ = height ?? throw new ArgumentNullException(nameof(height));
            _ = width ?? throw new ArgumentNullException(nameof(width));
            return new ImageWithWidthWithHeightWithFittingModeRequestBuilder(PathParameters, RequestAdapter, fittingMode, height, width);
        }
        /// <summary>
        /// Invoke function item
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="ItemWithNameRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ItemWithNameRequestBuilder WithUrl(string rawUrl)
        {
            return new ItemWithNameRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        public class ItemWithNameRequestBuilderGetRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
