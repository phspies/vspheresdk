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
    public class VapiMetadataCliCommandGetTypeA 
    {
        /// <summary>
        /// Identifier of the command for which to retreive information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "identity", Required = Required.AllowNull)]
        public VapiMetadataCliCommandIdentityTypeA Identity { get; set; }
    }
}
