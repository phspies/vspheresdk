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
    public class VcenterVmHardwareMemoryInfoType 
    {
        /// <summary>
        /// Memory size in mebibytes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size_MiB", Required = Required.AllowNull)]
        public long SizeMiB { get; set; }
        /// <summary>
        /// Flag indicating whether adding memory while the virtual machine is running is enabled.
        /// Some guest operating systems may consume more resources or perform less efficiently when they run on hardware that
        /// supports adding memory while the machine is running.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hot_add_enabled", Required = Required.AllowNull)]
        public bool HotAddEnabled { get; set; }
        /// <summary>
        /// The granularity, in mebibytes, at which memory can be added to a running virtual machine.
        /// When adding memory to a running virtual machine, the amount of memory added must be at least
        /// Memory.Info.hot-add-increment-size-mib and the total memory size of the virtual machine must be a multiple of
        /// {@link>hotAddIncrementSize}.
        /// 
        /// Only set when Memory.Info.hot-add-enabled is true and the virtual machine is running.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hot_add_increment_size_MiB")]
        public long? HotAddIncrementSizeMiB { get; set; }
        /// <summary>
        /// The maximum amount of memory, in mebibytes, that can be added to a running virtual machine.
        /// Only set when Memory.Info.hot-add-enabled is true and the virtual machine is running.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hot_add_limit_MiB")]
        public long? HotAddLimitMiB { get; set; }
    }
}
