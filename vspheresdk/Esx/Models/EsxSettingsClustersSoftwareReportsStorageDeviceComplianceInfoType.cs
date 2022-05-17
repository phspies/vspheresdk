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
    public class EsxSettingsClustersSoftwareReportsStorageDeviceComplianceInfoType 
    {
        /// <summary>
        /// Information of the storage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_device_info", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsStorageDeviceInfoType StorageDeviceInfo { get; set; }
        /// <summary>
        /// Compliance status of the storage device. When there are multiple possible VMware Compatibility Guide (VCG) matches for
        /// the storage device, the compliance status would be set to {@link ComplianceStatus#UNAVAILABLE} Each match found would be
        /// listed under {@link StorageDeviceComplianceInfo#matches} with the corresponding compliance status of the storage device
        /// if compared against the constraints specified in the match.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Detailed compliance status of the storage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "detail", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsComplianceStatusDetailEnumType Detail { get; set; }
        /// <summary>
        /// Affected List of Host IDs where this device is found.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_info", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHostInfoType> HostInfo { get; set; }
        /// <summary>
        /// Firmware version on the storage device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "firmware_version")]
        public string? FirmwareVersion { get; set; }
        /// <summary>
        /// Provides information about possible compatibility matches for the given storage device. <p> There could be multiple
        /// possible matches available in the compatibility data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "matches", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsStorageDeviceCompatibilityType> Matches { get; set; }
        /// <summary>
        /// Indicates if the storage device is in use by vSAN. When this flag is set to true, the hardware compatibility is computed
        /// against vSAN HCL constraints.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "used_by_vsan", Required = Required.AllowNull)]
        public bool UsedByVsan { get; set; }
        /// <summary>
        /// Device Specific notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications")]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
