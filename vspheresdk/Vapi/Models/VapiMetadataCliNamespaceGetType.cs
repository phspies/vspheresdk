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
    public class VapiMetadataCliNamespaceGetType 
    {
        /// <summary>
        /// Identifier of the namespace for which to retreive information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity", Required = Required.AllowNull)]
        public VapiMetadataCliNamespaceIdentityType Identity { get; set; }
    }
}
