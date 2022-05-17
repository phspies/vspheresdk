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
    public class VapiRestNavigationServiceInfoType 
    {
        /// <summary>
        /// Documentation of the service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
        /// <summary>
        /// Name of the service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// HttpMethod to get service information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "method", Required = Required.AllowNull)]
        public VapiRestNavigationHttpMethodType Method { get; set; }
        /// <summary>
        /// URL to get service information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "href", Required = Required.AllowNull)]
        public string Href { get; set; }
        /// <summary>
        /// Reference to the meta data for the service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public VapiRestNavigationReferenceType Metadata { get; set; }
    }
}
