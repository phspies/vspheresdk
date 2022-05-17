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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaFixedSizeSlotPolicyType 
    {
        /// <summary>
        /// The cpu component of the slot size (in MHz)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu", Required = Required.AllowNull)]
        public long Cpu { get; set; }
        /// <summary>
        /// The memory component of the slot size (in megabytes)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory", Required = Required.AllowNull)]
        public long Memory { get; set; }
    }
}
