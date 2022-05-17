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
    public class VapiMetadataCliNamespaceIdentityType 
    {
        /// <summary>
        /// The dot-separated path of the namespace containing the namespace in the CLI node tree. For top-level namespace this will
        /// be empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path", Required = Required.AllowNull)]
        public string Path { get; set; }
        /// <summary>
        /// The name displayed to the user for this namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
