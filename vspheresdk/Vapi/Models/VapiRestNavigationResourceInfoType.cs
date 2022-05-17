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
    public class VapiRestNavigationResourceInfoType 
    {
        /// <summary>
        /// Name of the resource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// HttpMethod to get resource information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        public VapiRestNavigationHttpMethodType Method { get; set; }
        /// <summary>
        /// URL to get resource information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "href", Required = Required.AllowNull)]
        public string Href { get; set; }
        /// <summary>
        /// Reference to the meta data for the resource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public VapiRestNavigationReferenceType Metadata { get; set; }
    }
}
