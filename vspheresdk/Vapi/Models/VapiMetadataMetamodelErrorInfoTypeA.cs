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
    public class VapiMetadataMetamodelErrorInfoTypeA 
    {
        /// <summary>
        /// Identifier for the structure element corresponding to the error that is being reported by the operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "structure_id", Required = Required.AllowNull)]
        public string StructureId { get; set; }
        /// <summary>
        /// The English language documentation for the service element. It can contain HTML markup and Javadoc tags.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "documentation", Required = Required.AllowNull)]
        public string Documentation { get; set; }
    }
}
