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
    public class EsxSettingsDepotsUpdateSummaryType 
    {
        /// <summary>
        /// Summary of the update (bulletin).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary", Required = Required.AllowNull)]
        public string Summary { get; set; }
    }
}
