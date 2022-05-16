using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Vcenter.Models.Enums;

namespace vspheresdk.Vcenter.Models
{
    public class VcenterResourcePoolUpdateSpecType 
    {
        /// <summary>
        /// Name of the resource pool.
        /// if unset or empty, the name of the resource pool will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Resource allocation for CPU.
        /// if unset or empty, the CPU allocation of the resource pool will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_allocation")]
        public VcenterResourcePoolResourceAllocationUpdateSpecType CpuAllocation { get; set; }
        /// <summary>
        /// Resource allocation for memory.
        /// if unset or empty, the memory allocation of the resource pool will not be changed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_allocation")]
        public VcenterResourcePoolResourceAllocationUpdateSpecType MemoryAllocation { get; set; }
    }
}
