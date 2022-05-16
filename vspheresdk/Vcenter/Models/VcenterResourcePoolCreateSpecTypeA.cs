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
    public class VcenterResourcePoolCreateSpecTypeA 
    {
        /// <summary>
        /// Name of the resource pool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Parent of the created resource pool.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parent", Required = Required.AllowNull)]
        public string Parent { get; set; }
        /// <summary>
        /// Resource allocation for CPU.
        /// if unset or empty, use the default CPU allocation specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_allocation")]
        public VcenterResourcePoolResourceAllocationCreateSpecTypeA CpuAllocation { get; set; }
        /// <summary>
        /// Resource allocation for memory.
        /// if unset or empty, use the default memory allocation specification.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_allocation")]
        public VcenterResourcePoolResourceAllocationCreateSpecTypeA MemoryAllocation { get; set; }
    }
}
