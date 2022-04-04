using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Groups.Item.Onenote.Notebooks.Item.Sections.Item.CopyToSectionGroup {
    /// <summary>Provides operations to call the copyToSectionGroup method.</summary>
    public class CopyToSectionGroupRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The groupId property</summary>
        public string GroupId { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>The renameAs property</summary>
        public string RenameAs { get; set; }
        /// <summary>The siteCollectionId property</summary>
        public string SiteCollectionId { get; set; }
        /// <summary>The siteId property</summary>
        public string SiteId { get; set; }
        /// <summary>
        /// Instantiates a new copyToSectionGroupRequestBody and sets the default values.
        /// </summary>
        public CopyToSectionGroupRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CopyToSectionGroupRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CopyToSectionGroupRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"groupId", (o,n) => { (o as CopyToSectionGroupRequestBody).GroupId = n.GetStringValue(); } },
                {"id", (o,n) => { (o as CopyToSectionGroupRequestBody).Id = n.GetStringValue(); } },
                {"renameAs", (o,n) => { (o as CopyToSectionGroupRequestBody).RenameAs = n.GetStringValue(); } },
                {"siteCollectionId", (o,n) => { (o as CopyToSectionGroupRequestBody).SiteCollectionId = n.GetStringValue(); } },
                {"siteId", (o,n) => { (o as CopyToSectionGroupRequestBody).SiteId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("renameAs", RenameAs);
            writer.WriteStringValue("siteCollectionId", SiteCollectionId);
            writer.WriteStringValue("siteId", SiteId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
