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
    public class VapiMetadataMetamodelEnumerationInfoType 
    {
        /// <summary>
        /// Dot separated name of the enumeration element. The segments in the name reflect the organization of the APIs. The format
        /// of each segment is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the
        /// word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming
        /// convention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Metamodel information of all the enumeration value elements contained in this enumeration element. The order of the
        /// enumeration value elements in the list is same as the order in which they are defined in the interface definition file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "values", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelEnumerationValueInfoType> Values { get; set; }
        /// <summary>
        /// Generic metadata elements for an enumeration element. The key in the {@term map} is the name of the metadata element and
        /// the value is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier}
        /// contains possible string values for keys in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelElementMapType> Metadata { get; set; }
        /// <summary>
        /// English language documentation for an enumeration element. It can contain HTML markup and Javadoc tags. The first
        /// sentence of the enumeration documentation is a complete sentence that identifies the enumeration by name and summarizes
        /// the purpose of the enumeration. The documentation describes the context in which the enumeration is used. <p> The
        /// documentation also contains references to the context in which the enumeration is used. But if the enumeration is used
        /// in many contexts, the references may not be present.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
