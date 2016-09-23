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
    /// The interface IWorkbookTableRequest.
    /// </summary>
    public partial interface IWorkbookTableRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookTable using PUT.
        /// </summary>
        /// <param name="workbookTableToCreate">The WorkbookTable to create.</param>
        /// <returns>The created WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> CreateAsync(WorkbookTable workbookTableToCreate);        /// <summary>
        /// Creates the specified WorkbookTable using PUT.
        /// </summary>
        /// <param name="workbookTableToCreate">The WorkbookTable to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> CreateAsync(WorkbookTable workbookTableToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WorkbookTable.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WorkbookTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WorkbookTable.
        /// </summary>
        /// <returns>The WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> GetAsync();

        /// <summary>
        /// Gets the specified WorkbookTable.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WorkbookTable using PATCH.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable to update.</param>
        /// <returns>The updated WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> UpdateAsync(WorkbookTable workbookTableToUpdate);

        /// <summary>
        /// Updates the specified WorkbookTable using PATCH.
        /// </summary>
        /// <param name="workbookTableToUpdate">The WorkbookTable to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated WorkbookTable.</returns>
        System.Threading.Tasks.Task<WorkbookTable> UpdateAsync(WorkbookTable workbookTableToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableRequest Expand(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookTableRequest Select(string value);

    }
}
