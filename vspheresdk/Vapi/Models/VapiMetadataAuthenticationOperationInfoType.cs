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
    public class VapiMetadataAuthenticationOperationInfoType 
    {
        /// <summary>
        /// List of authentication schemes used by an operation element. The authentication scheme specified on the service element
        /// corresponding to this operation element is ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "schemes", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataAuthenticationAuthenticationInfoType> Schemes { get; set; }
    }
}
