// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security
{
    #pragma warning disable CS1591
    public class EdiscoveryReviewSet : Microsoft.Graph.Models.Security.DataSet, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents queries within the review set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>? Queries
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>?>("queries"); }
            set { BackingStore?.Set("queries", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery> Queries
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>>("queries"); }
            set { BackingStore?.Set("queries", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.Security.EdiscoveryReviewSet"/> and sets the default values.
        /// </summary>
        public EdiscoveryReviewSet() : base()
        {
            OdataType = "#microsoft.graph.security.ediscoveryReviewSet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.Security.EdiscoveryReviewSet"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.Security.EdiscoveryReviewSet CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.Security.EdiscoveryReviewSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "queries", n => { Queries = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>(Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Security.EdiscoveryReviewSetQuery>("queries", Queries);
        }
    }
}
