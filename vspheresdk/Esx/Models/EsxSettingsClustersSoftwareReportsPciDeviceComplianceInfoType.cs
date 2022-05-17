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
    public class EsxSettingsClustersSoftwareReportsPciDeviceComplianceInfoType 
    {
        /// <summary>
        /// Compliance status of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Pci Device Details
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "device", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsPciDeviceType Device { get; set; }
        /// <summary>
        /// List of vSphere Versions compatible for this device. This field is populated only for device found INCOMPATIBLE
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible_versions", Required = Required.AllowNull)]
        public IList<string> CompatibleVersions { get; set; }
        /// <summary>
        /// Affected List of Host IDs where this device is found.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_info", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsHostInfoType> HostInfo { get; set; }
        /// <summary>
        /// Driver and Firmware Version from Image Specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsDriverFirmwareVersionType Target { get; set; }
        /// <summary>
        /// List of Supported Driver and Firmware Version combination from Harware Compatibility List.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supported", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsDriverFirmwareVersionType> Supported { get; set; }
        /// <summary>
        /// Provides link to the VMware Compatibility Guide for further information on the compatibility.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatibility_guide_link")]
        public string? CompatibilityGuideLink { get; set; }
        /// <summary>
        /// Device Specific notifications describing the compliance result.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications")]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
