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
    public class VcenterNamespaceManagementNetworksVsphereDvpgnetworkCreateSpecType 
    {
        /// <summary>
        /// Identifier of the vSphere Distributed Portgroup backing the vSphere network object.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "portgroup", Required = Required.AllowNull)]
        public string Portgroup { get; set; }
        /// <summary>
        /// IP address assignment mode. If set to DHCP, then field Networks.VsphereDVPGNetworkCreateSpec.address-ranges must be set
        /// to an empty list and fields Networks.VsphereDVPGNetworkCreateSpec.gateway and
        /// Networks.VsphereDVPGNetworkCreateSpec.subnet-mask must be set to empty strings.
        /// If unset, defaults to STATICRANGE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_assignment_mode")]
        public VcenterNamespaceManagementNetworksIpassignmentModeEnumType IpAssignmentMode { get; set; }
        /// <summary>
        /// Usable IP pools on this network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_ranges", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIprangeType> AddressRanges { get; set; }
        /// <summary>
        /// Gateway for the network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gateway", Required = Required.AllowNull)]
        public string Gateway { get; set; }
        /// <summary>
        /// Subnet mask of the network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask", Required = Required.AllowNull)]
        public string SubnetMask { get; set; }
    }
}
