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
    public class EsxSettingsSolutionComponentDetailsType 
    {
        /// <summary>
        /// Identifier of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "component", Required = Required.AllowNull)]
        public string Component { get; set; }
        /// <summary>
        /// Display name of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Human readable version of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_version")]
        public string? DisplayVersion { get; set; }
        /// <summary>
        /// Vendor of the component.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
    }
}
