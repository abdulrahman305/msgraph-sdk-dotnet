// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Sites.Item.Lists.Item.Items.Delta
{
    [Obsolete("This class is obsolete. Use DeltaGetResponse instead.")]
    #pragma warning disable CS1591
    public class DeltaResponse : Microsoft.Graph.Sites.Item.Lists.Item.Items.Delta.DeltaGetResponse, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Sites.Item.Lists.Item.Items.Delta.DeltaResponse"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Sites.Item.Lists.Item.Items.Delta.DeltaResponse CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Sites.Item.Lists.Item.Items.Delta.DeltaResponse();
        }
    }
}