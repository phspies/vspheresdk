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
    public class VcenterNamespaceManagementClustersWorkloadNetworksInfoType 
    {
        /// <summary>
        /// vSphere Namespaces network used by Kubernetes control plane VMs to access load-balanced services on the various workload
        /// networks.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supervisor_primary_workload_network", Required = Required.AllowNull)]
        public VcenterNamespaceManagementNetworksInfoType SupervisorPrimaryWorkloadNetwork { get; set; }
        /// <summary>
        /// List of vSphere Namespaces networks associated with this cluster.
        /// If unset no additional networks are associated with the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_list")]
        public Dictionary<string,VcenterNamespaceManagementNetworksInfoType> NetworkList { get; set; }
    }
}
