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
    public class VcenterNamespaceManagementClustersNetworkSpecType 
    {
        /// <summary>
        /// Optionally specify the Floating IP used by the cluster control plane in case of DHCP.
        /// If unset, the existing effective management network floating IP will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "floating_IP")]
        public string? FloatingIP { get; set; }
        /// <summary>
        /// Identifier for the network.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network", Required = Required.AllowNull)]
        public string Network { get; set; }
        /// <summary>
        /// The address assignment mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersNetworkSpecIpv4ModeEnumType Mode { get; set; }
        /// <summary>
        /// Settings for the interfaces on the network.
        /// This field is optional and it is only relevant when the value of Clusters.NetworkSpec.mode is STATICRANGE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_range")]
        public VcenterNamespaceManagementClustersIpv4RangeType AddressRange { get; set; }
    }
}
