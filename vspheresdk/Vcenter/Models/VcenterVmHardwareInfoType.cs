using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterVmHardwareInfoType 
    {
        /// <summary>
        /// Virtual hardware version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public VcenterVmHardwareVersionEnumType Version { get; set; }
        /// <summary>
        /// Scheduled upgrade policy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_policy", Required = Required.AllowNull)]
        public VcenterVmHardwareUpgradePolicyEnumType UpgradePolicy { get; set; }
        /// <summary>
        /// Target hardware version to be used on the next scheduled virtual hardware upgrade.
        /// This field is optional and it is only relevant when the value of Hardware.Info.upgrade-policy is one of
        /// AFTER_CLEAN_SHUTDOWN or ALWAYS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_version")]
        public VcenterVmHardwareVersionEnumType UpgradeVersion { get; set; }
        /// <summary>
        /// Scheduled upgrade status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_status", Required = Required.AllowNull)]
        public VcenterVmHardwareUpgradeStatusEnumType UpgradeStatus { get; set; }
        /// <summary>
        /// Reason for the scheduled upgrade failure.
        /// This field is optional and it is only relevant when the value of Hardware.Info.upgrade-status is FAILED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_error")]
        public string? UpgradeError { get; set; }
    }
}
