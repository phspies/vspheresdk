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
    public class VcenterVMRelocatePlacementSpecTypeA 
    {
        /// <summary>
        /// Virtual machine folder into which the virtual machine should be placed.
        /// If this field is unset, the virtual machine will stay in the current folder.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// Resource pool into which the virtual machine should be placed.
        /// If this field is unset, the virtual machine will stay in the current resource pool.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool")]
        public string? ResourcePool { get; set; }
        /// <summary>
        /// Host onto which the virtual machine should be placed.
        /// If VM.RelocatePlacementSpec.host and VM.RelocatePlacementSpec.resource-pool are both specified,
        /// VM.RelocatePlacementSpec.resource-pool must belong to VM.RelocatePlacementSpec.host.
        /// 
        /// If VM.RelocatePlacementSpec.host and VM.RelocatePlacementSpec.cluster are both specified, VM.RelocatePlacementSpec.host
        /// must be a member of VM.RelocatePlacementSpec.cluster.
        /// 
        /// If this field is unset, if VM.RelocatePlacementSpec.resource-pool is unset, the virtual machine will remain on the
        /// current host. if VM.RelocatePlacementSpec.resource-pool is set, and the target is a standalone host, the host is used.
        /// if VM.RelocatePlacementSpec.resource-pool is set, and the target is a DRS cluster, a host will be picked by DRS. if
        /// VM.RelocatePlacementSpec.resource-pool is set, and the target is a cluster without DRS, InvalidArgument will be thrown.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Cluster into which the virtual machine should be placed.
        /// If VM.RelocatePlacementSpec.cluster and VM.RelocatePlacementSpec.resource-pool are both specified,
        /// VM.RelocatePlacementSpec.resource-pool must belong to VM.RelocatePlacementSpec.cluster.
        /// 
        /// If VM.RelocatePlacementSpec.cluster and VM.RelocatePlacementSpec.host are both specified, VM.RelocatePlacementSpec.host
        /// must be a member of VM.RelocatePlacementSpec.cluster.
        /// 
        /// If VM.RelocatePlacementSpec.resource-pool or VM.RelocatePlacementSpec.host is specified, it is recommended that this
        /// field be unset.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Datastore on which the virtual machine's configuration state should be stored. This datastore will also be used for any
        /// virtual disks that are associated with the virtual machine, unless individually overridden.
        /// If this field is unset, the virtual machine will remain on the current datastore.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
    }
}
