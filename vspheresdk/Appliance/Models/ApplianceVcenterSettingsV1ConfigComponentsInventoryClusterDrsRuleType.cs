using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsRuleType 
    {
        /// <summary>
        /// Cluster-wide VM affinity rules.If this is set then AntiAffinityRule, DependencyRule, VmHostRule can not be set.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_affinity_rules")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsAffinityRuleType> VmAffinityRules { get; set; }
        /// <summary>
        /// Cluster-wide VM anti affinity rules.If this is set then AntiAffinityRule, DependencyRule, VmHostRule can not be set.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_anti_affinity_rules")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsAffinityRuleType> VmAntiAffinityRules { get; set; }
        /// <summary>
        /// Cluster-wide VM-to-VM dependency rules.If this is set then AffinityRule, AntiAffinityRule, VmHostRule can not be set.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dependency_rule")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDependencyRuleType> DependencyRule { get; set; }
        /// <summary>
        /// Cluster-wide VM-to-Host affinity rules.If this is set then AffinityRule, AntiAffinityRule, DependencyRule can not be
        /// set.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_host_rule")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsVmHostRuleType> VmHostRule { get; set; }
    }
}
