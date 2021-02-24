// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type MdmWindowsInformationProtectionPolicyRequest.
    /// </summary>
    public partial class MdmWindowsInformationProtectionPolicyRequest : BaseRequest, IMdmWindowsInformationProtectionPolicyRequest
    {
        /// <summary>
        /// Constructs a new MdmWindowsInformationProtectionPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public MdmWindowsInformationProtectionPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicy using POST.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToCreate">The MdmWindowsInformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created MdmWindowsInformationProtectionPolicy.</returns>
        public async System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> CreateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            var newEntity = await this.SendAsync<MdmWindowsInformationProtectionPolicy>(mdmWindowsInformationProtectionPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified MdmWindowsInformationProtectionPolicy using POST and returns a <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToCreate">The MdmWindowsInformationProtectionPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MdmWindowsInformationProtectionPolicy>> CreateResponseAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.POST.ToString();
            return this.SendAsyncWithGraphResponse<MdmWindowsInformationProtectionPolicy>(mdmWindowsInformationProtectionPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            await this.SendAsync<MdmWindowsInformationProtectionPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified MdmWindowsInformationProtectionPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.DELETE.ToString();
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The MdmWindowsInformationProtectionPolicy.</returns>
        public async System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            var retrievedEntity = await this.SendAsync<MdmWindowsInformationProtectionPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified MdmWindowsInformationProtectionPolicy and returns a <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MdmWindowsInformationProtectionPolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = CoreConstants.HttpMethods.GET.ToString();
            return this.SendAsyncWithGraphResponse<MdmWindowsInformationProtectionPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PATCH.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated MdmWindowsInformationProtectionPolicy.</returns>
        public async System.Threading.Tasks.Task<MdmWindowsInformationProtectionPolicy> UpdateAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            var updatedEntity = await this.SendAsync<MdmWindowsInformationProtectionPolicy>(mdmWindowsInformationProtectionPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified MdmWindowsInformationProtectionPolicy using PATCH and returns a <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToUpdate">The MdmWindowsInformationProtectionPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{MdmWindowsInformationProtectionPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<MdmWindowsInformationProtectionPolicy>> UpdateResponseAsync(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = Constants.ContentTypes.JsonContentType;
            this.Method = CoreConstants.HttpMethods.PATCH.ToString();
            return this.SendAsyncWithGraphResponse<MdmWindowsInformationProtectionPolicy>(mdmWindowsInformationProtectionPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMdmWindowsInformationProtectionPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IMdmWindowsInformationProtectionPolicyRequest Expand(Expression<Func<MdmWindowsInformationProtectionPolicy, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IMdmWindowsInformationProtectionPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IMdmWindowsInformationProtectionPolicyRequest Select(Expression<Func<MdmWindowsInformationProtectionPolicy, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="mdmWindowsInformationProtectionPolicyToInitialize">The <see cref="MdmWindowsInformationProtectionPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(MdmWindowsInformationProtectionPolicy mdmWindowsInformationProtectionPolicyToInitialize)
        {

        }
    }
}
