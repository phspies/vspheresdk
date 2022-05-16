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
    public class VcenterVmHardwareCpuUpdateSpecTypeA 
    {
        /// <summary>
        /// New number of CPU cores. The number of CPU cores in the virtual machine must be a multiple of the number of cores per
        /// socket.
        /// The supported range of CPU counts is constrained by the configured guest operating system and virtual hardware version
        /// of the virtual machine.
        /// 
        /// If the virtual machine is running, the number of CPU cores may only be increased if Cpu.Info.hot-add-enabled is true,
        /// and may only be decreased if Cpu.Info.hot-remove-enabled is true.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }
        /// <summary>
        /// New number of CPU cores per socket. The number of CPU cores in the virtual machine must be a multiple of the number of
        /// cores per socket.
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cores_per_socket")]
        public long? CoresPerSocket { get; set; }
        /// <summary>
        /// Flag indicating whether adding CPUs while the virtual machine is running is enabled.
        /// This field may only be modified if the virtual machine is powered off.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hot_add_enabled")]
        public bool? HotAddEnabled { get; set; }
        /// <summary>
        /// Flag indicating whether removing CPUs while the virtual machine is running is enabled.
        /// This field may only be modified if the virtual machine is powered off.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hot_remove_enabled")]
        public bool? HotRemoveEnabled { get; set; }
    }
}
