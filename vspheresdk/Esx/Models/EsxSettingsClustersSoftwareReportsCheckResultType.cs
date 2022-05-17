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
    public class EsxSettingsClustersSoftwareReportsCheckResultType 
    {
        /// <summary>
        /// Overall compliance status of Cluster with respective to all hosts in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// HCL Validation check time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scan_time", Required = Required.AllowNull)]
        public DateTime ScanTime { get; set; }
        /// <summary>
        /// Flag to indicate if there were any hardware compatibility overrides were performed after the last check {@term
        /// operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "updated_since_last_check")]
        public bool? UpdatedSinceLastCheck { get; set; }
        /// <summary>
        /// HCL Validation Computed only for vSAN Clusters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "v_san_data_only")]
        public bool? VSanDataOnly { get; set; }
        /// <summary>
        /// Spec Identifier of the desired configuration on which the HCL scan is performed to generate this result, populated by
        /// the HCL validation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "commit")]
        public string? Commit { get; set; }
        /// <summary>
        /// Target base image version E.g., version = BaseImageSpec->Version {@link esx.settings.BaseImageSpec#version} {@term
        /// structure}
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "base_image_version", Required = Required.AllowNull)]
        public string BaseImageVersion { get; set; }
        /// <summary>
        /// Compliance result for the Pci Devices that are present in all hosts of the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_device_compliance")]
        public EsxSettingsClustersSoftwareReportsPciDeviceComplianceType PciDeviceCompliance { get; set; }
        /// <summary>
        /// Compliance result for storage devices in all the hosts of the cluster. Currently only includes  SAS/SATA storage
        /// devices.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_device_compliance")]
        public EsxSettingsClustersSoftwareReportsStorageDeviceComplianceType StorageDeviceCompliance { get; set; }
        /// <summary>
        /// Notifications returned by the HCL Validation operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
        /// <summary>
        /// Localizable disclaimer notice to show on the UI detailing the type of checks are done by the HCL Validaiton. Example :
        /// HCL Validation is only done on storage and network controllers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "note", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Note { get; set; }
    }
}
