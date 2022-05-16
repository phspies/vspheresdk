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
    public class VcenterNamespacesInstancesStatsType 
    {
        /// <summary>
        /// Overall CPU usage of the namespace, in MHz. This is the sum of CPU usage across all pods in the Kubernetes namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_used", Required = Required.AllowNull)]
        public long CpuUsed { get; set; }
        /// <summary>
        /// Overall memory usage of the namespace (in mebibytes). This is the sum of memory usage across all pods.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_used", Required = Required.AllowNull)]
        public long MemoryUsed { get; set; }
        /// <summary>
        /// Overall storage used by the namespace (in mebibytes). This is the sum of storage used by pods across all datastores in
        /// the cluster associated with storage policies configured for the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_used", Required = Required.AllowNull)]
        public long StorageUsed { get; set; }
    }
}
