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
    public class EsxSettingsDepotsComponentSummaryType 
    {
        /// <summary>
        /// Human readable name of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Different versions of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "versions", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsDepotsComponentVersionType> Versions { get; set; }
    }
}
