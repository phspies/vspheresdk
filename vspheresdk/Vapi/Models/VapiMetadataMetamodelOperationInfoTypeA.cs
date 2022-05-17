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
    public class VapiMetadataMetamodelOperationInfoTypeA 
    {
        /// <summary>
        /// Name of the operation element in a canonical format. The format is lower case with underscores. Each underscore
        /// represents a word boundary. If there are acronyms in the word, the capitalization is preserved. This format makes it
        /// easy to translate the segment into a different naming convention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Metamodel information for the parameter elements. The order of the parameters elements in the list is same as the order
        /// of the parameters declared in the interface definition file.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "params", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelFieldInfoTypeA> Params { get; set; }
        /// <summary>
        /// Metamodel type for the output element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "output", Required = Required.AllowNull)]
        public VapiMetadataMetamodelOperationResultInfoTypeA Output { get; set; }
        /// <summary>
        /// List of error elements that might be reported by the operation element. If the operation reports the same error for more
        /// than one reason, the list contains the error element associated with the error more than once with different
        /// documentation elements.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataMetamodelErrorInfoTypeA> Errors { get; set; }
        /// <summary>
        /// Generic metadata elements for the operation element. The key in the {@term map} is the name of the metadata element and
        /// the value is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier}
        /// contains possible string values for key in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public IList<object> Metadata { get; set; }
        /// <summary>
        /// English language documentation for the service element. It can contain HTML markup and Javadoc tags.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
