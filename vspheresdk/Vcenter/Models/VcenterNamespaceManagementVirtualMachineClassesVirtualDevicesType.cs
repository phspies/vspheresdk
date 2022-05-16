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
    public class VcenterNamespaceManagementVirtualMachineClassesVirtualDevicesType 
    {
        /// <summary>
        /// List of vGPU devices.
        /// If unset, no vGPU devices are present.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vgpu_devices")]
        public Dictionary<string,VcenterNamespaceManagementVirtualMachineClassesVgpudeviceType> VgpuDevices { get; set; }
        /// <summary>
        /// List of Dynamic DirectPath I/O devices.
        /// If unset, no Dynamic DirectPath I/O devices are present.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dynamic_direct_path_IO_devices")]
        public Dictionary<string,VcenterNamespaceManagementVirtualMachineClassesDynamicDirectPathIodeviceType> DynamicDirectPathIodevices { get; set; }
    }
}
