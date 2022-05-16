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
    public class VcenterNamespaceManagementClustersUpdateType 
    {
        /// <summary>
        /// This affects the size and resources allocated to the Kubernetes API server.
        /// If unset, size and resources allocated to Kubernetes API server will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size_hint")]
        public VcenterNamespaceManagementSizingHintType SizeHint { get; set; }
        /// <summary>
        /// Optionally, you can edit the floating IP address that is assigned to the Supervisor Cluster in case the DHCP server
        /// fails during the Supervisor Cluster enablement process. The field is only relevant when the DHCP mode of the Supervisor
        /// Cluster management network is set with Clusters.EnableSpec.master-management-network. Set this floating IP parameter to
        /// remediate a supervisor enablement failure in the case where it was detected that the DHCP server does not support DHCP
        /// client identifiers.
        /// If unset, the existing effective management network floating IP will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "floating_IP")]
        public string? FloatingIP { get; set; }
        /// <summary>
        /// The provider of cluster networking for this vSphere Namespaces cluster.
        /// If unset, the existing effective cluster network specification will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider")]
        public VcenterNamespaceManagementClustersNetworkProviderType NetworkProvider { get; set; }
        /// <summary>
        /// Updated specification for the cluster network configuration.
        /// If unset, the existing effective cluster network specification will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ncp_cluster_network_spec")]
        public VcenterNamespaceManagementClustersNcpclusterNetworkUpdateSpecType NcpClusterNetworkSpec { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use on Kubernetes API server, specified in order of preference.
        /// If set, DNS servers set on Kubernetes API server will be replaced. Otherwise, they will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_DNS")]
        public IList<string> MasterDNS { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use on the worker nodes, specified in order of preference.
        /// If set, DNS servers set on worker nodes will be replaced. Otherwise, they will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "worker_DNS")]
        public IList<string> WorkerDNS { get; set; }
        /// <summary>
        /// List of domains (for example "vmware.com") to be searched when trying to lookup a host name on Kubernetes API server,
        /// specified in order of preference.
        /// If set, DNS search domains on Kubernetes API server will be replaced. Otherwise, they will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_DNS_search_domains")]
        public IList<string> MasterDnssearchDomains { get; set; }
        /// <summary>
        /// List of NTP server DNS names or IP addresses to use on Kubernetes API server, specified in order of preference.
        /// If set, NTP servers on Kubernetes API server will be replaced. Otherwise, they will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_NTP_servers")]
        public IList<string> MasterNtpservers { get; set; }
        /// <summary>
        /// Identifier of storage policy associated with Kubernetes API server.
        /// If unset, storage policy associated with Kubernetes API server will not be modified.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_storage_policy")]
        public string? MasterStoragePolicy { get; set; }
        /// <summary>
        /// Identifier of storage policy associated with ephemeral disks of all the Kubernetes Pods in the cluster.
        /// If unset, storage policy associated with ephemeral disks of all the Kubernetes Pods will not be modified.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// SpsStorageProfile. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: SpsStorageProfile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ephemeral_storage_policy")]
        public string? EphemeralStoragePolicy { get; set; }
        /// <summary>
        /// Specification for configuring Cloud Native Storage file volume support on Supervisor Cluster. This feature provides
        /// support for provisioning ReadWriteMany persistent volumes on this cluster and/or external clusters.
        /// If unset, configuration for file volumes will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cns_file_config")]
        public VcenterNamespaceManagementCnsfileConfigType CnsFileConfig { get; set; }
        /// <summary>
        /// Disclaimer to be displayed prior to login via the Kubectl plugin.
        /// If unset, disclaimer to be displayed prior to login via the Kubectl plugin will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "login_banner")]
        public string? LoginBanner { get; set; }
        /// <summary>
        /// Specification for storage to be used for container images.
        /// If unset, configuration of storage used for container images is not modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_storage")]
        public VcenterNamespaceManagementClustersImageStorageSpecType ImageStorage { get; set; }
        /// <summary>
        /// Default image registry to use when Kubernetes Pod container specification does not specify it as part of the container
        /// image name.
        /// If unset, default image registry will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_image_registry")]
        public VcenterNamespaceManagementClustersImageRegistryType DefaultImageRegistry { get; set; }
        /// <summary>
        /// Default image repository to use when Kubernetes Pod container specification does not specify it as part of the container
        /// image name.
        /// If unset, default image repository will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_image_repository")]
        public string? DefaultImageRepository { get; set; }
        /// <summary>
        /// Certificate issued for Kubernetes API Server. Certificate used must be created by signing the Certificate Signing
        /// Request obtained from the Namespace Certificate Management API. Because a Kubernetes CertificateSigningRequest is
        /// created on an existing Namespaces-enabled cluster, you must use the Clusters.UpdateSpec to specify this
        /// Clusters.UpdateSpec.tls-endpoint-certificate on an existing cluster rather than during initially enabling Namespaces on
        /// a cluster.
        /// If unset, Kubernetes API Server certificate will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tls_endpoint_certificate")]
        public string? TlsEndpointCertificate { get; set; }
        /// <summary>
        /// Identifier of the Content Library which holds the VM Images for vSphere Kubernetes Service. This Content Library should
        /// be subscribed to VMware's hosted vSphere Kubernetes Service Repository. Modifying or clearing the Content Library
        /// identifier will not affect existing vSphere Kubernetes Service clusters. However, upgrades or scale-out of existing
        /// clusters may be affected if the new Content Library doesn't have the necessary VM Images.
        /// If unset, the Content Library will will not be modified.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// content.Library. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: content.Library.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_kubernetes_service_content_library")]
        public string? DefaultKubernetesServiceContentLibrary { get; set; }
        /// <summary>
        /// List of NTP server DNS names or IP addresses to use for workloads such as Tanzu Kubernetes Grid VMs, specified in order
        /// of preference.
        /// If unset, NTP servers for workloads will be unmodified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "workload_ntp_servers")]
        public IList<string> WorkloadNtpServers { get; set; }
        /// <summary>
        /// Proxy configuration that will be applied to the Supervisor Cluster. The proxy should be reachable from the management
        /// network and will be used for image pulling and container traffic exiting out of the Supervisor Cluster. Modifying these
        /// settings will result in a restart of the container runtime. Workloads might fail to pull their images for a short period
        /// of time. There will be no effect on the currently running containers.
        /// If unset no change will be made to the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_proxy_config")]
        public VcenterNamespaceManagementProxyConfigurationType ClusterProxyConfig { get; set; }
    }
}
