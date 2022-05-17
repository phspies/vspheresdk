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
    public class EsxSettingsClustersSoftwareRecommendationsGenerateTaskType 
    {
        /// <summary>
        /// Base image version string is used in generating the specified base image recommendations. Default recommendations are
        /// generated when the value is empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_image_version")]
        public string? BaseImageVersion { get; set; }
    }
}
