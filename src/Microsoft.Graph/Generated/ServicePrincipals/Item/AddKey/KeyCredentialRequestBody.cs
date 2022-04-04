using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.ServicePrincipals.Item.AddKey {
    /// <summary>Provides operations to call the addKey method.</summary>
    public class KeyCredentialRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The keyCredential property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.KeyCredential KeyCredential { get; set; }
        /// <summary>The passwordCredential property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PasswordCredential PasswordCredential { get; set; }
        /// <summary>The proof property</summary>
        public string Proof { get; set; }
        /// <summary>
        /// Instantiates a new KeyCredentialRequestBody and sets the default values.
        /// </summary>
        public KeyCredentialRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static KeyCredentialRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KeyCredentialRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"keyCredential", (o,n) => { (o as KeyCredentialRequestBody).KeyCredential = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.KeyCredential>(MicrosoftGraphSdk.Models.Microsoft.Graph.KeyCredential.CreateFromDiscriminatorValue); } },
                {"passwordCredential", (o,n) => { (o as KeyCredentialRequestBody).PasswordCredential = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PasswordCredential>(MicrosoftGraphSdk.Models.Microsoft.Graph.PasswordCredential.CreateFromDiscriminatorValue); } },
                {"proof", (o,n) => { (o as KeyCredentialRequestBody).Proof = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.KeyCredential>("keyCredential", KeyCredential);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PasswordCredential>("passwordCredential", PasswordCredential);
            writer.WriteStringValue("proof", Proof);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
