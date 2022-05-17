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
    public class EsxSettingsDepotContentAddOnsVersionsInfoType 
    {
        /// <summary>
        /// Display name of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Vendor of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// Human readable version of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version", Required = Required.AllowNull)]
        public string DisplayVersion { get; set; }
        /// <summary>
        /// Summary of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary", Required = Required.AllowNull)]
        public string Summary { get; set; }
        /// <summary>
        /// Discription of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Category of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public EsxSettingsDepotContentAddOnsVersionsCategoryType Category { get; set; }
        /// <summary>
        /// Link to kb article related to this the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "kb", Required = Required.AllowNull)]
        public string Kb { get; set; }
        /// <summary>
        /// Release date of the OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "release_date", Required = Required.AllowNull)]
        public DateTime ReleaseDate { get; set; }
        /// <summary>
        /// List of components in this OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "components", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsDepotContentAddOnsVersionsComponentInfoType> Components { get; set; }
        /// <summary>
        /// List of components removed by this OEM add-on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "removed_components", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsDepotContentAddOnsVersionsRemovedComponentInfoType> RemovedComponents { get; set; }
    }
}
