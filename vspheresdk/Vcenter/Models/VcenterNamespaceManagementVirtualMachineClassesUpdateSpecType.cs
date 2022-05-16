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
    public class VcenterNamespaceManagementVirtualMachineClassesUpdateSpecType 
    {
        /// <summary>
        /// The number of CPUs configured for virtual machine of this class.
        /// If unset the current value the will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_count")]
        public long? CpuCount { get; set; }
        /// <summary>
        /// The percentage of total available CPUs reserved for a virtual machine. We multiply this percentage by the minimum
        /// frequency amongst all the cluster nodes to get the CPU reservation that is specified to vSphere in MHz.
        /// If unset, no CPU reservation is requested for the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_reservation")]
        public long? CpuReservation { get; set; }
        /// <summary>
        /// The amount of memory in MB configured for virtual machine of this class.
        /// If unset the current value the will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_MB")]
        public long? MemoryMB { get; set; }
        /// <summary>
        /// The percentage of available memory reserved for a virtual machine of this class. Memory reservation must be set to 100%
        /// for VM class with vGPU or Dynamic DirectPath I/O devices.
        /// If unset, no memory reservation is requested for virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_reservation")]
        public long? MemoryReservation { get; set; }
        /// <summary>
        /// Description for the VM class.
        /// If unset, description is not updated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Virtual devices corresponding to the VM class.
        /// If unset, virtual devices will not be updated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public VcenterNamespaceManagementVirtualMachineClassesVirtualDevicesType Devices { get; set; }
    }
}
