// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class MultiTenantOrganizationJoinRequestTransitionDetails : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>State of the tenant in the multitenant organization currently being processed. The possible values are: pending, active, removed, unknownFutureValue. Read-only.</summary>
        public MultiTenantOrganizationMemberState? DesiredMemberState
        {
            get { return BackingStore?.Get<MultiTenantOrganizationMemberState?>("desiredMemberState"); }
            set { BackingStore?.Set("desiredMemberState", value); }
        }
        /// <summary>Details that explain the processing status if any. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Details
        {
            get { return BackingStore?.Get<string?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public string Details
        {
            get { return BackingStore?.Get<string>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Processing state of the asynchronous job. The possible values are: notStarted, running, succeeded, failed, unknownFutureValue. Read-only.</summary>
        public MultiTenantOrganizationMemberProcessingStatus? Status
        {
            get { return BackingStore?.Get<MultiTenantOrganizationMemberProcessingStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="MultiTenantOrganizationJoinRequestTransitionDetails"/> and sets the default values.
        /// </summary>
        public MultiTenantOrganizationJoinRequestTransitionDetails()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="MultiTenantOrganizationJoinRequestTransitionDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MultiTenantOrganizationJoinRequestTransitionDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MultiTenantOrganizationJoinRequestTransitionDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "desiredMemberState", n => { DesiredMemberState = n.GetEnumValue<MultiTenantOrganizationMemberState>(); } },
                { "details", n => { Details = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<MultiTenantOrganizationMemberProcessingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MultiTenantOrganizationMemberState>("desiredMemberState", DesiredMemberState);
            writer.WriteStringValue("details", Details);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<MultiTenantOrganizationMemberProcessingStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
