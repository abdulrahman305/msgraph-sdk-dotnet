using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Print.Printers.Create {
    /// <summary>Provides operations to call the create method.</summary>
    public class CreateRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The certificateSigningRequest property</summary>
        public PrintCertificateSigningRequest CertificateSigningRequest { get; set; }
        /// <summary>The connectorId property</summary>
        public string ConnectorId { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The hasPhysicalDevice property</summary>
        public bool? HasPhysicalDevice { get; set; }
        /// <summary>The manufacturer property</summary>
        public string Manufacturer { get; set; }
        /// <summary>The model property</summary>
        public string Model { get; set; }
        /// <summary>The physicalDeviceId property</summary>
        public string PhysicalDeviceId { get; set; }
        /// <summary>
        /// Instantiates a new createRequestBody and sets the default values.
        /// </summary>
        public CreateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"certificateSigningRequest", (o,n) => { (o as CreateRequestBody).CertificateSigningRequest = n.GetObjectValue<PrintCertificateSigningRequest>(PrintCertificateSigningRequest.CreateFromDiscriminatorValue); } },
                {"connectorId", (o,n) => { (o as CreateRequestBody).ConnectorId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CreateRequestBody).DisplayName = n.GetStringValue(); } },
                {"hasPhysicalDevice", (o,n) => { (o as CreateRequestBody).HasPhysicalDevice = n.GetBoolValue(); } },
                {"manufacturer", (o,n) => { (o as CreateRequestBody).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as CreateRequestBody).Model = n.GetStringValue(); } },
                {"physicalDeviceId", (o,n) => { (o as CreateRequestBody).PhysicalDeviceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<PrintCertificateSigningRequest>("certificateSigningRequest", CertificateSigningRequest);
            writer.WriteStringValue("connectorId", ConnectorId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("hasPhysicalDevice", HasPhysicalDevice);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("physicalDeviceId", PhysicalDeviceId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
