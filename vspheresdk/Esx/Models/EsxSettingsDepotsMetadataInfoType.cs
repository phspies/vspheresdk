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
    public class EsxSettingsDepotsMetadataInfoType 
    {
        /// <summary>
        /// File name of the metadata bundle.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file_name", Required = Required.AllowNull)]
        public string FileName { get; set; }
        /// <summary>
        /// All the base images contained in the metadata bundle.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_images")]
        public Dictionary<string,EsxSettingsDepotsBaseImageVersionType> BaseImages { get; set; }
        /// <summary>
        /// All the addons contained in the metadata bundle. The key is name of addon.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "addons")]
        public Dictionary<string,EsxSettingsDepotsAddonSummaryType>? Addons { get; set; }
        /// <summary>
        /// All the solutions contained in the metadata bundle. The key is name of solution.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "solutions")]
        public Dictionary<string,EsxSettingsDepotsSolutionSummaryType>? Solutions { get; set; }
        /// <summary>
        /// All the HSMs and their HSPs contained in the metadata bundle. The key is name of HSM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardware_support")]
        public Dictionary<string,EsxSettingsDepotsHardwareSupportManagerSummaryType>? HardwareSupport { get; set; }
        /// <summary>
        /// All the independent components contained in the metadata bundle. The components belongs to other base images, addons,
        /// solutions and hardware support packages are not counted. The ksy is name of component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "independent_components")]
        public Dictionary<string,EsxSettingsDepotsComponentSummaryType>? IndependentComponents { get; set; }
        /// <summary>
        /// All the updates (bulletins) contained in the metadata bundle. They key is identifier of the update (bulletin). The value
        /// is summary of the update (bulletin).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "updates")]
        public Dictionary<string,EsxSettingsDepotsUpdateSummaryType>? Updates { get; set; }
    }
}
