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
    public class VcenterNamespaceManagementClustersNcpclusterNetworkUpdateSpecType 
    {
        /// <summary>
        /// CIDR blocks from which Kubernetes allocates pod IP addresses. This range should not overlap with those in
        /// Clusters.EnableSpec.service-cidr, Clusters.NCPClusterNetworkUpdateSpec.ingress-cidrs,
        /// Clusters.NCPClusterNetworkUpdateSpec.egress-cidrs, or other services running in the datacenter. An update operation only
        /// allows for addition of new CIDR blocks to the existing list. All Pod CIDR blocks must be of at least subnet size /23.
        /// If unset, CIDRs from which Kubernetes allocates pod IP addresses will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pod_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> PodCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses for Kubernetes Ingresses and Kubernetes Services of type LoadBalancer.
        /// These ranges should not overlap with those in Clusters.NCPClusterNetworkUpdateSpec.pod-cidrs,
        /// Clusters.EnableSpec.service-cidr, Clusters.NCPClusterNetworkUpdateSpec.egress-cidrs, or other services running in the
        /// datacenter. An update operation only allows for addition of new CIDR blocks to the existing list.
        /// If unset, CIDRs from which Kubernetes allocates ingress IP addresses will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ingress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> IngressCidrs { get; set; }
        /// <summary>
        /// CIDR blocks from which NSX assigns IP addresses used for performing SNAT from container IPs to external IPs. These
        /// ranges should not overlap with those in Clusters.NCPClusterNetworkUpdateSpec.pod-cidrs,
        /// Clusters.EnableSpec.service-cidr, Clusters.NCPClusterNetworkUpdateSpec.ingress-cidrs, or other services running in the
        /// datacenter. An update operation only allows for addition of new CIDR blocks to the existing list.
        /// If unset, CIDR from which Kubernetes allocates egress IP addresses will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "egress_cidrs")]
        public Dictionary<string,VcenterNamespaceManagementIpv4CidrType> EgressCidrs { get; set; }
        /// <summary>
        /// PEM-encoded x509 certificate used by NSX as a default fallback certificate for Kubernetes Ingress services.
        /// If unset, the Kubernetes Ingress services certificate will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_ingress_tls_certificate")]
        public string? DefaultIngressTlsCertificate { get; set; }
    }
}
