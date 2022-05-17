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
    public class VapiMetadataMetamodelServiceInfoTypeA 
    {
        /// <summary>
        /// Dot separated name of the service element. The segments in the name reflect the organization of the APIs. The format of
        /// each segment is lower case with underscores. Each underscore represents a word boundary. If there are acronyms in the
        /// word, the capitalization is preserved. This format makes it easy to translate the segment into a different naming
        /// convention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Metamodel information of all the operation elements contained in the service element. The key in the {@term map} is the
        /// identifier of the operation element and the value in the {@term map} is the metamodel information for the operation
        /// element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "operations", Required = Required.AllowNull)]
        public IList<object> Operations { get; set; }
        /// <summary>
        /// Metamodel information of all the structure elements contained in the service element. The key in the {@term map} is the
        /// identifier of the structure element and the value in the {@term map} is the metamodel information for the structure
        /// element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "structures", Required = Required.AllowNull)]
        public IList<object> Structures { get; set; }
        /// <summary>
        /// Metamodel information of all the enumeration elements contained in the service element. The key in the {@term map} is
        /// the identifier of the enumeration element and the value in the {@term map} is the metamodel information for the
        /// enumeration element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enumerations", Required = Required.AllowNull)]
        public IList<object> Enumerations { get; set; }
        /// <summary>
        /// Metamodel information of all the constant elements contained in the service element. The key in the {@term map} is the
        /// name of the constant element and the value in the {@term map} is the metamodel information for the contant element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "constants", Required = Required.AllowNull)]
        public IList<object> Constants { get; set; }
        /// <summary>
        /// Generic metadata elements for the service element. The key in the {@term map} is the name of the metadata element and
        /// the value is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier}
        /// contains possible string values for keys in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public IList<object> Metadata { get; set; }
        /// <summary>
        /// English language documentation for the service element. It can contain HTML markup and Javadoc tags. The first sentence
        /// of the service documentation is a complete sentence that identifies the service by name and summarizes the purpose of
        /// the service. The remaining part of the documentation provides a summary of how to use the operations defined in the
        /// service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
