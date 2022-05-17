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
    public class VcenterVmHardwareParallelBackingSpecTypeA 
    {
        /// <summary>
        /// Backing type for the virtual parallel port.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareParallelBackingTypeEnumA Type { get; set; }
        /// <summary>
        /// Path of the file that should be used as the virtual parallel port backing.
        /// This field is optional and it is only relevant when the value of Parallel.BackingSpec.type is FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public string? File { get; set; }
        /// <summary>
        /// Name of the device that should be used as the virtual parallel port backing.
        /// If unset, the virtual parallel port will be configured to automatically detect a suitable host device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
    }
}
