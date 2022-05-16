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
    public class VcenterNamespaceManagementClustersStatsType 
    {
        /// <summary>
        /// Overall CPU usage of the cluster, in MHz. This is the sum of CPU usage across all worker nodes in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_used", Required = Required.AllowNull)]
        public long CpuUsed { get; set; }
        /// <summary>
        /// Total CPU capacity in the cluster available for vSphere Namespaces, in MHz. This is the sum of CPU capacities from all
        /// worker nodes in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_capacity", Required = Required.AllowNull)]
        public long CpuCapacity { get; set; }
        /// <summary>
        /// Overall memory usage of the cluster, in mebibytes. This is the sum of memory usage across all worker nodes in the
        /// cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_used", Required = Required.AllowNull)]
        public long MemoryUsed { get; set; }
        /// <summary>
        /// Total memory capacity of the cluster available for vSphere Namespaces, in mebibytes. This is the sum of memory
        /// capacities from all worker nodesin the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_capacity", Required = Required.AllowNull)]
        public long MemoryCapacity { get; set; }
        /// <summary>
        /// Overall storage used by the cluster, in mebibytes. This is the sum of storage used across all worker nodes in the
        /// cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_used", Required = Required.AllowNull)]
        public long StorageUsed { get; set; }
        /// <summary>
        /// Overall storage capacity of the cluster available for vSphere Namespaces, in mebibytes. This is the sum of total storage
        /// available from all worker nodes in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_capacity", Required = Required.AllowNull)]
        public long StorageCapacity { get; set; }
    }
}
