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
    public class VapiMetadataMetamodelComponentInfoType 
    {
        /// <summary>
        /// Dot separated name of the component element. The segments in the name reflect the organization of the APIs. The format
        /// of each segment is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the
        /// word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming
        /// convention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Metamodel metadata information of all the package elements contained in the component element. The key in the {@term
        /// map} is the identifier of the package element and the value in the {@term map} is the metamodel information of the
        /// package element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "packages", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelPackageInfoType> Packages { get; set; }
        /// <summary>
        /// Generic metadata for the component element. The key in the {@term map} is the name of the metadata element and the value
        /// is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier} contains
        /// possible string values for keys in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelElementMapType> Metadata { get; set; }
        /// <summary>
        /// English language documentation for a component. It can contain HTML markup and documentation tags (similar to Javadoc
        /// tags). The first sentence of the package documentation is a complete sentence that identifies the component by name and
        /// summarizes the purpose of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
