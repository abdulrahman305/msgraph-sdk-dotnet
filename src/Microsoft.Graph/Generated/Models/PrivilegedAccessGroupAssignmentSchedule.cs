// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class PrivilegedAccessGroupAssignmentSchedule : PrivilegedAccessSchedule, IParsable {
        /// <summary>The identifier of the membership or ownership assignment to the group that is governed by PIM. Required. The possible values are: owner, member, unknownFutureValue. Supports $filter (eq).</summary>
        public PrivilegedAccessGroupRelationships? AccessId {
            get { return BackingStore?.Get<PrivilegedAccessGroupRelationships?>("accessId"); }
            set { BackingStore?.Set("accessId", value); }
        }
        /// <summary>When the request activates an ownership or membership assignment in PIM for groups, this object represents the eligibility relationship. Otherwise, it is null. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PrivilegedAccessGroupEligibilitySchedule? ActivatedUsing {
            get { return BackingStore?.Get<PrivilegedAccessGroupEligibilitySchedule?>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#nullable restore
#else
        public PrivilegedAccessGroupEligibilitySchedule ActivatedUsing {
            get { return BackingStore?.Get<PrivilegedAccessGroupEligibilitySchedule>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#endif
        /// <summary>Indicates whether the membership or ownership assignment for the principal is granted through activation or direct assignment. Required. The possible values are: assigned, activated, unknownFutureValue. Supports $filter (eq).</summary>
        public PrivilegedAccessGroupAssignmentType? AssignmentType {
            get { return BackingStore?.Get<PrivilegedAccessGroupAssignmentType?>("assignmentType"); }
            set { BackingStore?.Set("assignmentType", value); }
        }
        /// <summary>References the group that is the scope of the membership or ownership assignment through PIM for groups. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Group? Group {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Group Group {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>The identifier of the group representing the scope of the membership or ownership assignment through PIM for groups. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId {
            get { return BackingStore?.Get<string?>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#nullable restore
#else
        public string GroupId {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#endif
        /// <summary>Indicates whether the assignment is derived from a direct group assignment or through a transitive assignment. The possible values are: direct, group, unknownFutureValue. Supports $filter (eq).</summary>
        public PrivilegedAccessGroupMemberType? MemberType {
            get { return BackingStore?.Get<PrivilegedAccessGroupMemberType?>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
        /// <summary>References the principal that&apos;s in the scope of this membership or ownership assignment request to the group that&apos;s governed by PIM. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DirectoryObject? Principal {
            get { return BackingStore?.Get<DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public DirectoryObject Principal {
            get { return BackingStore?.Get<DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>The identifier of the principal whose membership or ownership assignment is granted through PIM for groups. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="PrivilegedAccessGroupAssignmentSchedule"/> and sets the default values.
        /// </summary>
        public PrivilegedAccessGroupAssignmentSchedule() : base() {
            OdataType = "#microsoft.graph.privilegedAccessGroupAssignmentSchedule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="PrivilegedAccessGroupAssignmentSchedule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PrivilegedAccessGroupAssignmentSchedule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrivilegedAccessGroupAssignmentSchedule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"accessId", n => { AccessId = n.GetEnumValue<PrivilegedAccessGroupRelationships>(); } },
                {"activatedUsing", n => { ActivatedUsing = n.GetObjectValue<PrivilegedAccessGroupEligibilitySchedule>(PrivilegedAccessGroupEligibilitySchedule.CreateFromDiscriminatorValue); } },
                {"assignmentType", n => { AssignmentType = n.GetEnumValue<PrivilegedAccessGroupAssignmentType>(); } },
                {"group", n => { Group = n.GetObjectValue<Microsoft.Graph.Models.Group>(Microsoft.Graph.Models.Group.CreateFromDiscriminatorValue); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"memberType", n => { MemberType = n.GetEnumValue<PrivilegedAccessGroupMemberType>(); } },
                {"principal", n => { Principal = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"principalId", n => { PrincipalId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PrivilegedAccessGroupRelationships>("accessId", AccessId);
            writer.WriteObjectValue<PrivilegedAccessGroupEligibilitySchedule>("activatedUsing", ActivatedUsing);
            writer.WriteEnumValue<PrivilegedAccessGroupAssignmentType>("assignmentType", AssignmentType);
            writer.WriteObjectValue<Microsoft.Graph.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteEnumValue<PrivilegedAccessGroupMemberType>("memberType", MemberType);
            writer.WriteObjectValue<DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
        }
    }
}