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
    public class VapiRestNavigationLinkType 
    {
        /// <summary>
        /// HttpMethod to be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        public VapiRestNavigationHttpMethodEnumType Method { get; set; }
        /// <summary>
        /// URL that should be called.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "href", Required = Required.AllowNull)]
        public string Href { get; set; }
        /// <summary>
        /// Reference to meta data describing the call.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public VapiRestNavigationReferenceType Metadata { get; set; }
    }
}
