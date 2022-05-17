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
    public class ApplianceVcenterSettingsV1ConfigComponentsManagementclusterDrsConfigType 
    {
        /// <summary>
        /// Flag indicating whether or not DRS service is enabled. Warning: This attribute is available as Technology Preview. These
        /// are early access APIs provided to test, automate and provide feedback on the feature. Since this can change based on
        /// feedback, VMware does not guarantee backwards compatibility and recommends against using them in production
        /// environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Specifies the cluster-wide default DRS behavior for virtual machines. You can override the default behavior for a
        /// virtual machine. Warning: This attribute is available as Technology Preview. These are early access APIs provided to
        /// test, automate and provide feedback on the feature. Since this can change based on feedback, VMware does not guarantee
        /// backwards compatibility and recommends against using them in production environments. Some Technology Preview APIs might
        /// only be applicable to specific environments.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automation_level")]
        public ApplianceVcenterSettingsV1ConfigComponentsManagementclusterDrsConfigDrsBehaviorInfoType AutomationLevel { get; set; }
        /// <summary>
        /// Threshold for generated recommendations. DRS generates only those recommendations that are above the specified
        /// vmotionRate. Ratings vary from 1 to 5. Warning: This attribute is available as Technology Preview. These are early
        /// access APIs provided to test, automate and provide feedback on the feature. Since this can change based on feedback,
        /// VMware does not guarantee backwards compatibility and recommends against using them in production environments. Some
        /// Technology Preview APIs might only be applicable to specific environments.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "migration_threshold")]
        public long? MigrationThreshold { get; set; }
        /// <summary>
        /// Flag that dictates whether DRS Behavior overrides for individual VMs. Warning: This attribute is available as Technology
        /// Preview. These are early access APIs provided to test, automate and provide feedback on the feature. Since this can
        /// change based on feedback, VMware does not guarantee backwards compatibility and recommends against using them in
        /// production environments. Some Technology Preview APIs might only be applicable to specific environments.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "virtual_machine_automation")]
        public bool? VirtualMachineAutomation { get; set; }
    }
}
