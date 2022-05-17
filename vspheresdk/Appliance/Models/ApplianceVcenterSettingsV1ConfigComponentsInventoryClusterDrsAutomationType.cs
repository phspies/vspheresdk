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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsAutomationType 
    {
        /// <summary>
        /// Specifies the cluster-wide default DRS behavior for virtual machines. You can override the default behavior for a
        /// virtual machine.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automation_level")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDrsBehaviorInfoType AutomationLevel { get; set; }
        /// <summary>
        /// Threshold for generated recommendations. DRS generates only those recommendations that are above the specified
        /// vmotionRate. Ratings vary from 1 to 5.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "migration_threshold")]
        public long? MigrationThreshold { get; set; }
        /// <summary>
        /// Flag indicating whether or not the ProactiveDRS is enabled.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "proactive_drs_enabled")]
        public bool? ProactiveDrsEnabled { get; set; }
        /// <summary>
        /// Flag that dictates whether DRS Behavior overrides for individual VMs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtual_machine_automation")]
        public bool? VirtualMachineAutomation { get; set; }
    }
}
