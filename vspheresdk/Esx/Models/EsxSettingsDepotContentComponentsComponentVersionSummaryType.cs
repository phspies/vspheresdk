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
    public class EsxSettingsDepotContentComponentsComponentVersionSummaryType 
    {
        /// <summary>
        /// Version of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// Human readable version of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version", Required = Required.AllowNull)]
        public string DisplayVersion { get; set; }
        /// <summary>
        /// Summary of the component version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary", Required = Required.AllowNull)]
        public string Summary { get; set; }
        /// <summary>
        /// Category of the component version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "category", Required = Required.AllowNull)]
        public EsxSettingsDepotContentComponentsCategoryType Category { get; set; }
        /// <summary>
        /// Urgency of the component version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "urgency", Required = Required.AllowNull)]
        public EsxSettingsDepotContentComponentsUrgencyType Urgency { get; set; }
        /// <summary>
        /// Link to kb article related to this the component version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "kb", Required = Required.AllowNull)]
        public string Kb { get; set; }
        /// <summary>
        /// Release date of the component version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "release_date", Required = Required.AllowNull)]
        public DateTime ReleaseDate { get; set; }
    }
}
