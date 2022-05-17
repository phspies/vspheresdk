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
    public class VapiMetadataMetamodelConstantValueType 
    {
        /// <summary>
        /// Category of the type of constant value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public VapiMetadataMetamodelConstantValueCategoryType Category { get; set; }
        /// <summary>
        /// Primitive value of the constant element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "primitive_value")]
        public VapiMetadataMetamodelPrimitiveValueType PrimitiveValue { get; set; }
        /// <summary>
        /// List value of the constant element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "list_value")]
        public Dictionary<string,VapiMetadataMetamodelPrimitiveValueType> ListValue { get; set; }
    }
}
