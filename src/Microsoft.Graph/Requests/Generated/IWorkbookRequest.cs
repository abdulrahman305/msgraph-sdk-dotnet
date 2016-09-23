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
    /// The interface IWorkbookRequest.
    /// </summary>
    public partial interface IWorkbookRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified Workbook using PUT.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <returns>The created Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> CreateAsync(Workbook workbookToCreate);        /// <summary>
        /// Creates the specified Workbook using PUT.
        /// </summary>
        /// <param name="workbookToCreate">The Workbook to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> CreateAsync(Workbook workbookToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified Workbook.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified Workbook.
        /// </summary>
        /// <returns>The Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> GetAsync();

        /// <summary>
        /// Gets the specified Workbook.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified Workbook using PATCH.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <returns>The updated Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> UpdateAsync(Workbook workbookToUpdate);

        /// <summary>
        /// Updates the specified Workbook using PATCH.
        /// </summary>
        /// <param name="workbookToUpdate">The Workbook to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated Workbook.</returns>
        System.Threading.Tasks.Task<Workbook> UpdateAsync(Workbook workbookToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookRequest Select(string value);

    }
}
