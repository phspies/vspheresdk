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
    public class VcenterVmToolsInfoType 
    {
        /// <summary>
        /// Set if the virtual machine supports auto-upgrading Tools via Tools.UpgradePolicy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_update_supported", Required = Required.AllowNull)]
        public bool AutoUpdateSupported { get; set; }
        /// <summary>
        /// Number of attempts that have been made to install or upgrade the version of Tools installed on this virtual machine.
        /// This field will be unset if there have been no Tools install or upgrade attempt.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "install_attempt_count")]
        public long? InstallAttemptCount { get; set; }
        /// <summary>
        /// Error that happened, if any, during last attempt to upgrade or install Tools.
        /// This field will be unset if a the last Tools install or upgrade attempt succeeded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string? Error { get; set; }
        /// <summary>
        /// Version of VMware Tools installed on the guest operating system.
        /// This field wil be unset if VMWare Tools is not installed. This is an integer constructed as follows: (((MJR) << 10) +
        /// ((MNR) << 5) + (REV)) Where MJR is tha major verson, MNR is the minor version and REV is the revision. Tools version = T
        /// Tools Version Major = MJR = (T / 1024) Tools Version Minor = MNR = ((T % 1024) / 32) Tools Version Revision = BASE = ((T
        /// % 1024) % 32) Tools actual version = MJR.MNR.REV
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version_number")]
        public long? VersionNumber { get; set; }
        /// <summary>
        /// Version of VMware Tools installed on the guest operating system. This is a human-readable value that should not be
        /// parsed.
        /// This field wil be unset if VMWare Tools is not installed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Tools upgrade policy setting for the virtual machine. Tools.UpgradePolicy
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_policy", Required = Required.AllowNull)]
        public VcenterVmToolsUpgradePolicyEnumType UpgradePolicy { get; set; }
        /// <summary>
        /// Current version status of VMware Tools in the guest operating system, if known.
        /// This field will be unset if the version status is not known, for example if VMware Tools is too old to report the
        /// information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version_status")]
        public VcenterVmToolsVersionStatusEnumType VersionStatus { get; set; }
        /// <summary>
        /// Current installation type of VMware Tools in the guest operating system.
        /// This field will be unset if the installation type is not known, for example if VMware Tools is too old to report the
        /// information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "install_type")]
        public VcenterVmToolsToolsInstallTypeEnum InstallType { get; set; }
        /// <summary>
        /// Current run state of VMware Tools in the guest operating system.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "run_state", Required = Required.AllowNull)]
        public VcenterVmToolsRunStateEnumType RunState { get; set; }
    }
}
