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
    public class VcenterVmHardwareParallelBackingInfoTypeA 
    {
        /// <summary>
        /// Backing type for the virtual parallel port.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareParallelBackingTypeEnumA Type { get; set; }
        /// <summary>
        /// Path of the file backing the virtual parallel port.
        /// This field is optional and it is only relevant when the value of Parallel.BackingInfo.type is FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public string? File { get; set; }
        /// <summary>
        /// Name of the device backing the virtual parallel port.
        /// 
        /// 
        /// This field will be unset if Parallel.BackingInfo.auto-detect is true and the virtual parallel port is not connected or
        /// no suitable device is available on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual parallel port is configured to automatically detect a suitable host device.
        /// This field is optional and it is only relevant when the value of Parallel.BackingInfo.type is HOST_DEVICE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_detect")]
        public bool? AutoDetect { get; set; }
    }
}
