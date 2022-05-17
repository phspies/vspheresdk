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
    public class EsxHostsSoftwareInstalledComponentsInstalledComponentInfoType 
    {
        /// <summary>
        /// Display name of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Version of the installed component
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
    }
}
