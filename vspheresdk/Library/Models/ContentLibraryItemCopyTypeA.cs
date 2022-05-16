using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentLibraryItemCopyTypeA 
    {
        /// <summary>
        /// A unique token generated on the client for each copy request. The token should be a universally unique identifier
        /// (UUID), for example: {@code b8a2a2e3-2314-43cd-a871-6ede0f429751}. This token can be used to guarantee idempotent copy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_token")]
        public string? ClientToken { get; set; }
        /// <summary>
        /// Specification for the new library item to be created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "destination_create_spec", Required = Required.AllowNull)]
        public ContentLibraryItemModelTypeA DestinationCreateSpec { get; set; }
    }
}
