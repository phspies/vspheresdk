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
    public class VapiMetadataCliCommandOutputInfoType 
    {
        /// <summary>
        /// Name of the {@term structure}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "structure_id", Required = Required.AllowNull)]
        public string StructureId { get; set; }
        /// <summary>
        /// The order in which the {@term fields} of the {@term structure} will be displayed by the CLI as well as the names used to
        /// display the {@term fields}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "output_fields", Required = Required.AllowNull)]
        public Dictionary<string,VapiMetadataCliCommandOutputFieldInfoType> OutputFields { get; set; }
    }
}
