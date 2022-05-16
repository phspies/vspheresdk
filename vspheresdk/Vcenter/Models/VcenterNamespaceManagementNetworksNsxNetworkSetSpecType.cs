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
    public class VcenterNamespaceManagementNetworksNsxNetworkSetSpecType 
    {
        /// <summary>
        /// CIDR blocks from which Kubernetes allocates IP addresses for all workloads that attach to the namespace, including
        /// PodVMs, TKGS and VM Service VMs. Only appending additional Cidr is allowed. Modification to existing Cidr ranges will
        /// result in the operation failing with a ResourceInUse error. Appending invalid Cidr e.g. overlapping or broadcast or
        /// reserved Cidr will result in the operation failing with a InvalidArgument error.
        /// If unset, the current value will be retained.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace_network_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> NamespaceNetworkCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses for Kubernetes Ingresses and Kubernetes Services of type LoadBalancer.
        /// Only appending additional Cidr is allowed. Modification to existing Cidr ranges will result in the operation failing
        /// with a ResourceInUse error. Appending invalid Cidr e.g. overlapping or broadcast or reserved Cidr will result in the
        /// operation failing with a InvalidArgument error.
        /// If unset, the current value will be retained.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ingress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> IngressCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses used for performing SNAT from container IPs to external IPs. Only
        /// appending additional Cidr is allowed. Modification to existing Cidr ranges will result in the operation failing with a
        /// ResourceInUse error. Appending invalid Cidr e.g. overlapping or broadcast or reserved Cidr will result in the operation
        /// failing with a InvalidArgument error.
        /// If unset, the current value will be retained.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "egress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> EgressCidrs { get; set; }
    }
}
