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
    public class VcenterNamespacesInstancesUpdateSpecType 
    {
        /// <summary>
        /// Description for the namespace.
        /// If unset, the description of the namespace will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Resource quota updates on the namespace. Refer to
        /// vcenter.namespace_management.NamespaceResourceOptions.Info#updateResourceQuotaType and use
        /// vcenter.namespace_management.NamespaceResourceOptions#get for retrieving the type for the value for this field. For an
        /// example of this, see ResourceQuotaOptionsV1Update.
        /// If unset, the resource constraints on the namespace will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "resource_spec")]
        public object ResourceSpec { get; set; }
        /// <summary>
        /// Access control associated with the namespace.
        /// If unset, access controls on the namespace will not be modified. Existing pods from users will continue to run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "access_list")]
        public Dictionary<string,VcenterNamespacesInstancesAccessType> AccessList { get; set; }
        /// <summary>
        /// Storage associated with the namespace.
        /// If unset, storage policies and their limit will not be modified. Pods which are already using persistent storage from
        /// the earlier version of storage policies will be able to access them till the datastores are attached to the worker
        /// nodes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "storage_specs")]
        public Dictionary<string,VcenterNamespacesInstancesStorageSpecType> StorageSpecs { get; set; }
        /// <summary>
        /// VM Service specification associated with the namespace.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm_service_spec")]
        public VcenterNamespacesInstancesVmserviceSpecType VmServiceSpec { get; set; }
    }
}
