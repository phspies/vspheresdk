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
    public class VapiMetadataMetamodelPackageInfoType 
    {
        /// <summary>
        /// Dot separated name of the package element. The segments in the name reflect the organization of the APIs. The format of
        /// each segment is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the
        /// word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming
        /// convention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Metamodel information of all the structure elements contained in the package element. The key in the {@term map} is the
        /// identifier of the structure element and the value in the {@term map} is the metamodel information for the structure
        /// element. <p> This does not include the structure elements contained in the service elements that are contained in this
        /// package element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "structures", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelStructureInfoType> Structures { get; set; }
        /// <summary>
        /// Metamodel information of all the enumeration elements contained in the package element. The key in the {@term map} is
        /// the identifier of the enumeration element and the value in the {@term map} is the metamodel information for the
        /// enumeration element. <p> This does not include the enumeration elements that are contained in the service elements of
        /// this package element or structure elements of this package element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enumerations", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelEnumerationInfoType> Enumerations { get; set; }
        /// <summary>
        /// Metamodel information of all the service elements contained in the package element. The key in the {@term map} is the
        /// identifier of the service element and the value in the {@term map} is the metamodel information for the service element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "services", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelServiceInfoType> Services { get; set; }
        /// <summary>
        /// Generic metadata elements for the package element. The key in the {@term map} is the name of the metadata element and
        /// the value is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier}
        /// contains possible string values for keys in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelElementMapType> Metadata { get; set; }
        /// <summary>
        /// English language documentation for a package. It can contain HTML markup and Javadoc tags. The first sentence of the
        /// package documentation is a complete sentence that identifies the package by name and summarizes the purpose of the
        /// package. <p> The primary purpose of a package documentation is to provide high-level context that will provide a
        /// framework in which the users can put the detail about the package contents.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
