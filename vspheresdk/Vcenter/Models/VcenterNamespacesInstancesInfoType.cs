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
    public class VcenterNamespacesInstancesInfoType 
    {
        /// <summary>
        /// Identifier for the vSphere cluster hosting the namespace.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Current setting for Instances.ConfigStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterNamespacesInstancesConfigStatusType ConfigStatus { get; set; }
        /// <summary>
        /// Current set of messages associated with the object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespacesInstancesMessageType> Messages { get; set; }
        /// <summary>
        /// Basic runtime statistics for the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "stats", Required = Required.AllowNull)]
        public VcenterNamespacesInstancesStatsType Stats { get; set; }
        /// <summary>
        /// Description of the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Quotas on the namespace resources. Refer to vcenter.namespace_management.NamespaceResourceOptions#get for the type of
        /// the value for this field.
        /// If unset, no resource constraints are associated with the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_spec")]
        public object ResourceSpec { get; set; }
        /// <summary>
        /// Access controls associated with the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_list", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespacesInstancesAccessType> AccessList { get; set; }
        /// <summary>
        /// Storage associated with the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_specs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespacesInstancesStorageSpecType> StorageSpecs { get; set; }
        /// <summary>
        /// vSphere Networks associated with the namespace.
        /// This field is unset if the cluster hosting this namespace uses NSXT_CONTAINER_PLUGIN as its network provider.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.namespace_management.Network. When operations return a value of this structure as a result, the field will
        /// contain identifiers for the resource type: vcenter.namespace_management.Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// VM Service specification associated with the namespace.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_service_spec")]
        public VcenterNamespacesInstancesVmserviceSpecType VmServiceSpec { get; set; }
        /// <summary>
        /// Creator of the namespace. Namespace self-service uses this field to populate the user who created this namespace.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public VcenterNamespacesInstancesPrincipalType Creator { get; set; }
        /// <summary>
        /// Flag to indicate the self service namespace.
        /// If unset, the namespace is not marked as self service namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "self_service_namespace")]
        public bool? SelfServiceNamespace { get; set; }
    }
}
