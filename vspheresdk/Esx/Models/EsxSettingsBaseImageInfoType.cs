using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsBaseImageInfoType 
    {
        /// <summary>
        /// Details about the base-image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public EsxSettingsBaseImageDetailsType Details { get; set; }
        /// <summary>
        /// Version of the base-image
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
    }
}
