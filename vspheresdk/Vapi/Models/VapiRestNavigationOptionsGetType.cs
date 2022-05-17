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
    public class VapiRestNavigationOptionsGetType 
    {
        /// <summary>
        /// URL for which operations are retrieved.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
        /// <summary>
        /// Base URL.
        /// The {param.name baseUrl} parameter is used by the service to produce absolute URLs. If unset then the service will
        /// produce relative URLs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_url")]
        public string? BaseUrl { get; set; }
    }
}
