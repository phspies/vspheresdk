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
    public class VapiMetadataMetamodelElementValueType 
    {
        /// <summary>
        /// Type of the value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VapiMetadataMetamodelElementValueTypeEnum Type { get; set; }
        /// <summary>
        /// Long value of the metadata element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "long_value")]
        public long? LongValue { get; set; }
        /// <summary>
        /// String value of the metadata element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "string_value")]
        public string? StringValue { get; set; }
        /// <summary>
        /// List of strings value of the metadata element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_value")]
        public IList<string> ListValue { get; set; }
        /// <summary>
        /// Identifier of the structure element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "structure_id")]
        public string? StructureId { get; set; }
        /// <summary>
        /// List of identifiers of the structure elements.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "structure_ids")]
        public IList<string> StructureIds { get; set; }
    }
}
