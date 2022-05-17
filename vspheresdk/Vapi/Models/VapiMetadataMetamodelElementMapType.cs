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
    public class VapiMetadataMetamodelElementMapType 
    {
        /// <summary>
        /// Metamodel information of the metadata elements. The key parameter of the {@term map} is the identifier for the element
        /// and the value corresponds to the element value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "elements", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelElementValueType> Elements { get; set; }
    }
}
