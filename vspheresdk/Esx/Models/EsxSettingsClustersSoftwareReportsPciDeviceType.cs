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
    public class EsxSettingsClustersSoftwareReportsPciDeviceType 
    {
        /// <summary>
        /// Display name of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Driver Name of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "driver_name", Required = Required.AllowNull)]
        public string DriverName { get; set; }
        /// <summary>
        /// Vendor Name of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vendor", Required = Required.AllowNull)]
        public string Vendor { get; set; }
        /// <summary>
        /// PCI VID of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vid", Required = Required.AllowNull)]
        public string Vid { get; set; }
        /// <summary>
        /// PCI DID of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "did", Required = Required.AllowNull)]
        public string Did { get; set; }
        /// <summary>
        /// PCI SVID of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "svid", Required = Required.AllowNull)]
        public string Svid { get; set; }
        /// <summary>
        /// PCI SSID of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssid", Required = Required.AllowNull)]
        public string Ssid { get; set; }
    }
}
