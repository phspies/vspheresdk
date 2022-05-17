using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vapi.Models.Enums;

namespace vspheresdk.Vapi.Models
{
    public class VapiMetadataCliNamespaceInfoTypeA 
    {
        /// <summary>
        /// Basic namespace identity.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity", Required = Required.AllowNull)]
        public VapiMetadataCliNamespaceIdentityTypeA Identity { get; set; }
        /// <summary>
        /// The text description displayed to the user in help output.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// The children of this namespace in the tree of CLI namespaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "children", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataCliNamespaceIdentityTypeA> Children { get; set; }
    }
}
