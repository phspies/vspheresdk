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
    public class VcenterNamespacesNamespaceTemplatesInfoTypeA 
    {
        /// <summary>
        /// Identifier for the vSphere cluster associated with namespace template.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Name of the namespace template.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.NamespaceTemplate. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.NamespaceTemplate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "template", Required = Required.AllowNull)]
        public string Template { get; set; }
        /// <summary>
        /// Resource quotas that this template defines. Quotas on the namespace resources. Refer to
        /// vcenter.namespace_management.NamespaceResourceOptions#get for the type of the value for this field.
        /// If unset, no resource constraints are defined in the namespace template.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_spec")]
        public object ResourceSpec { get; set; }
        /// <summary>
        /// Storage that this template defines and will be associated with a namespace after namespace realization.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_specs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespacesInstancesStorageSpecTypeA> StorageSpecs { get; set; }
        /// <summary>
        /// vSphere Networks that this template captures and are associated with the namespace after namespace realization.
        /// This field is unset if the cluster hosting this namespace uses NSXT_CONTAINER_PLUGIN as its network provider.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.namespace_management.Network. When operations return a value of this structure as a result, the field will
        /// contain identifiers for the resource type: vcenter.namespace_management.Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        public IList<string> Networks { get; set; }
        /// <summary>
        /// Permissions associated with namespace template.
        /// If unset, only users with the Administrator role can use this template; for example, this template is applied to the
        /// namespace created by self-service-users with the Administrator role.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Dictionary<string,VcenterNamespacesNamespaceTemplatesSubjectTypeA> Permissions { get; set; }
        /// <summary>
        /// Current set of virtual machine classes and Content Libraries associated with the template.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_service_spec")]
        public VcenterNamespacesInstancesVMServiceSpecTypeA VmServiceSpec { get; set; }
    }
}
