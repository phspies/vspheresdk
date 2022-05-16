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
    public class VcenterNamespacesNamespaceSelfServiceActivateWithTemplateType 
    {
        /// <summary>
        /// Identifier of the namespace template that is being activated.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.NamespaceTemplate. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.NamespaceTemplate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "template", Required = Required.AllowNull)]
        public string Template { get; set; }
        /// <summary>
        /// Namespace Self Service permission to subjects.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespacesNamespaceTemplatesSubjectType> Permissions { get; set; }
        /// <summary>
        /// Resource quotas that the template defines. Resource quota on the namespace. Refer to
        /// vcenter.namespace_management.NamespaceResourceOptions.Info#createResourceQuotaType and use
        /// vcenter.namespace_management.NamespaceResourceOptions#get for retrieving the type for the value for this field. For an
        /// example of this, see ResourceQuotaOptionsV1.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_spec", Required = Required.AllowNull)]
        public object ResourceSpec { get; set; }
        /// <summary>
        /// Storage associated with the self service namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_specs", Required = Required.AllowNull)]
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
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
    }
}
