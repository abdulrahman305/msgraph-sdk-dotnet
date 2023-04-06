using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class UserTrainingStatusInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Date and time of assignment of the training to the user.</summary>
        public DateTimeOffset? AssignedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("assignedDateTime"); }
            set { BackingStore?.Set("assignedDateTime", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Date and time of completion of the training by the user.</summary>
        public DateTimeOffset? CompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>Display name of the assigned training.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The status of the training assigned to the user. Possible values are: unknown, assigned, inProgress, completed, overdue, unknownFutureValue.</summary>
        public Microsoft.Graph.Models.TrainingStatus? TrainingStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TrainingStatus?>("trainingStatus"); }
            set { BackingStore?.Set("trainingStatus", value); }
        }
        /// <summary>
        /// Instantiates a new userTrainingStatusInfo and sets the default values.
        /// </summary>
        public UserTrainingStatusInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserTrainingStatusInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserTrainingStatusInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"assignedDateTime", n => { AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"trainingStatus", n => { TrainingStatus = n.GetEnumValue<TrainingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("assignedDateTime", AssignedDateTime);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<TrainingStatus>("trainingStatus", TrainingStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
