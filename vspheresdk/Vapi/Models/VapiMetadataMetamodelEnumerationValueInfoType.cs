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
    public class VapiMetadataMetamodelEnumerationValueInfoType 
    {
        /// <summary>
        /// Value in the enumerated type. All the characters in the string are capitalized.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Additional metadata for enumeration value in the enumerated type. The key in the {@term map} is the name of the metadata
        /// element and the value is the data associated with that metadata element. <p> The {@link
        /// vapi.metadata.metamodel.MetadataIdentifier} contains possible string values for keys in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelElementMapType> Metadata { get; set; }
        /// <summary>
        /// English language documentation for an enumeration value. It can contain HTML markup and documentation tags (similar to
        /// Javadoc tags). The first statement will be a noun or verb phrase that describes the purpose of the enumeration value.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
