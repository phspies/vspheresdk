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
    public class VcenterNamespacesInstancesCreateType 
    {
        /// <summary>
        /// Identifier of the cluster on which the namespace is being created.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Identifier of the namespace. This has DNS_LABEL restrictions as specified in . This must be an alphanumeric (a-z and
        /// 0-9) string and with maximum length of 63 characters and with the '-' character allowed anywhere except the first or
        /// last character. This name is unique across all Namespaces in this vCenter server. In this version, this maps to the name
        /// of a Kubernetes namespace.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace", Required = Required.AllowNull)]
        public string NamespaceProperty { get; set; }
        /// <summary>
        /// Description for the namespace.
        /// If unset, no description is added to the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Resource quota on the namespace. Refer to
        /// vcenter.namespace_management.NamespaceResourceOptions.Info#createResourceQuotaType and use
        /// vcenter.namespace_management.NamespaceResourceOptions#get for retrieving the type for the value for this field. For an
        /// example of this, see ResourceQuotaOptionsV1.
        /// If unset, no resource limits will be set on the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_spec")]
        public object ResourceSpec { get; set; }
        /// <summary>
        /// Access controls associated with the namespace.
        /// If unset, only users with Administrator role can access the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_list")]
        public Dictionary<string,VcenterNamespacesInstancesAccessType> AccessList { get; set; }
        /// <summary>
        /// Storage associated with the namespace.
        /// If unset, storage policies will not be associated with the namespace which will prevent users from being able to
        /// provision pods with persistent storage on the namespace. Users will be able to provision pods which use local storage.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_specs")]
        public Dictionary<string,VcenterNamespacesInstancesStorageSpecType> StorageSpecs { get; set; }
        /// <summary>
        /// vSphere Namespaces network objects to be associated with the namespace. The values of this list need to reference names
        /// of pre-existing vcenter.namespace_management.Networks.Info structures.
        /// The field must be left unset if the cluster hosting the namespace uses NSXT_CONTAINER_PLUGIN as the network provider,
        /// since the network(s) for this namespace will be managed by NSX-T Container Plugin. If field is unset when the cluster
        /// hosting the namespace uses VSPHERE_NETWORK as its network provider, the namespace will automatically be associated with
        /// the cluster's Supervisor Primary Workload Network. The field currently accepts at most only 1 vSphere Namespaces network
        /// object reference.
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
        /// This field that accepts parameters to define a vSphere Namespace Network object that will automatically be associated
        /// with this Namespace. Networks created in this operation will be given an autogenerated ID and cannot be referenced by
        /// other Namespaces.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace_network")]
        public VcenterNamespacesInstancesNetworkCreateSpecType NamespaceNetwork { get; set; }
    }
}
