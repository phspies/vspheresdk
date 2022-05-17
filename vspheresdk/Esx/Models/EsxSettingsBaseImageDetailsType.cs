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
    public class EsxSettingsBaseImageDetailsType 
    {
        /// <summary>
        /// Display name of the base-image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Human readable version of the base-image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version", Required = Required.AllowNull)]
        public string DisplayVersion { get; set; }
        /// <summary>
        /// Release date of the base-image.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "release_date", Required = Required.AllowNull)]
        public DateTime ReleaseDate { get; set; }
    }
}
