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
    public class VcenterNamespaceManagementClusterSizeInfoVmInfoType 
    {
        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "count", Required = Required.AllowNull)]
        public long Count { get; set; }
        /// <summary>
        /// Number of CPU cores per socket.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cores_per_socket", Required = Required.AllowNull)]
        public long CoresPerSocket { get; set; }
        /// <summary>
        /// Memory size, in mebibytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory", Required = Required.AllowNull)]
        public long Memory { get; set; }
        /// <summary>
        /// Overall capacity of the disks in the virtual machine, in mebibytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capacity", Required = Required.AllowNull)]
        public long Capacity { get; set; }
    }
}
