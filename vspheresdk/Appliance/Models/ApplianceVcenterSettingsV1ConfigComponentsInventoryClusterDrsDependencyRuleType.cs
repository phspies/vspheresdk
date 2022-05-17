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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDependencyRuleType 
    {
        /// <summary>
        /// Flag to indicate whether or not the rule is currently satisfied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsStatusType Status { get; set; }
        /// <summary>
        /// Flag to indicate whether or not the rule is enabled. Set this property when user configures the rule. The default value
        /// is false (disabled). If there is a rule conflict, the Server can override the setting to disable a rule.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Flag to indicate if the rule is in compliance.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "in_compliance")]
        public bool? InCompliance { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Flag to indicate whether compliance with this rule is mandatory or optional. The default value is false (optional).
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mandatory")]
        public bool? Mandatory { get; set; }
        /// <summary>
        /// Flag to indicate whether the rule is created by the user or the system.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_created")]
        public bool? UserCreated { get; set; }
        /// <summary>
        /// Virtual group name. The virtual group may contain one or more virtual machines.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_group")]
        public string? VmGroup { get; set; }
        /// <summary>
        /// Depdendency virtual group name. The virtual group may contain one or more virtual machines.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "depends_on_vm_group")]
        public string? DependsOnVmGroup { get; set; }
    }
}
