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
    public class VapiMetadataMetamodelUserDefinedTypeA 
    {
        /// <summary>
        /// Category of the user defined named type. The named type could be a structure element or an enumeration element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
        /// <summary>
        /// Identifier of the user defined named type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_id", Required = Required.AllowNull)]
        public string ResourceId { get; set; }
    }
}
