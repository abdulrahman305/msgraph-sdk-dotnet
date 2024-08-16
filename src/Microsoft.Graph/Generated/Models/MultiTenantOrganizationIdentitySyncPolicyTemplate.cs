// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class MultiTenantOrganizationIdentitySyncPolicyTemplate : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The templateApplicationLevel property</summary>
        public Microsoft.Graph.Models.TemplateApplicationLevel? TemplateApplicationLevel
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.TemplateApplicationLevel?>("templateApplicationLevel"); }
            set { BackingStore?.Set("templateApplicationLevel", value); }
        }
        /// <summary>Defines whether users can be synchronized from the partner tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.CrossTenantUserSyncInbound? UserSyncInbound
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CrossTenantUserSyncInbound?>("userSyncInbound"); }
            set { BackingStore?.Set("userSyncInbound", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.CrossTenantUserSyncInbound UserSyncInbound
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CrossTenantUserSyncInbound>("userSyncInbound"); }
            set { BackingStore?.Set("userSyncInbound", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "templateApplicationLevel", n => { TemplateApplicationLevel = n.GetEnumValue<Microsoft.Graph.Models.TemplateApplicationLevel>(); } },
                { "userSyncInbound", n => { UserSyncInbound = n.GetObjectValue<Microsoft.Graph.Models.CrossTenantUserSyncInbound>(Microsoft.Graph.Models.CrossTenantUserSyncInbound.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<Microsoft.Graph.Models.TemplateApplicationLevel>("templateApplicationLevel", TemplateApplicationLevel);
            writer.WriteObjectValue<Microsoft.Graph.Models.CrossTenantUserSyncInbound>("userSyncInbound", UserSyncInbound);
        }
    }
}