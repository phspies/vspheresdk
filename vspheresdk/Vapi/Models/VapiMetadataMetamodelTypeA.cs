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
    public class VapiMetadataMetamodelTypeA 
    {
        /// <summary>
        /// Category of this type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public VapiMetadataMetamodelTypeCategoryEnumTypeA Category { get; set; }
        /// <summary>
        /// Category of the built-in type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "builtin_type")]
        public VapiMetadataMetamodelTypeBuiltinTypeEnumA BuiltinType { get; set; }
        /// <summary>
        /// Identifier and type of the user defined type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_defined_type")]
        public VapiMetadataMetamodelUserDefinedTypeA UserDefinedType { get; set; }
        /// <summary>
        /// Instantiation of one of the generic types available in the interface definition language.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "generic_instantiation")]
        public VapiMetadataMetamodelGenericInstantiationTypeA GenericInstantiation { get; set; }
    }
}
