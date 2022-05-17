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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsPowerManagementType 
    {
        /// <summary>
        /// Flag indicating whether or not the service is enabled. This service can not be enabled, unless DRS is enabled as well.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dpm_enabled")]
        public bool? DpmEnabled { get; set; }
        /// <summary>
        /// Specifies the default VMware DPM behavior for hosts. This default behavior can be overridden on a per host.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automation_level")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDpmBehaviorInfoType AutomationLevel { get; set; }
        /// <summary>
        /// DPM Advanced options.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dpm_threshold")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterOptionValueType DpmThreshold { get; set; }
    }
}
