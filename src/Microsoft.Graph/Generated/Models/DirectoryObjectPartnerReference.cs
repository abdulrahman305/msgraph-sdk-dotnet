using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class DirectoryObjectPartnerReference : DirectoryObject, IParsable {
        /// <summary>Description of the object returned. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description {
            get { return BackingStore?.Get<string?>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#nullable restore
#else
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
#endif
        /// <summary>Name of directory object being returned, like group or application. Read-only.</summary>
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
        /// <summary>The tenant identifier for the partner tenant. Read-only.</summary>
        public Guid? ExternalPartnerTenantId {
            get { return BackingStore?.Get<Guid?>("externalPartnerTenantId"); }
            set { BackingStore?.Set("externalPartnerTenantId", value); }
        }
        /// <summary>The type of the referenced object in the partner tenant. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ObjectType {
            get { return BackingStore?.Get<string?>("objectType"); }
            set { BackingStore?.Set("objectType", value); }
        }
#nullable restore
#else
        public string ObjectType {
            get { return BackingStore?.Get<string>("objectType"); }
            set { BackingStore?.Set("objectType", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new directoryObjectPartnerReference and sets the default values.
        /// </summary>
        public DirectoryObjectPartnerReference() : base() {
            OdataType = "#microsoft.graph.directoryObjectPartnerReference";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DirectoryObjectPartnerReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DirectoryObjectPartnerReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"externalPartnerTenantId", n => { ExternalPartnerTenantId = n.GetGuidValue(); } },
                {"objectType", n => { ObjectType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteGuidValue("externalPartnerTenantId", ExternalPartnerTenantId);
            writer.WriteStringValue("objectType", ObjectType);
        }
    }
}