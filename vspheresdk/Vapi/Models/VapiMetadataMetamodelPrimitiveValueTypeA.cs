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
    public class VapiMetadataMetamodelPrimitiveValueTypeA 
    {
        /// <summary>
        /// Type of the constant value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VapiMetadataMetamodelPrimitiveValueTypeEnumA Type { get; set; }
        /// <summary>
        /// Boolean value of the constant.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "boolean_value")]
        public bool? BooleanValue { get; set; }
        /// <summary>
        /// Double value of the constant.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "double_value")]
        public double? DoubleValue { get; set; }
        /// <summary>
        /// Long value of the constant.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "long_value")]
        public long? LongValue { get; set; }
        /// <summary>
        /// String value of the constant.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "string_value")]
        public string? StringValue { get; set; }
    }
}
