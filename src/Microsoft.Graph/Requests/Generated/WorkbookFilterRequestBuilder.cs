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
    /// The type WorkbookFilterRequestBuilder.
    /// </summary>
    public partial class WorkbookFilterRequestBuilder : EntityRequestBuilder, IWorkbookFilterRequestBuilder
    {

        /// <summary>
        /// Constructs a new WorkbookFilterRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookFilterRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IWorkbookFilterRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IWorkbookFilterRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookFilterRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for WorkbookFilterApply.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyRequestBuilder Apply(
            WorkbookFilterCriteria criteria = null)
        {
            return new WorkbookFilterApplyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.apply"),
                this.Client,
                criteria);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyBottomItemsFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyBottomItemsFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyBottomItemsFilterRequestBuilder ApplyBottomItemsFilter(
            Int32 count)
        {
            return new WorkbookFilterApplyBottomItemsFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyBottomItemsFilter"),
                this.Client,
                count);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyBottomPercentFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyBottomPercentFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyBottomPercentFilterRequestBuilder ApplyBottomPercentFilter(
            Int32 percent)
        {
            return new WorkbookFilterApplyBottomPercentFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyBottomPercentFilter"),
                this.Client,
                percent);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyCellColorFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyCellColorFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyCellColorFilterRequestBuilder ApplyCellColorFilter(
            string color = null)
        {
            return new WorkbookFilterApplyCellColorFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyCellColorFilter"),
                this.Client,
                color);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyCustomFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyCustomFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyCustomFilterRequestBuilder ApplyCustomFilter(
            string oper,
            string criteria1 = null,
            string criteria2 = null)
        {
            return new WorkbookFilterApplyCustomFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyCustomFilter"),
                this.Client,
                oper,
                criteria1,
                criteria2);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyDynamicFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyDynamicFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyDynamicFilterRequestBuilder ApplyDynamicFilter(
            string criteria)
        {
            return new WorkbookFilterApplyDynamicFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyDynamicFilter"),
                this.Client,
                criteria);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyFontColorFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyFontColorFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyFontColorFilterRequestBuilder ApplyFontColorFilter(
            string color = null)
        {
            return new WorkbookFilterApplyFontColorFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyFontColorFilter"),
                this.Client,
                color);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyIconFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyIconFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyIconFilterRequestBuilder ApplyIconFilter(
            WorkbookIcon icon = null)
        {
            return new WorkbookFilterApplyIconFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyIconFilter"),
                this.Client,
                icon);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyTopItemsFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyTopItemsFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyTopItemsFilterRequestBuilder ApplyTopItemsFilter(
            Int32 count)
        {
            return new WorkbookFilterApplyTopItemsFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyTopItemsFilter"),
                this.Client,
                count);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyTopPercentFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyTopPercentFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyTopPercentFilterRequestBuilder ApplyTopPercentFilter(
            Int32 percent)
        {
            return new WorkbookFilterApplyTopPercentFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyTopPercentFilter"),
                this.Client,
                percent);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterApplyValuesFilter.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterApplyValuesFilterRequestBuilder"/>.</returns>
        public IWorkbookFilterApplyValuesFilterRequestBuilder ApplyValuesFilter(
            Newtonsoft.Json.Linq.JToken values = null)
        {
            return new WorkbookFilterApplyValuesFilterRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.applyValuesFilter"),
                this.Client,
                values);
        }

        /// <summary>
        /// Gets the request builder for WorkbookFilterClear.
        /// </summary>
        /// <returns>The <see cref="IWorkbookFilterClearRequestBuilder"/>.</returns>
        public IWorkbookFilterClearRequestBuilder Clear()
        {
            return new WorkbookFilterClearRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.clear"),
                this.Client);
        }
    
    }
}
