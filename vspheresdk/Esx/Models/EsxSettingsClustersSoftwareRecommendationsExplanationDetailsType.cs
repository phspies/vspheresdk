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
    public class EsxSettingsClustersSoftwareRecommendationsExplanationDetailsType 
    {
        /// <summary>
        /// Display name of an excluded image entity (base image, add-on etc.).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Display version of an excluded image entity (base image, add-on etc.).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version", Required = Required.AllowNull)]
        public string DisplayVersion { get; set; }
        /// <summary>
        /// List of explanations on why the image entity is excluded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "explanation", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> Explanation { get; set; }
    }
}
