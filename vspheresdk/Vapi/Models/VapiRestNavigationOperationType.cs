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
    public class VapiRestNavigationOperationType 
    {
        /// <summary>
        /// Name of the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Name of the service where the operations belongs to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service", Required = Required.AllowNull)]
        public string Service { get; set; }
        /// <summary>
        /// Documentation of the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
        /// <summary>
        /// List of References to execute the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "links", Required = Required.AllowNull)]
        public Dictionary<string,VapiRestNavigationReferenceType> Links { get; set; }
        /// <summary>
        /// Reference to meta data about the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public VapiRestNavigationReferenceType Metadata { get; set; }
    }
}
