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
    public class VapiMetadataMetamodelConstantInfoTypeA 
    {
        /// <summary>
        /// Type of the constant element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VapiMetadataMetamodelTypeA Type { get; set; }
        /// <summary>
        /// Value of the constant element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public VapiMetadataMetamodelConstantValueTypeA Value { get; set; }
        /// <summary>
        /// English language documentation for the constant element. It can contain HTML markup and documentation tags (similar to
        /// Javadoc tags).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
