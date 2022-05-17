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
    public class VcenterVmHardwareUpdateSpecTypeA 
    {
        /// <summary>
        /// Scheduled upgrade policy.
        /// If set to NEVER, the Hardware.Info.upgrade-version field will be reset to unset.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_policy")]
        public VcenterVmHardwareUpgradePolicyEnumTypeA UpgradePolicy { get; set; }
        /// <summary>
        /// Target hardware version to be used on the next scheduled virtual hardware upgrade.
        /// If specified, this field must represent a newer virtual hardware version than the current virtual hardware version
        /// reported in Hardware.Info.version.
        /// 
        /// If Hardware.UpdateSpec.upgrade-policy is set to NEVER, this field must be unset. Otherwise, if this field is unset,
        /// default to the most recent virtual hardware version supported by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_version")]
        public VcenterVmHardwareVersionEnumTypeA UpgradeVersion { get; set; }
    }
}
