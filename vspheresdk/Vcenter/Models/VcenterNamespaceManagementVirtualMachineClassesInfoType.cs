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
    public class VcenterNamespaceManagementVirtualMachineClassesInfoType 
    {
        /// <summary>
        /// Identifier for the VM class.
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
        /// The percentage of available memory reserved for a virtual machine of this class.
        /// If unset, no memory reservation is requested for virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_reservation")]
        public long? MemoryReservation { get; set; }
        /// <summary>
        /// Description of the VM class.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Set of Namespaces associated with this VM class.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaces", Required = Required.AllowNull)]
        public IList<string> Namespaces { get; set; }
        /// <summary>
        /// Set of virtual machines deployed for VM class.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// VirtualMachine. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: VirtualMachine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vms", Required = Required.AllowNull)]
        public IList<string> Vms { get; set; }
        /// <summary>
        /// Configstatus of VM class
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementVirtualMachineClassesConfigStatusEnumType ConfigStatus { get; set; }
        /// <summary>
        /// Current set of messages associated with the object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementVirtualMachineClassesMessageType> Messages { get; set; }
        /// <summary>
        /// Virtual devices corresponding to the VM class.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices")]
        public VcenterNamespaceManagementVirtualMachineClassesVirtualDevicesType Devices { get; set; }
    }
}
