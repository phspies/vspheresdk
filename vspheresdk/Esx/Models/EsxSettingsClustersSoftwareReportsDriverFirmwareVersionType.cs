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
    public class EsxSettingsClustersSoftwareReportsDriverFirmwareVersionType 
    {
        /// <summary>
        /// Driver Version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "driver_version", Required = Required.AllowNull)]
        public string DriverVersion { get; set; }
        /// <summary>
        /// Firmware Version. This will be an empty string if the target firmware version cannot be determined.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "firmware_version", Required = Required.AllowNull)]
        public string FirmwareVersion { get; set; }
        /// <summary>
        /// Driver Name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "driver_name", Required = Required.AllowNull)]
        public string DriverName { get; set; }
    }
}
