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
    public class VcenterResourcePoolInfoTypeA 
    {
        /// <summary>
        /// Name of the vCenter Server resource pool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Identifiers of the child resource pools contained in this resource pool.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pools", Required = Required.AllowNull)]
        public IList<string> ResourcePools { get; set; }
        /// <summary>
        /// Resource allocation information for CPU.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_allocation")]
        public VcenterResourcePoolResourceAllocationInfoTypeA CpuAllocation { get; set; }
        /// <summary>
        /// Resource allocation information for memory.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_allocation")]
        public VcenterResourcePoolResourceAllocationInfoTypeA MemoryAllocation { get; set; }
    }
}
