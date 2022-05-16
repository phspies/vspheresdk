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
    public class VcenterVmHardwareCpuInfoType 
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
        /// Flag indicating whether adding CPUs while the virtual machine is running is enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hot_add_enabled", Required = Required.AllowNull)]
        public bool HotAddEnabled { get; set; }
        /// <summary>
        /// Flag indicating whether removing CPUs while the virtual machine is running is enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hot_remove_enabled", Required = Required.AllowNull)]
        public bool HotRemoveEnabled { get; set; }
    }
}
