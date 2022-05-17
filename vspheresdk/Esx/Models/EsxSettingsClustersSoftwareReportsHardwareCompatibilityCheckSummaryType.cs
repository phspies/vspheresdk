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
    public class EsxSettingsClustersSoftwareReportsHardwareCompatibilityCheckSummaryType 
    {
        /// <summary>
        /// Overall compliance status of the cluster with respective to all hosts in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public EsxSettingsClustersSoftwareReportsHardwareCompatibilityComplianceStatusEnumType Status { get; set; }
        /// <summary>
        /// HCL Validation check time.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scan_time", Required = Required.AllowNull)]
        public DateTime ScanTime { get; set; }
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
        /// Over all Compliance result for cluster for the software specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary_result", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType SummaryResult { get; set; }
        /// <summary>
        /// Notifications returned by the HCL Validation operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "notifications", Required = Required.AllowNull)]
        public EsxSettingsNotificationsType Notifications { get; set; }
    }
}
