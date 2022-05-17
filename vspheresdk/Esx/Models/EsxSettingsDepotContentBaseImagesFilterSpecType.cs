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
    public class EsxSettingsDepotContentBaseImagesFilterSpecType 
    {
        /// <summary>
        /// Minimum version of a base-image that can match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "min_version")]
        public string? MinVersion { get; set; }
    }
}
