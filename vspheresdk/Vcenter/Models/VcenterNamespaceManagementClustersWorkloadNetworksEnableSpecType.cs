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
    public class VcenterNamespaceManagementClustersWorkloadNetworksEnableSpecType 
    {
        /// <summary>
        /// The Networks#CreateSpec of the vSphere Namespaces network that will be used by Kubernetes control plane VMs to expose
        /// Kubernetes API server to devops users and other workloads. It can also used as backing network for Tanzu Kubernetes
        /// Cluster VMs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "supervisor_primary_workload_network", Required = Required.AllowNull)]
        public VcenterNamespaceManagementNetworksCreateType SupervisorPrimaryWorkloadNetwork { get; set; }
        /// <summary>
        /// Networks#CreateSpec structurees for additional list of vSphere Namespaces networks to be associated with this cluster.
        /// If unset no additional networks will be associated with the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_list")]
        public Dictionary<string,VcenterNamespaceManagementNetworksCreateType> NetworkList { get; set; }
    }
}
