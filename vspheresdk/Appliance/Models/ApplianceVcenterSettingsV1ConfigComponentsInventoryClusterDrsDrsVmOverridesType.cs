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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDrsVmOverridesType 
    {
        /// <summary>
        /// Reference to the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Specifies the particular DRS behavior for this virtual machine.
        /// If unset or empty, the value is skipped.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "behavior")]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterDrsDrsBehaviorInfoEnumType Behavior { get; set; }
    }
}
