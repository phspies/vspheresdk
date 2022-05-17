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
    public class VcenterVMFilterSpecTypeA 
    {
        /// <summary>
        /// Identifiers of virtual machines that can match the filter.
        /// If unset or empty, virtual machines with any identifier match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// VirtualMachine. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: VirtualMachine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vms")]
        public IList<string> Vms { get; set; }
        /// <summary>
        /// Names that virtual machines must have to match the filter (see VM.Info.name).
        /// If unset or empty, virtual machines with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Folders that must contain the virtual machine for the virtual machine to match the filter.
        /// If unset or empty, virtual machines in any folder match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IList<string> Folders { get; set; }
        /// <summary>
        /// Datacenters that must contain the virtual machine for the virtual machine to match the filter.
        /// If unset or empty, virtual machines in any datacenter match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public IList<string> Datacenters { get; set; }
        /// <summary>
        /// Hosts that must contain the virtual machine for the virtual machine to match the filter.
        /// If unset or empty, virtual machines on any host match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// Clusters that must contain the virtual machine for the virtual machine to match the filter.
        /// If unset or empty, virtual machines in any cluster match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<string> Clusters { get; set; }
        /// <summary>
        /// Resource pools that must contain the virtual machine for the virtual machine to match the filter.
        /// If unset or empty, virtual machines in any resource pool match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pools")]
        public IList<string> ResourcePools { get; set; }
        /// <summary>
        /// Power states that a virtual machine must be in to match the filter (see Power.Info.state.
        /// If unset or empty, virtual machines in any power state match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "power_states")]
        public Dictionary<string,VcenterVmPowerStateEnumTypeA> PowerStates { get; set; }
    }
}
