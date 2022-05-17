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
    public class EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesVcgEntriesKeyType 
    {
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "model", Required = Required.AllowNull)]
        public string Model { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity", Required = Required.AllowNull)]
        public long Capacity { get; set; }
        /// <summary>
        /// storage device part number
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "part_number")]
        public string? PartNumber { get; set; }
        /// <summary>
        /// storage device firmware version
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "firmware_version")]
        public string? FirmwareVersion { get; set; }
    }
}
