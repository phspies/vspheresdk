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
    public class VapiMetadataMetamodelOperationResultInfoTypeA 
    {
        /// <summary>
        /// Type information of the operation result element.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VapiMetadataMetamodelTypeA Type { get; set; }
        /// <summary>
        /// Generic metadata elements for the service element. The key in the {@term map} is the name of the metadata element and
        /// the value is the data associated with that metadata element. <p> The {@link vapi.metadata.metamodel.MetadataIdentifier}
        /// contains possible string values for keys in the {@term map}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata", Required = Required.AllowNull)]
        public IList<object> Metadata { get; set; }
        /// <summary>
        /// English language documentation for the operation result element. It can contain HTML markup and Javadoc tags.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
