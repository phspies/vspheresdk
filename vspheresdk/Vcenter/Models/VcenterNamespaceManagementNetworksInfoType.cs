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
    public class VcenterNamespaceManagementNetworksInfoType 
    {
        /// <summary>
        /// Identifier of the network.
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
        public VcenterNamespaceManagementClustersNetworkProviderEnumType NetworkProvider { get; set; }
        /// <summary>
        /// Updated configuration specification for a DVPG-backed Namespaces network object, supported by VSPHERE_NETWORK network
        /// provider.
        /// This field is optional and it is only relevant when the value of Networks.Info.network-provider is VSPHERE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vsphere_network")]
        public VcenterNamespaceManagementNetworksVsphereDvpgnetworkInfoType VsphereNetwork { get; set; }
        /// <summary>
        /// Configuration specification for a NSXT-backed Namespaces network configuration, supported by NSXT_CONTAINER_PLUGIN
        /// network provider.
        /// This field is optional and it is only relevant when the value of Networks.Info.network-provider is
        /// NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nsx_network")]
        public VcenterNamespaceManagementNetworksNsxNetworkInfoType NsxNetwork { get; set; }
        /// <summary>
        /// A list of Supervisor Namespaces associated with this network.
        /// This field is optional because it was added in a newer version than its parent node.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespaces")]
        public IList<string> Namespaces { get; set; }
    }
}
