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
    public class VcenterVMClonePlacementSpecTypeA 
    {
        /// <summary>
        /// Virtual machine folder into which the cloned virtual machine should be placed.
        /// If field is unset, the system will use the virtual machine folder of the source virtual machine. If this results in a
        /// conflict due to other placement parameters, the virtual machine clone operation will fail.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// Resource pool into which the cloned virtual machine should be placed.
        /// If field is unset, the system will use the resource pool of the source virtual machine. If this results in a conflict
        /// due to other placement parameters, the virtual machine clone operation will fail.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool")]
        public string? ResourcePool { get; set; }
        /// <summary>
        /// Host onto which the cloned virtual machine should be placed.
        /// If VM.ClonePlacementSpec.host and VM.ClonePlacementSpec.resource-pool are both specified,
        /// VM.ClonePlacementSpec.resource-pool must belong to VM.ClonePlacementSpec.host.
        /// 
        /// If VM.ClonePlacementSpec.host and VM.ClonePlacementSpec.cluster are both specified, VM.ClonePlacementSpec.host must be a
        /// member of VM.ClonePlacementSpec.cluster.
        /// 
        /// If this field is unset, if VM.ClonePlacementSpec.resource-pool is unset, the cloned virtual machine will use the host of
        /// the source virtual machine. if VM.ClonePlacementSpec.resource-pool is set, and the target is a standalone host, the host
        /// is used. if VM.ClonePlacementSpec.resource-pool is set, and the target is a DRS cluster, a host will be picked by DRS.
        /// if VM.ClonePlacementSpec.resource-pool is set, and the target is a cluster without DRS, InvalidArgument will be thrown.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Cluster into which the cloned virtual machine should be placed.
        /// If VM.ClonePlacementSpec.cluster and VM.ClonePlacementSpec.resource-pool are both specified,
        /// VM.ClonePlacementSpec.resource-pool must belong to VM.ClonePlacementSpec.cluster.
        /// 
        /// If VM.ClonePlacementSpec.cluster and VM.ClonePlacementSpec.host are both specified, VM.ClonePlacementSpec.host must be a
        /// member of VM.ClonePlacementSpec.cluster.
        /// 
        /// If VM.ClonePlacementSpec.resource-pool or VM.ClonePlacementSpec.host is specified, it is recommended that this field be
        /// unset.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Datastore on which the cloned virtual machine's configuration state should be stored. This datastore will also be used
        /// for any virtual disks that are created as part of the virtual machine clone operation unless individually overridden.
        /// If field is unset, the system will use the datastore of the source virtual machine.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
    }
}
