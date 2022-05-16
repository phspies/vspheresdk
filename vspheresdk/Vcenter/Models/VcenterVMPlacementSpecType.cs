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
    public class VcenterVmplacementSpecType 
    {
        /// <summary>
        /// Virtual machine folder into which the virtual machine should be placed.
        /// This field is currently required. In the future, if this field is unset, the system will attempt to choose a suitable
        /// folder for the virtual machine; if a folder cannot be chosen, the virtual machine creation operation will fail.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folder")]
        public string? Folder { get; set; }
        /// <summary>
        /// Resource pool into which the virtual machine should be placed.
        /// This field is currently required if both VM.ComputePlacementSpec.host and VM.ComputePlacementSpec.cluster are unset. In
        /// the future, if this field is unset, the system will attempt to choose a suitable resource pool for the virtual machine;
        /// if a resource pool cannot be chosen, the virtual machine creation operation will fail.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ResourcePool. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: ResourcePool.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_pool")]
        public string? ResourcePool { get; set; }
        /// <summary>
        /// Host onto which the virtual machine should be placed.
        /// If VM.ComputePlacementSpec.host and VM.ComputePlacementSpec.resource-pool are both specified,
        /// VM.ComputePlacementSpec.resource-pool must belong to VM.ComputePlacementSpec.host.
        /// 
        /// If VM.ComputePlacementSpec.host and VM.ComputePlacementSpec.cluster are both specified, VM.ComputePlacementSpec.host
        /// must be a member of VM.ComputePlacementSpec.cluster.
        /// 
        /// This field may be unset if VM.ComputePlacementSpec.resource-pool or VM.ComputePlacementSpec.cluster is specified. If
        /// unset, the system will attempt to choose a suitable host for the virtual machine; if a host cannot be chosen, the
        /// virtual machine creation operation will fail.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// Cluster into which the virtual machine should be placed.
        /// If VM.ComputePlacementSpec.cluster and VM.ComputePlacementSpec.resource-pool are both specified,
        /// VM.ComputePlacementSpec.resource-pool must belong to VM.ComputePlacementSpec.cluster.
        /// 
        /// If VM.ComputePlacementSpec.cluster and VM.ComputePlacementSpec.host are both specified, VM.ComputePlacementSpec.host
        /// must be a member of VM.ComputePlacementSpec.cluster.
        /// 
        /// If VM.ComputePlacementSpec.resource-pool or VM.ComputePlacementSpec.host is specified, it is recommended that this field
        /// be unset.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// Datastore on which the virtual machine's configuration state should be stored. This datastore will also be used for any
        /// virtual disks that are created as part of the virtual machine creation operation.
        /// This field is currently required. In the future, if this field is unset, the system will attempt to choose suitable
        /// storage for the virtual machine; if storage cannot be chosen, the virtual machine creation operation will fail.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Datastore. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: Datastore.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datastore")]
        public string? Datastore { get; set; }
    }
}
