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
    public class EsxSettingsComponentInfoType 
    {
        /// <summary>
        /// Version of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Details about the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public EsxSettingsComponentDetailsType Details { get; set; }
    }
}
