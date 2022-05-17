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
    public class EsxSettingsClustersSoftwareRecommendationsInfoType 
    {
        /// <summary>
        /// Recommended image specification based on latest base image version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "latest_recommendation")]
        public EsxSettingsSoftwareInfoType LatestRecommendation { get; set; }
        /// <summary>
        /// Recommended image specification based on latest base image patch or update of the current series.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_series_recommendation")]
        public EsxSettingsSoftwareInfoType CurrentSeriesRecommendation { get; set; }
        /// <summary>
        /// Recommended image specification based on a specified base image version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "specified_base_image_version_recommendation")]
        public EsxSettingsSoftwareInfoType SpecifiedBaseImageVersionRecommendation { get; set; }
        /// <summary>
        /// Details about why some base images are excluded in latest and current series recommendations. This is not applicable for
        /// specified base image recommendations.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_image_explanation_details", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareRecommendationsExplanationDetailsType> BaseImageExplanationDetails { get; set; }
        /// <summary>
        /// The most recent timestamp when check for recommended image is launched.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "check_time")]
        public DateTime? CheckTime { get; set; }
    }
}
