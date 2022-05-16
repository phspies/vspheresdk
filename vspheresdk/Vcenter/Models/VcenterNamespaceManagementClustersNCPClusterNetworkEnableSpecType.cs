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
    public class VcenterNamespaceManagementClustersNcpclusterNetworkEnableSpecType 
    {
        /// <summary>
        /// CIDR blocks from which Kubernetes allocates pod IP addresses. This range should not overlap with those in
        /// Clusters.EnableSpec.service-cidr, Clusters.NCPClusterNetworkEnableSpec.ingress-cidrs,
        /// Clusters.NCPClusterNetworkEnableSpec.egress-cidrs, or other services running in the datacenter. All Pod CIDR blocks must
        /// be of at least subnet size /23.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pod_cidrs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> PodCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses for Kubernetes Ingresses and Kubernetes Services of type LoadBalancer.
        /// These ranges should not overlap with those in Clusters.NCPClusterNetworkEnableSpec.pod-cidrs,
        /// Clusters.EnableSpec.service-cidr, Clusters.NCPClusterNetworkEnableSpec.egress-cidrs, or other services running in the
        /// datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ingress_cidrs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> IngressCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses used for performing SNAT from container IPs to external IPs. These
        /// ranges should not overlap with those in Clusters.NCPClusterNetworkEnableSpec.pod-cidrs,
        /// Clusters.EnableSpec.service-cidr, Clusters.NCPClusterNetworkEnableSpec.ingress-cidrs, or other services running in the
        /// datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "egress_cidrs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> EgressCidrs { get; set; }
        /// <summary>
        /// vSphere Distributed Switch used to connect this cluster.
        /// This field is required when configuring a cluster that uses NSX-T. If unset and using NSXe, the system will choose a
        /// suitable vSphere Distributed Switch.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vSphereDistributedSwitch. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: vSphereDistributedSwitch.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_distributed_switch")]
        public string? ClusterDistributedSwitch { get; set; }
        /// <summary>
        /// NSX Edge Cluster to be used for Kubernetes Services of type LoadBalancer, Kubernetes Ingresses, and NSX SNAT.
        /// This field is required when configuring a cluster that uses NSX-T. If unset and using NSXe, the system will choose a
        /// suitable NSX Edge Cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// NSXEdgeCluster. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: NSXEdgeCluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_edge_cluster")]
        public string? NsxEdgeCluster { get; set; }
        /// <summary>
        /// NSX Tier0 Gateway used for this cluster.
        /// This field is required when configuring a cluster that uses NSX-T.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// NSXTier0Gateway. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: NSXTier0Gateway.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_tier0_gateway")]
        public string? NsxTier0Gateway { get; set; }
        /// <summary>
        /// Size of the subnet reserved for namespaces segments.
        /// If unset, defaults to 28.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace_subnet_prefix")]
        public long? NamespaceSubnetPrefix { get; set; }
        /// <summary>
        /// Routed mode for this cluster. When set to True, the traffic in the cluster is not NATed. When this field is set to True,
        /// Clusters.NCPClusterNetworkEnableSpec.egress-cidrs is not allowed.
        /// If unset, defaults to False.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "routed_mode")]
        public bool? RoutedMode { get; set; }
    }
}
