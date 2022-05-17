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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsAdditionalOptionsType 
    {
        /// <summary>
        /// Drs configuration additional options
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "advanced_options")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterOptionValueType> AdvancedOptions { get; set; }
        /// <summary>
        /// Enable scalable shares for the resource pools on this cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scalable_shares")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsScaleSharesBehaviorType ScalableShares { get; set; }
    }
}
