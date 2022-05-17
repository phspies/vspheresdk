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
    public class VapiMetadataMetamodelGenericInstantiationTypeA 
    {
        /// <summary>
        /// The generic type that is being instantiated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "generic_type", Required = Required.AllowNull)]
        public VapiMetadataMetamodelGenericInstantiationGenericTypeA GenericType { get; set; }
        /// <summary>
        /// Type of the element parameter if the generic type instantiation is a {@link GenericType#LIST}, {@link
        /// GenericType#OPTIONAL} or {@link GenericType#SET}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "element_type")]
        public VapiMetadataMetamodelTypeA ElementType { get; set; }
        /// <summary>
        /// Type of the key parameter of the map generic type instantiation. The map generic type has a key parameter and value
        /// parameter. The type of the value parameter is described by {@link GenericInstantiation#mapValueType}..
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "map_key_type")]
        public VapiMetadataMetamodelTypeA MapKeyType { get; set; }
        /// <summary>
        /// Type of the value parameter of the map generic type instantiation. The map generic type has a key parameter and value
        /// parameter. The type of the key parameter is described by {@link GenericInstantiation#mapKeyType}..
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "map_value_type")]
        public VapiMetadataMetamodelTypeA MapValueType { get; set; }
    }
}
