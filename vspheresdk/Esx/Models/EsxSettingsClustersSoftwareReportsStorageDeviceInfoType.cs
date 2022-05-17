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
    public class EsxSettingsClustersSoftwareReportsStorageDeviceInfoType 
    {
        /// <summary>
        /// Storage device model
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "model", Required = Required.AllowNull)]
        public string Model { get; set; }
        /// <summary>
        /// Storage device vendor
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// Hardware part number of the storage device
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "part_number")]
        public string? PartNumber { get; set; }
        /// <summary>
        /// Capacity of the storage device in bytes
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity", Required = Required.AllowNull)]
        public long Capacity { get; set; }
    }
}
