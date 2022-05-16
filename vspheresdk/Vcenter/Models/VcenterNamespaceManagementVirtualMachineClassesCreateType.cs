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
    public class VcenterNamespaceManagementVirtualMachineClassesCreateType 
    {
        /// <summary>
        /// Identifier of the virtual machine class. This has DNS_LABEL restrictions as specified in . This must be an alphanumeric
        /// (a-z and 0-9) string and with maximum length of 63 characters and with the '-' character allowed anywhere except the
        /// first or last character. This name is unique in this vCenter server.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.VirtualMachineClass. When operations return a value of this structure as a result, the
        /// field will be an identifier for the resource type: vcenter.namespace_management.VirtualMachineClass.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// The number of CPUs configured for virtual machine of this class.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_count", Required = Required.AllowNull)]
        public long CpuCount { get; set; }
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
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_MB", Required = Required.AllowNull)]
        public long MemoryMB { get; set; }
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
        /// If unset, no description is added to the VM class.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Virtual devices that will be attached to the VMs created with this class.
        /// If unset, no Virtual device will be attached to the VMs created with this class.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public VcenterNamespaceManagementVirtualMachineClassesVirtualDevicesType Devices { get; set; }
    }
}
