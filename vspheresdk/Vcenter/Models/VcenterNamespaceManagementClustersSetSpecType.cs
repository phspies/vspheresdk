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
    public class VcenterNamespaceManagementClustersSetSpecType 
    {
        /// <summary>
        /// This affects the size and resources allocated to the Kubernetes API server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "size_hint", Required = Required.AllowNull)]
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
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersNetworkProviderType NetworkProvider { get; set; }
        /// <summary>
        /// Specification for the NSX Container Plugin cluster network.
        /// This field is optional and it is only relevant when the value of Clusters.SetSpec.network-provider is
        /// NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ncp_cluster_network_spec")]
        public VcenterNamespaceManagementClustersNcpclusterNetworkSetSpecType NcpClusterNetworkSpec { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use on Kubernetes API server, specified in order of preference.
        /// If unset, DNS servers set on Kubernetes API server will be cleared.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_DNS")]
        public IList<string> MasterDNS { get; set; }
        /// <summary>
        /// List of DNS server IP addresses to use on the worker nodes, specified in order of preference.
        /// If unset, DNS servers set on worker nodes will be cleared.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "worker_DNS")]
        public IList<string> WorkerDNS { get; set; }
        /// <summary>
        /// List of domains (for example "vmware.com") to be searched when trying to lookup a host name on Kubernetes API server,
        /// specified in order of preference.
        /// If unset, DNS search domains set on Kubernetes API server will be cleared.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_DNS_search_domains")]
        public IList<string> MasterDnssearchDomains { get; set; }
        /// <summary>
        /// List of NTP server DNS names or IP addresses to use on Kubernetes API server, specified in order of preference.
        /// If unset, VMware Tools based time synchronization is enabled and any set NTP servers are cleared.
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
        /// Specification for configuring Cloud Native Storage file volume support on Supervisor Cluster. This feature provides
        /// support for provisioning ReadWriteMany persistent volumes on this cluster and/or external clusters.
        /// If unset, file volume support will not be enabled on this Supervisor Cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cns_file_config")]
        public VcenterNamespaceManagementCnsfileConfigType CnsFileConfig { get; set; }
        /// <summary>
        /// Disclaimer to be displayed prior to login via the Kubectl plugin.
        /// If unset, disclaimer to be displayed prior to login via the Kubectl plugin will be cleared.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "login_banner")]
        public string? LoginBanner { get; set; }
        /// <summary>
        /// Specification for storage to be used for container images.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "image_storage", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersImageStorageSpecType ImageStorage { get; set; }
        /// <summary>
        /// Default image registry to use when Kubernetes Pod container specification does not specify it as part of the container
        /// image name.
        /// If unset, default image registry will be set to Docker Hub.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_image_registry")]
        public VcenterNamespaceManagementClustersImageRegistryType DefaultImageRegistry { get; set; }
        /// <summary>
        /// Default image repository to use when Kubernetes Pod container specification does not specify it as part of the container
        /// image name.
        /// If unset, default image repository will be set to Docker Hub official repository in case of Docker Hub image registry,
        /// otherwise will be set to empty string.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_image_repository")]
        public string? DefaultImageRepository { get; set; }
        /// <summary>
        /// Identifier of the Content Library which holds the VM Images for vSphere Kubernetes Service. This Content Library should
        /// be subscribed to VMware's hosted vSphere Kubernetes Service Repository. Modifying or clearing the Content Library
        /// identifier will not affect existing vSphere Kubernetes Service clusters. However, upgrades or scale-out of existing
        /// clusters may be affected if the new Content Library doesn't have the necessary VM Images.
        /// If unset, the Content Library identifier will be cleared.
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
        /// If unset, NTP for Kubernetes API servers will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "workload_ntp_servers")]
        public IList<string> WorkloadNtpServers { get; set; }
        /// <summary>
        /// Proxy configuration that will be applied to the Supervisor Cluster. The proxy should be reachable from the management
        /// network and will be used for image pulling and container traffic exiting out of the Supervisor Cluster. Modifying these
        /// settings will result in a restart of the container runtime. Workloads might fail to pull their images for a short period
        /// of time. There will be no effect on the currently running containers.
        /// If unset the settings will be inherited from the vCenter settings if available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_proxy_config")]
        public VcenterNamespaceManagementProxyConfigurationType ClusterProxyConfig { get; set; }
    }
}
