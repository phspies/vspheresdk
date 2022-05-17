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
    public class VcenterNamespaceManagementClustersEnableSpecType 
    {
        /// <summary>
        /// This affects the size and resources allocated to the Kubernetes API server. It also affects the suggested default
        /// serviceCidr and podCidrs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size_hint", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSizingHintEnumType SizeHint { get; set; }
        /// <summary>
        /// CIDR block from which Kubernetes allocates service cluster IP addresses. This range should not overlap with those in
        /// Clusters.NCPClusterNetworkEnableSpec.pod-cidrs, Clusters.NCPClusterNetworkEnableSpec.ingress-cidrs,
        /// Clusters.NCPClusterNetworkEnableSpec.egress-cidrs, or other services running in the datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service_cidr", Required = Required.AllowNull)]
        public VcenterNamespaceManagementIpv4CidrType ServiceCidr { get; set; }
        /// <summary>
        /// The provider of cluster networking for this vSphere Namespaces cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersNetworkProviderEnumType NetworkProvider { get; set; }
        /// <summary>
        /// Specification for the NSX Container Plugin cluster network.
        /// This field is optional and it is only relevant when the value of Clusters.EnableSpec.network-provider is
        /// NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ncp_cluster_network_spec")]
        public VcenterNamespaceManagementClustersNcpclusterNetworkEnableSpecType NcpClusterNetworkSpec { get; set; }
        /// <summary>
        /// Specification for the workload networks to be associated with the cluster.
        /// This field is optional and it is only relevant when the value of Clusters.EnableSpec.network-provider is
        /// VSPHERE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "workload_networks_spec")]
        public VcenterNamespaceManagementClustersWorkloadNetworksEnableSpecType WorkloadNetworksSpec { get; set; }
        /// <summary>
        /// List of NTP server DNS names or IP addresses to use for workloads such as Tanzu Kubernetes Grid VMs, specified in order
        /// of preference.
        /// If unset, NTP server for Kubernetes API servers will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "workload_ntp_servers")]
        public IList<string> WorkloadNtpServers { get; set; }
        /// <summary>
        /// The load balancer configuration is derived from the user-provisioned load balancer that will be used to operate a load
        /// balancer that fronts vSphere Namespaces cluster servers, Tanzu Kubernetes Grid API servers, and other servers upon
        /// request. This configuration is required for network providers that do not have a default load balancer included.
        /// This field is optional and it is only relevant when the value of Clusters.EnableSpec.network-provider is
        /// VSPHERE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "load_balancer_config_spec")]
        public VcenterNamespaceManagementLoadBalancersConfigSpecType LoadBalancerConfigSpec { get; set; }
        /// <summary>
        /// Specification for the management network on Kubernetes API server. Clusters.NetworkSpec.mode must be STATICRANGE as we
        /// require Kubernetes API server to have a stable address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_management_network", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersNetworkSpecType MasterManagementNetwork { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use on Kubernetes API server, specified in order of preference.
        /// If unset, no default DNS servers are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_DNS")]
        public IList<string> MasterDNS { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use on the worker nodes, specified in order of preference.
        /// If unset, no default DNS servers are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "worker_DNS")]
        public IList<string> WorkerDNS { get; set; }
        /// <summary>
        /// List of domains (for example "vmware.com") to be searched when trying to lookup a host name on Kubernetes API server,
        /// specified in order of preference.
        /// If unset, no default DNS search domains are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_DNS_search_domains")]
        public IList<string> MasterDnssearchDomains { get; set; }
        /// <summary>
        /// List of NTP server DNS names or IP addresses to use on Kubernetes API server, specified in order of preference.
        /// If unset, VMware Tools based time synchronization is enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_NTP_servers")]
        public IList<string> MasterNtpservers { get; set; }
        /// <summary>
        /// Identifier of storage policy associated with Kubernetes API server.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_storage_policy", Required = Required.AllowNull)]
        public string MasterStoragePolicy { get; set; }
        /// <summary>
        /// Identifier of storage policy associated with ephemeral disks of all the Kubernetes Pods in the cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ephemeral_storage_policy", Required = Required.AllowNull)]
        public string EphemeralStoragePolicy { get; set; }
        /// <summary>
        /// Specification for configuring Cloud Native Storage file volume support on Supervisor. This feature provides support for
        /// provisioning ReadWriteMany persistent volumes on this cluster and/or external clusters.
        /// If unset, file volume support will not be enabled on this Supervisor.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cns_file_config")]
        public VcenterNamespaceManagementCnsfileConfigType CnsFileConfig { get; set; }
        /// <summary>
        /// Disclaimer to be displayed prior to login via the Kubectl plugin.
        /// If unset, just skip it.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "login_banner")]
        public string? LoginBanner { get; set; }
        /// <summary>
        /// List of additional DNS names to associate with the Kubernetes API server. These DNS names are embedded in the TLS
        /// certificate presented by the API server.
        /// If unset, no additional DNS names are embedded in the TLS certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "Master_DNS_names")]
        public IList<string> MasterDnsnames { get; set; }
        /// <summary>
        /// Specification for storage to be used for container images.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_storage", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersImageStorageSpecType ImageStorage { get; set; }
        /// <summary>
        /// Default image registry to use when Kubernetes Pod container specification does not specify it as part of the container
        /// image name.
        /// If unset, defaults to Docker Hub.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_image_registry")]
        public VcenterNamespaceManagementClustersImageRegistryType DefaultImageRegistry { get; set; }
        /// <summary>
        /// Default image repository to use when Kubernetes Pod container specification does not specify it as part of the container
        /// image name.
        /// If unset, defaults to Docker Hub official repository in case of Docker Hub image registry, otherwise defaults to empty
        /// string.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_image_repository")]
        public string? DefaultImageRepository { get; set; }
        /// <summary>
        /// Identifier of the Content Library which holds the VM Images for vSphere Kubernetes Service. This Content Library should
        /// be subscribed to VMware's hosted vSphere Kubernetes Service Repository.
        /// If unset, the Content Library will be automatically generated and configured to the cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// content.Library. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: content.Library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_kubernetes_service_content_library")]
        public string? DefaultKubernetesServiceContentLibrary { get; set; }
        /// <summary>
        /// Proxy configuration that will be applied to the Supervisor. The proxy should be reachable from the management network
        /// and will be used for image pulling and container traffic exiting out of the Supervisor.
        /// If unset the settings will be inherited from the vCenter settings if available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_proxy_config")]
        public VcenterNamespaceManagementProxyConfigurationType ClusterProxyConfig { get; set; }
    }
}
