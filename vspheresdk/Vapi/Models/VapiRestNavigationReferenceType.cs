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
    public class VapiRestNavigationReferenceType 
    {
        /// <summary>
        /// HttpMethod to be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        public VapiRestNavigationHttpMethodType Method { get; set; }
        /// <summary>
        /// URL to be called.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "href", Required = Required.AllowNull)]
        public string Href { get; set; }
    }
}
