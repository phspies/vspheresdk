using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterContentRegistriesHarborSummaryType 
    {
        /// <summary>
        /// Identifier of the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Identifier of the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "registry", Required = Required.AllowNull)]
        public string Registry { get; set; }
        /// <summary>
        /// Version of the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// URL to access the UI of the registry.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ui_access_url", Required = Required.AllowNull)]
        public string UiAccessUrl { get; set; }
    }
}
