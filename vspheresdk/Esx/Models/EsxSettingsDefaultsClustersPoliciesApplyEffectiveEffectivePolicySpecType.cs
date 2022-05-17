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
    public class EsxSettingsDefaultsClustersPoliciesApplyEffectiveEffectivePolicySpecType 
    {
        /// <summary>
        /// What action is to be taken if entering maintenance mode fails on a given host of the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failure_action", Required = Required.AllowNull)]
        public EsxSettingsDefaultsClustersPoliciesApplyEffectiveFailureActionType FailureAction { get; set; }
        /// <summary>
        /// Specifies what should be done to the power state of the VM before entering maintenance mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pre_remediation_power_action", Required = Required.AllowNull)]
        public EsxSettingsDefaultsClustersPoliciesApplyEffectiveEffectivePolicySpecPreRemediationPowerActionEnumType PreRemediationPowerAction { get; set; }
        /// <summary>
        /// Enable Quick Boot during remediation in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enable_quick_boot", Required = Required.AllowNull)]
        public bool EnableQuickBoot { get; set; }
        /// <summary>
        /// Disable DPM on the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disable_dpm", Required = Required.AllowNull)]
        public bool DisableDpm { get; set; }
        /// <summary>
        /// Disable HA Admission control on the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disable_hac", Required = Required.AllowNull)]
        public bool DisableHac { get; set; }
        /// <summary>
        /// Evacuate powered off/suspended VMs when attempting maintenance mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "evacuate_offline_vms", Required = Required.AllowNull)]
        public bool EvacuateOfflineVms { get; set; }
        /// <summary>
        /// Enforce Hcl validation, when applicable, to prevent remediation if hardware compatibility issues are found.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enforce_hcl_validation")]
        public bool? EnforceHclValidation { get; set; }
    }
}
