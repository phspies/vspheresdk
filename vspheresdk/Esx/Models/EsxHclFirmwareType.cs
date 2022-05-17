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
    public class EsxHclFirmwareType 
    {
        /// <summary>
        /// The version of the firmware.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public string Version { get; set; }
        /// <summary>
        /// The vendor that produced the firmware.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor")]
        public string? Vendor { get; set; }
    }
}
