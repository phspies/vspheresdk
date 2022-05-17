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
    public class VcenterNamespaceManagementNetworksUpdateType 
    {
        /// <summary>
        /// The network provider that will manage the vSphere Namespaces network object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersNetworkProviderEnumType NetworkProvider { get; set; }
        /// <summary>
        /// Updated configuration specification for a DVPG-backed Namespaces network object, supported by VSPHERE_NETWORK network
        /// provider.
        /// This field is optional and it is only relevant when the value of Networks.UpdateSpec.network-provider is
        /// VSPHERE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_network")]
        public VcenterNamespaceManagementNetworksVsphereDvpgnetworkUpdateSpecType VsphereNetwork { get; set; }
        /// <summary>
        /// Updated configuration specification for a NSXT-backed Namespaces network configuration, supported by
        /// NSXT_CONTAINER_PLUGIN network provider.
        /// This field is optional and it is only relevant when the value of Networks.UpdateSpec.network-provider is
        /// NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_network")]
        public VcenterNamespaceManagementNetworksNsxNetworkUpdateSpecType NsxNetwork { get; set; }
    }
}
