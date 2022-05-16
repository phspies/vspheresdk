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
    public class VcenterNamespaceManagementNetworksCreateSpecType 
    {
        /// <summary>
        /// Identifier of the network. This has DNS_LABEL restrictions as specified in . This must be an alphanumeric (a-z and 0-9)
        /// string and with maximum length of 63 characters and with the '-' character allowed anywhere except the first or last
        /// character. This name must be unique within a cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.Network. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespace_management.Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        public string Network { get; set; }
        /// <summary>
        /// The network provider that will manage the vSphere Namespaces network object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersNetworkProviderType NetworkProvider { get; set; }
        /// <summary>
        /// The create spec for a DVPG-backed Namespaces network object, supported by VSPHERE_NETWORK network provider.
        /// This field is optional and it is only relevant when the value of Networks.CreateSpec.network-provider is
        /// VSPHERE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_network")]
        public VcenterNamespaceManagementNetworksVsphereDvpgnetworkCreateSpecType VsphereNetwork { get; set; }
        /// <summary>
        /// The create spec for a NSXT-backed Namespaces network configuration, supported by NSXT_CONTAINER_PLUGIN network provider.
        /// This field is optional and it is only relevant when the value of Networks.CreateSpec.network-provider is
        /// NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_network")]
        public VcenterNamespaceManagementNetworksNsxNetworkCreateSpecType NsxNetwork { get; set; }
    }
}
