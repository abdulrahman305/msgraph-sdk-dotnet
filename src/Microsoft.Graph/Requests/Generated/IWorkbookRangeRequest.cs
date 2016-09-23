// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.


namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IWorkbookRangeRequest.
    /// </summary>
    public partial interface IWorkbookRangeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookRange using PUT.
        /// </summary>
        /// <param name="workbookRangeToCreate">The WorkbookRange to create.</param>
        /// <returns>The created WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> CreateAsync(WorkbookRange workbookRangeToCreate);        /// <summary>
        /// Creates the specified WorkbookRange using PUT.
        /// </summary>
        /// <param name="workbookRangeToCreate">The WorkbookRange to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> CreateAsync(WorkbookRange workbookRangeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookRange.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookRange.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookRange.
        /// </summary>
        /// <returns>The WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookRange.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookRange using PATCH.
        /// </summary>
        /// <param name="workbookRangeToUpdate">The WorkbookRange to update.</param>
        /// <returns>The updated WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> UpdateAsync(WorkbookRange workbookRangeToUpdate);

        /// <summary>
        /// Updates the specified WorkbookRange using PATCH.
        /// </summary>
        /// <param name="workbookRangeToUpdate">The WorkbookRange to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookRange.</returns>
        System.Threading.Tasks.Task<WorkbookRange> UpdateAsync(WorkbookRange workbookRangeToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRangeRequest Select(string value);

    }
}
