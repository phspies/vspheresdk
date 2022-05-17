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
    public class EsxSettingsClustersSoftwareReportsPciDeviceComplianceType 
    {
        /// <summary>
        /// Over all Compliance status of PCI Devices in Cluster with respective to all hosts in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// Compatible Device Compliance result for all devices present on all hosts in the cluster compared with the corresponding
        /// component in the software specification. The key is the DeviceName and value is the PciDeviceComplianceInfo object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible_devices", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsPciDeviceComplianceInfoType> CompatibleDevices { get; set; }
        /// <summary>
        /// Incompatible Device Compliance result for all devices present on all hosts in the cluster compared with the
        /// corresponding component in the software specification. The key is the DeviceName and value is the
        /// PciDeviceComplianceInfo object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "incompatible_devices", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsPciDeviceComplianceInfoType> IncompatibleDevices { get; set; }
        /// <summary>
        /// Incompatible Driver Firmware combination Compliance result for all devices present on hosts in the cluster compared with
        /// the corresponding component in the software specification. The key is the DeviceName and value is the
        /// PciDeviceComplianceInfo object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "incompatible_driver_firmware", Required = Required.AllowNull)]
        public Dictionary<string,EsxSettingsClustersSoftwareReportsPciDeviceComplianceInfoType> IncompatibleDriverFirmware { get; set; }
    }
}
