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
    public class VapiMetadataMetamodelFieldInfoTypeA 
    {
        /// <summary>
        /// Name of the field element in a canonical format. The format is lower case with underscores. Each underscore represents a
        /// word boundary. If there are acronyms in the word, the capitalization is preserved. This format makes it easy to
        /// translate the segment into a different naming convention.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Type information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VapiMetadataMetamodelTypeA Type { get; set; }
        /// <summary>
        /// Generic metadata elements for the field element. The key in the {@term map} is the name of the metadata element and the
        /// value is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier}
        /// contains possible string values for keys in the {@term map}.
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
