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
    public class VcenterNamespaceManagementNetworksNsxNetworkCreateSpecType 
    {
        /// <summary>
        /// CIDR blocks from which Kubernetes allocates IP addresss for all workloads that attach to the namespace, including
        /// PodVMs, TKGS and VM Service VMs. This range should not overlap with those in
        /// Networks.NsxNetworkCreateSpec.ingress-cidrs, Networks.NsxNetworkCreateSpec.egress-cidrs, or other services running in
        /// the datacenter.
        /// This field is required when Networks.NsxNetworkCreateSpec.nsx-tier0-gateway or any of
        /// Networks.NsxNetworkCreateSpec.ingress-cidrs, Networks.NsxNetworkCreateSpec.egress-cidrs are specified. An update
        /// operation only allows for addition of new CIDR blocks to the existing list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace_network_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> NamespaceNetworkCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses for Kubernetes Ingresses and Kubernetes Services of type LoadBalancer.
        /// These ranges should not overlap with those in Networks.NsxNetworkCreateSpec.namespace-network-cidrs,
        /// Networks.NsxNetworkCreateSpec.egress-cidrs, or other services running in the datacenter.
        /// This field is required when Networks.NsxNetworkCreateSpec.nsx-tier0-gateway or any of
        /// Networks.NsxNetworkCreateSpec.namespace-network-cidrs, Networks.NsxNetworkCreateSpec.egress-cidrs is specified. An
        /// update operation only allows for addition of new CIDR blocks to the existing list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ingress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> IngressCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses used for performing SNAT from container IPs to external IPs. These
        /// ranges should not overlap with those in Networks.NsxNetworkCreateSpec.namespace-network-cidrs,
        /// Networks.NsxNetworkCreateSpec.ingress-cidrs, or other services running in the datacenter.
        /// This field is required when Networks.NsxNetworkCreateSpec.routed-mode is set to False and
        /// Networks.NsxNetworkCreateSpec.nsx-tier0-gateway or any of Networks.NsxNetworkCreateSpec.namespace-network-cidrs,
        /// Networks.NsxNetworkCreateSpec.ingress-cidrs is specified. When Networks.NsxNetworkCreateSpec.routed-mode is set to True,
        /// this field is not allowed. An update operation only allows for addition of new CIDR blocks to the existing list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "egress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> EgressCidrs { get; set; }
        /// <summary>
        /// NSX Tier0 Gateway used for the namespace. This field does not allow update once applied.
        /// This field is required when configuring a cluster that uses NSX-T.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// NSXTier0Gateway. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: NSXTier0Gateway.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_tier0_gateway")]
        public string? NsxTier0Gateway { get; set; }
        /// <summary>
        /// Size of the subnet reserved for namespace segments.
        /// If unset, defaults to 28. This field does not allow update once applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnet_prefix_length")]
        public long? SubnetPrefixLength { get; set; }
        /// <summary>
        /// Routed mode for thw namespace. When set to True, the traffic in the namespace is not NATed.
        /// If unset, defaults to False. When this field is set to True, Networks.NsxNetworkCreateSpec.egress-cidrs is not allowed.
        /// This field does not allow update once applied.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "routed_mode")]
        public bool? RoutedMode { get; set; }
        /// <summary>
        /// The size of the NSX Load Balancer used by the namespace. This field does not allow update once applied.
        /// If unset, defaults to SMALL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "load_balancer_size")]
        public VcenterNamespaceManagementNetworksLoadBalancerSizeType LoadBalancerSize { get; set; }
    }
}
