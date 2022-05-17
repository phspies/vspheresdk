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
    public class VapiMetadataCliCommandOutputFieldInfoType 
    {
        /// <summary>
        /// Name of the {@term field}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "field_name", Required = Required.AllowNull)]
        public string FieldName { get; set; }
        /// <summary>
        /// Name used by the CLI to display the {@term field}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
    }
}
