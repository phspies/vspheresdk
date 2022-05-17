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
    public class EsxSettingsAddOnInfoType 
    {
        /// <summary>
        /// Details about the add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public EsxSettingsAddOnDetailsType Details { get; set; }
        /// <summary>
        /// Name of the add-on
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Version of the add-on
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
    }
}
