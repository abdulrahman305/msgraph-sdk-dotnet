using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class IpAddress : Host, IParsable {
        /// <summary>The details about the autonomous system to which this IP address belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.AutonomousSystem? AutonomousSystem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.AutonomousSystem?>("autonomousSystem"); }
            set { BackingStore?.Set("autonomousSystem", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.AutonomousSystem AutonomousSystem {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.AutonomousSystem>("autonomousSystem"); }
            set { BackingStore?.Set("autonomousSystem", value); }
        }
#endif
        /// <summary>The country or region for this IP address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion {
            get { return BackingStore?.Get<string?>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#nullable restore
#else
        public string CountryOrRegion {
            get { return BackingStore?.Get<string>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#endif
        /// <summary>The hosting company listed for this host.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostingProvider {
            get { return BackingStore?.Get<string?>("hostingProvider"); }
            set { BackingStore?.Set("hostingProvider", value); }
        }
#nullable restore
#else
        public string HostingProvider {
            get { return BackingStore?.Get<string>("hostingProvider"); }
            set { BackingStore?.Set("hostingProvider", value); }
        }
#endif
        /// <summary>The block of IP addresses this IP address belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Netblock {
            get { return BackingStore?.Get<string?>("netblock"); }
            set { BackingStore?.Set("netblock", value); }
        }
#nullable restore
#else
        public string Netblock {
            get { return BackingStore?.Get<string>("netblock"); }
            set { BackingStore?.Set("netblock", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new IpAddress and sets the default values.
        /// </summary>
        public IpAddress() : base() {
            OdataType = "#microsoft.graph.security.ipAddress";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IpAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IpAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"autonomousSystem", n => { AutonomousSystem = n.GetObjectValue<Microsoft.Graph.Models.Security.AutonomousSystem>(Microsoft.Graph.Models.Security.AutonomousSystem.CreateFromDiscriminatorValue); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"hostingProvider", n => { HostingProvider = n.GetStringValue(); } },
                {"netblock", n => { Netblock = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.AutonomousSystem>("autonomousSystem", AutonomousSystem);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("hostingProvider", HostingProvider);
            writer.WriteStringValue("netblock", Netblock);
        }
    }
}