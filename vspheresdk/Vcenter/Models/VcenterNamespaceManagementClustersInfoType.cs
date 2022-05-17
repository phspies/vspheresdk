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
    public class VcenterNamespaceManagementClustersInfoType 
    {
        /// <summary>
        /// Current setting for SizingHint. This affects the size and resources allocated to the Kubernetes API server.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size_hint")]
        public VcenterNamespaceManagementSizingHintType SizeHint { get; set; }
        /// <summary>
        /// Basic runtime statistics for the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "stat_summary", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersStatsType StatSummary { get; set; }
        /// <summary>
        /// Current setting for Clusters.ConfigStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersConfigStatusType ConfigStatus { get; set; }
        /// <summary>
        /// Current set of messages associated with the object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementClustersMessageType> Messages { get; set; }
        /// <summary>
        /// Current setting for Clusters.KubernetesStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "kubernetes_status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersKubernetesStatusType KubernetesStatus { get; set; }
        /// <summary>
        /// Current set of messages associated with the object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "kubernetes_status_messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementClustersMessageType> KubernetesStatusMessages { get; set; }
        /// <summary>
        /// Kubernetes API Server IP address on the management network. This is a floating IP and assigned to one of the control
        /// plane VMs on the management network. This endpoint is used by vSphere components.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "api_server_management_endpoint", Required = Required.AllowNull)]
        public string ApiServerManagementEndpoint { get; set; }
        /// <summary>
        /// Kubernetes API Server IP address via cluster network. This is the IP address of the Kubernetes LoadBalancer type service
        /// fronting the apiservers. This endpoint is the one configured in kubeconfig after login, and used for most human and
        /// application interaction with Kubernetes.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "api_server_cluster_endpoint", Required = Required.AllowNull)]
        public string ApiServerClusterEndpoint { get; set; }
        /// <summary>
        /// Identifier of the Kubernetes API servers. These are the IP addresses of the VM instances for the Kubernetes control
        /// plane on the management network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "api_servers", Required = Required.AllowNull)]
        public IList<string> ApiServers { get; set; }
        /// <summary>
        /// PEM-encoded x509 certificate used by TLS endpoint on Kubernetes API servers when accessed from the management network,
        /// e.g. from ESX servers or VCSA.
        /// set only when Clusters.Info.api-server-management-endpoint is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tls_management_endpoint_certificate")]
        public string? TlsManagementEndpointCertificate { get; set; }
        /// <summary>
        /// PEM-encoded x509 certificate used by TLS endpoint on Kubernetes API servers when accessed via the load balancer, e.g.
        /// devops user on corporate network.
        /// set only when Clusters.Info.api-server-management-endpoint is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tls_endpoint_certificate")]
        public string? TlsEndpointCertificate { get; set; }
        /// <summary>
        /// The provider of cluster networking for this vSphere Namespaces cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersNetworkProviderType NetworkProvider { get; set; }
        /// <summary>
        /// Specification for the NSX Container Plugin cluster network.
        /// This field is optional and it is only relevant when the value of Clusters.Info.network-provider is
        /// NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ncp_cluster_network_info")]
        public VcenterNamespaceManagementClustersNcpclusterNetworkInfoType NcpClusterNetworkInfo { get; set; }
        /// <summary>
        /// Information about workload networks associated with the cluster.
        /// This field is optional and it is only relevant when the value of Clusters.Info.network-provider is VSPHERE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "workload_networks")]
        public VcenterNamespaceManagementClustersWorkloadNetworksInfoType WorkloadNetworks { get; set; }
        /// <summary>
        /// Information about NTP server DNS names or IP addresses to use for workloads such as Tanzu Kubernetes Grid VMs, specified
        /// in order of preference.
        /// unset when NTP server for Kubernetes API servers is used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "workload_ntp_servers")]
        public IList<string> WorkloadNtpServers { get; set; }
        /// <summary>
        /// Information related to the Load balancer used for provisioning virtual servers in the namespace.
        /// This field is optional and it is only relevant when the value of Clusters.Info.network-provider is VSPHERE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "load_balancers")]
        public Dictionary<string,VcenterNamespaceManagementLoadBalancersInfoType> LoadBalancers { get; set; }
        /// <summary>
        /// CIDR block from which Kubernetes allocates service cluster IP addresses.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service_cidr", Required = Required.AllowNull)]
        public VcenterNamespaceManagementIpv4CidrType ServiceCidr { get; set; }
        /// <summary>
        /// Specification for the management network on Kubernetes API server.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_management_network")]
        public VcenterNamespaceManagementClustersNetworkSpecType MasterManagementNetwork { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use on Kubernetes API server, specified in order of preference.
        /// If unset, no default DNS servers are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_DNS")]
        public IList<string> MasterDNS { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use for pods that execute on the worker nodes (which are native pods on ESXi hosts in
        /// the vSphere Namespaces Supervisor).
        /// If unset, no default DNS servers are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "worker_DNS")]
        public IList<string> WorkerDNS { get; set; }
        /// <summary>
        /// Identifier of storage policy associated with Kubernetes API server.
        /// This field is optional because it was added in a newer version than its parent node.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_storage_policy")]
        public string? MasterStoragePolicy { get; set; }
        /// <summary>
        /// Identifier of storage policy associated with ephemeral disks of all the Kubernetes Pods in the cluster.
        /// This field is optional because it was added in a newer version than its parent node.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ephemeral_storage_policy")]
        public string? EphemeralStoragePolicy { get; set; }
        /// <summary>
        /// Specification for configuring Cloud Native Storage file volume support on Supervisor. This feature provides support for
        /// provisioning ReadWriteMany persistent volumes on this cluster and/or external clusters.
        /// If unset, it means the file volume support is not enabled on this Supervisor.
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
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_storage")]
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
        /// Identifier of the Content Library which holds the VM Images for vSphere Kubernetes Service. This Content Library should
        /// be subscribed to VMware's hosted vSphere Kubernetes Service Repository.
        /// If unset, a default subscribed Content Library will be created. It will sync VMware-supplied images for Tanzu Kubernetes
        /// Grid over the internet.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// content.Library. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: content.Library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_kubernetes_service_content_library")]
        public string? DefaultKubernetesServiceContentLibrary { get; set; }
        /// <summary>
        /// Proxy configuration that is applied to the Supervisor. The proxy should be reachable from the management network and is
        /// used for image pulling and container traffic exiting out of the Supervisor.
        /// Note that the proxy password will be removed from the URLs as per Section 3.2.1 of RFC3986 security recommendation.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_proxy_config")]
        public VcenterNamespaceManagementProxyConfigurationType ClusterProxyConfig { get; set; }
    }
}
