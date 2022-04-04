using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Users.Item.Messages.Item.CreateForward {
    /// <summary>Provides operations to call the createForward method.</summary>
    public class CreateForwardRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The Comment property</summary>
        public string Comment { get; set; }
        /// <summary>The Message property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Message Message { get; set; }
        /// <summary>The ToRecipients property</summary>
        public List<Recipient> ToRecipients { get; set; }
        /// <summary>
        /// Instantiates a new createForwardRequestBody and sets the default values.
        /// </summary>
        public CreateForwardRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CreateForwardRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateForwardRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"comment", (o,n) => { (o as CreateForwardRequestBody).Comment = n.GetStringValue(); } },
                {"message", (o,n) => { (o as CreateForwardRequestBody).Message = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Message>(MicrosoftGraphSdk.Models.Microsoft.Graph.Message.CreateFromDiscriminatorValue); } },
                {"toRecipients", (o,n) => { (o as CreateForwardRequestBody).ToRecipients = n.GetCollectionOfObjectValues<Recipient>(Recipient.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Message>("message", Message);
            writer.WriteCollectionOfObjectValues<Recipient>("toRecipients", ToRecipients);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
