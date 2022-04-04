using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AccessPackageAssignmentApprovalSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The isApprovalRequiredForAdd property</summary>
        public bool? IsApprovalRequiredForAdd { get; set; }
        /// <summary>The isApprovalRequiredForUpdate property</summary>
        public bool? IsApprovalRequiredForUpdate { get; set; }
        /// <summary>The stages property</summary>
        public List<AccessPackageApprovalStage> Stages { get; set; }
        /// <summary>
        /// Instantiates a new accessPackageAssignmentApprovalSettings and sets the default values.
        /// </summary>
        public AccessPackageAssignmentApprovalSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AccessPackageAssignmentApprovalSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageAssignmentApprovalSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isApprovalRequiredForAdd", (o,n) => { (o as AccessPackageAssignmentApprovalSettings).IsApprovalRequiredForAdd = n.GetBoolValue(); } },
                {"isApprovalRequiredForUpdate", (o,n) => { (o as AccessPackageAssignmentApprovalSettings).IsApprovalRequiredForUpdate = n.GetBoolValue(); } },
                {"stages", (o,n) => { (o as AccessPackageAssignmentApprovalSettings).Stages = n.GetCollectionOfObjectValues<AccessPackageApprovalStage>(AccessPackageApprovalStage.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isApprovalRequiredForAdd", IsApprovalRequiredForAdd);
            writer.WriteBoolValue("isApprovalRequiredForUpdate", IsApprovalRequiredForUpdate);
            writer.WriteCollectionOfObjectValues<AccessPackageApprovalStage>("stages", Stages);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
