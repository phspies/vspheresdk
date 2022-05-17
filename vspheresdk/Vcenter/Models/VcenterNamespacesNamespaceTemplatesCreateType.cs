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
    public class VcenterNamespacesNamespaceTemplatesCreateType 
    {
        /// <summary>
        /// Identifier of the namespace template. This has DNS_LABEL restrictions as specified in . This name is unique across all
        /// namespaces templates in this vCenter server.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "template", Required = Required.AllowNull)]
        public string Template { get; set; }
        /// <summary>
        /// Resource quotas that this template defines. Resource quota on the namespace. Refer to
        /// vcenter.namespace_management.NamespaceResourceOptions.Info#createResourceQuotaType and use
        /// vcenter.namespace_management.NamespaceResourceOptions#get for retrieving the type for the value for this field. For an
        /// example of this, see ResourceQuotaOptionsV1.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_spec", Required = Required.AllowNull)]
        public object ResourceSpec { get; set; }
        /// <summary>
        /// Storage that this template defines and will be associated with a namespace after namespace realization. This field
        /// should not be empty and at least one policy should be supplied. The {link create} throws {term InvalidArgument}
        /// exception if this field is set empty.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_specs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespacesInstancesStorageSpecType> StorageSpecs { get; set; }
        /// <summary>
        /// vSphere Networks that this template captures and are associated with the namespace after namespace realization. vSphere
        /// Namespaces network objects to be associated with the namespace. The values of this list need to reference names of
        /// pre-existing vcenter.namespace_management.Networks.Info structures.
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
        /// VM Service specification to be associated with the namespace template. Namespaces created using this template will have
        /// access to the virtual machine classes and Content Libraries specified in the
        /// NamespaceTemplates.CreateSpec.vm-service-spec by default.
        /// If unset, the namespaces created using this template will not have access to any virtual machine classes and Content
        /// Libraries by default.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_service_spec")]
        public VcenterNamespacesInstancesVmserviceSpecType VmServiceSpec { get; set; }
    }
}
