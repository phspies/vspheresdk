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
    public class ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolResourcePoolSummaryType 
    {
        /// <summary>
        /// Resource allocation information for CPU.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_allocation", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolResourceAllocationInfoType CpuAllocation { get; set; }
        /// <summary>
        /// Resource allocation information for memory.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_allocation", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsInventoryResourcepoolResourceAllocationInfoType MemoryAllocation { get; set; }
    }
}
