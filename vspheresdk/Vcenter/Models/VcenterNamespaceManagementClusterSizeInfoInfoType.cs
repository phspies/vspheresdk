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
    public class VcenterNamespaceManagementClusterSizeInfoInfoType 
    {
        /// <summary>
        /// The maximum number of supported pods.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "num_supported_pods", Required = Required.AllowNull)]
        public long NumSupportedPods { get; set; }
        /// <summary>
        /// The maximum number of supported services.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "num_supported_services", Required = Required.AllowNull)]
        public long NumSupportedServices { get; set; }
        /// <summary>
        /// Default CIDR range from which Kubernetes allocates service cluster IP addresses.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_service_cidr", Required = Required.AllowNull)]
        public VcenterNamespaceManagementIpv4CidrType DefaultServiceCidr { get; set; }
        /// <summary>
        /// Default CIDR range from which Kubernetes allocates pod IP addresses.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_pod_cidr", Required = Required.AllowNull)]
        public VcenterNamespaceManagementIpv4CidrType DefaultPodCidr { get; set; }
        /// <summary>
        /// Information about Kubernetes API server virtual machine configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master_vm_info", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClusterSizeInfoVmInfoType MasterVmInfo { get; set; }
        /// <summary>
        /// Information about worker virtual machine configuration.
        /// If unset, the configuration of the worker VM is not fixed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "worker_vm_info")]
        public VcenterNamespaceManagementClusterSizeInfoVmInfoType WorkerVmInfo { get; set; }
    }
}
