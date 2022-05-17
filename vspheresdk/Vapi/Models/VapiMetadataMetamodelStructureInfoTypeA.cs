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
    public class VapiMetadataMetamodelStructureInfoTypeA 
    {
        /// <summary>
        /// Dot separated name of the structure element. The segments in the name reflect the organization of the APIs. The format
        /// of each segment is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the
        /// word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming
        /// convention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Type of the structure.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VapiMetadataMetamodelStructureInfoTypeEnumA Type { get; set; }
        /// <summary>
        /// Metamodel information of all the enumeration elements contained in the structure element. The key in the {@term map} is
        /// the identifier of the enumeration element and the value is the metamodel information of the enumeration element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enumerations", Required = Required.AllowNull)]
        public IList<object> Enumerations { get; set; }
        /// <summary>
        /// Metamodel information of all the constant elements contained in the structure element. The key in the {@term map} is the
        /// name of the constant element and the value in the {@term map} is the metamodel information for the constant element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "constants", Required = Required.AllowNull)]
        public IList<object> Constants { get; set; }
        /// <summary>
        /// Metamodel information of all the field elements. The order of the field elements in the list matches the order in which
        /// the fields are defined in the service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "fields", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelFieldInfoTypeA> Fields { get; set; }
        /// <summary>
        /// Generic metadata elements for the structure element. The key in the {@term map} is the name of the metadata element and
        /// the value is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier}
        /// contains possible string values for keys in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public IList<object> Metadata { get; set; }
        /// <summary>
        /// English language documentation for a structure element. It can contain HTML markup and Javadoc tags. The first sentence
        /// of the structure documentation is a complete sentence that identifies the structure by name and summarizes the purpose
        /// of the structure.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
