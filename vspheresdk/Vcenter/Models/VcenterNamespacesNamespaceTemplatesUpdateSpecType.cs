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
    public class VcenterNamespacesNamespaceTemplatesUpdateSpecType 
    {
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
        /// Storage that this template defines and will be associated with a namespace after namespace realization.
        /// If unset then no update will be made.
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
        /// Permissions associated with namespace template.
        /// If unset, only users with the Administrator role can use this template; for example, this template is applied to the
        /// namespace created by self-service-users with the Administrator role.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "permissions")]
        public Dictionary<string,VcenterNamespacesNamespaceTemplatesSubjectType> Permissions { get; set; }
        /// <summary>
        /// VM Service specification to be associated with the namespace template. The virtual machine classes and Content Library
        /// associations of the template will be updated according to the NamespaceTemplates.UpdateSpec.vm-service-spec.
        /// If unset, the virtual machine classes and Content Library associations of the template will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_service_spec")]
        public VcenterNamespacesInstancesVmserviceSpecType VmServiceSpec { get; set; }
    }
}
