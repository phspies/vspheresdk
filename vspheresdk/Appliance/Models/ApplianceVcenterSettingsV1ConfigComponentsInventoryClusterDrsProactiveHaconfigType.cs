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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsProactiveHaconfigType 
    {
        /// <summary>
        /// Flag indicating whether or not the service is enabled. InfraUpdateHA will not be active, unless DRS is enabled as well.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Configured behavior. Values are of type BehaviorType.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "automation_level")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsProactiveHaconfigBehaviorType AutomationLevel { get; set; }
        /// <summary>
        /// Configured remediation for moderately degraded hosts. Values are of type RemediationType.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "remediation")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsProactiveHaconfigRemediationType Remediation { get; set; }
        /// <summary>
        /// The list of health update providers configured for this cluster. Providers are identified by their id. If the provider
        /// list is empty, InfraUpdateHA will not be active.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "providers")]
        public IList<string> Providers { get; set; }
    }
}
