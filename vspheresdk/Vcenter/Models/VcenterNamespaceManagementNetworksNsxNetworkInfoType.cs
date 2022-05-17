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
    public class VcenterNamespaceManagementNetworksNsxNetworkInfoType 
    {
        /// <summary>
        /// CIDR blocks from which Kubernetes allocates IP addresses for all workloads that attach to the namespace, including
        /// PodVMs, TKGS and VM Service VMs.
        /// If unset, cluster level settings specified in Clusters.NCPClusterNetworkInfo.pod-cidrs will be applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace_network_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> NamespaceNetworkCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses for Kubernetes Ingresses and Kubernetes Services of type LoadBalancer.
        /// If unset, cluster level settings specified in Clusters.NCPClusterNetworkInfo.ingress-cidrs will be applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ingress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> IngressCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses used for performing SNAT from container IPs to external IPs.
        /// If unset, cluster level settings specified in Clusters.NCPClusterNetworkInfo.egress-cidrs will be applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "egress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> EgressCidrs { get; set; }
        /// <summary>
        /// NSX Tier0 Gateway used for this namespace.
        /// If unset, cluster level settings specified in Clusters.NCPClusterNetworkInfo.nsx-tier0-gateway will be applied.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// NSXTier0Gateway. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: NSXTier0Gateway.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_tier0_gateway")]
        public string? NsxTier0Gateway { get; set; }
        /// <summary>
        /// Size of the subnet reserved for namespace segments
        /// If unset, cluster level settings specified in Clusters.NCPClusterNetworkInfo.namespace-subnet-prefix will be applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnet_prefix_length")]
        public long? SubnetPrefixLength { get; set; }
        /// <summary>
        /// Routed mode for this namespace. When set to True, the traffic in the namespace is not NATed.
        /// If unset, cluster level settings specified in Clusters.NCPClusterNetworkInfo.routed-mode will be applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "routed_mode")]
        public bool? RoutedMode { get; set; }
        /// <summary>
        /// The size of the NSX Load Balancer used by the namespace.
        /// If unset, then SMALL is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "load_balancer_size")]
        public VcenterNamespaceManagementNetworksLoadBalancerSizeEnumType LoadBalancerSize { get; set; }
    }
}
