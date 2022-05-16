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
    public class VcenterNamespaceManagementClustersNcpclusterNetworkInfoType 
    {
        /// <summary>
        /// CIDR blocks from which Kubernetes allocates pod IP addresses.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pod_cidrs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> PodCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses for Kubernetes Ingresses and Kubernetes Services of type LoadBalancer.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ingress_cidrs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> IngressCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses used for performing SNAT from container IPs to external IPs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "egress_cidrs", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> EgressCidrs { get; set; }
        /// <summary>
        /// vSphere Distributed Switch used to connect this cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vSphereDistributedSwitch. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: vSphereDistributedSwitch.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_distributed_switch", Required = Required.AllowNull)]
        public string ClusterDistributedSwitch { get; set; }
        /// <summary>
        /// NSX Edge Cluster to be used for Kubernetes Services of type LoadBalancer, Kubernetes Ingresses, and NSX SNAT.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// NSXEdgeCluster. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: NSXEdgeCluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_edge_cluster", Required = Required.AllowNull)]
        public string NsxEdgeCluster { get; set; }
        /// <summary>
        /// PEM-encoded x509 certificate used by NSX as a default fallback certificate for Kubernetes Ingress services.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_ingress_tls_certificate", Required = Required.AllowNull)]
        public string DefaultIngressTlsCertificate { get; set; }
        /// <summary>
        /// NSX Tier0 Gateway used for this cluster.
        /// This is set when the cluster uses NSX-T.
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
        /// Routed mode for this cluster.
        /// If unset, defaults to False.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "routed_mode")]
        public bool? RoutedMode { get; set; }
    }
}
