// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class ProfileCardProperty : Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Allows an administrator to set a custom display label for the directory property and localize it for the users in their tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProfileCardAnnotation>? Annotations
        {
            get { return BackingStore?.Get<List<ProfileCardAnnotation>?>("annotations"); }
            set { BackingStore?.Set("annotations", value); }
        }
#nullable restore
#else
        public List<ProfileCardAnnotation> Annotations
        {
            get { return BackingStore?.Get<List<ProfileCardAnnotation>>("annotations"); }
            set { BackingStore?.Set("annotations", value); }
        }
#endif
        /// <summary>Identifies a profileCardProperty resource in Get, Update, or Delete operations. Allows an administrator to surface hidden Microsoft Entra ID properties on the Microsoft 365 profile card within their tenant. When present, the Microsoft Entra ID field referenced in this property is visible to all users in your tenant on the contact pane of the profile card. Allowed values for this field are: UserPrincipalName, Fax, StreetAddress, PostalCode, StateOrProvince, Alias, CustomAttribute1,  CustomAttribute2, CustomAttribute3, CustomAttribute4, CustomAttribute5, CustomAttribute6, CustomAttribute7, CustomAttribute8, CustomAttribute9, CustomAttribute10, CustomAttribute11, CustomAttribute12, CustomAttribute13, CustomAttribute14, CustomAttribute15.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DirectoryPropertyName
        {
            get { return BackingStore?.Get<string?>("directoryPropertyName"); }
            set { BackingStore?.Set("directoryPropertyName", value); }
        }
#nullable restore
#else
        public string DirectoryPropertyName
        {
            get { return BackingStore?.Get<string>("directoryPropertyName"); }
            set { BackingStore?.Set("directoryPropertyName", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="ProfileCardProperty"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ProfileCardProperty CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProfileCardProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "annotations", n => { Annotations = n.GetCollectionOfObjectValues<ProfileCardAnnotation>(ProfileCardAnnotation.CreateFromDiscriminatorValue)?.ToList(); } },
                { "directoryPropertyName", n => { DirectoryPropertyName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<ProfileCardAnnotation>("annotations", Annotations);
            writer.WriteStringValue("directoryPropertyName", DirectoryPropertyName);
        }
    }
}
