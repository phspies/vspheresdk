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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryClusterHaClusterResourcePercentageType 
    {
        /// <summary>
        /// Reserved failover CPU capacity
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu", Required = Required.AllowNull)]
        public long Cpu { get; set; }
        /// <summary>
        /// Reserved failover Memory capacity
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory", Required = Required.AllowNull)]
        public long Memory { get; set; }
    }
}
