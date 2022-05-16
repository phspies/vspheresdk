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
    public class VcenterNamespaceManagementClustersIpv4RangeType 
    {
        /// <summary>
        /// The IPv4 address denoting the start of the range.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "starting_address", Required = Required.AllowNull)]
        public string StartingAddress { get; set; }
        /// <summary>
        /// The number of IP addresses in the range. Addresses are derived by incrementing Clusters.Ipv4Range.starting-address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_count", Required = Required.AllowNull)]
        public long AddressCount { get; set; }
        /// <summary>
        /// Subnet mask to be set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask", Required = Required.AllowNull)]
        public string SubnetMask { get; set; }
        /// <summary>
        /// The IPv4 address of the gateway associated with the range indicated by Clusters.Ipv4Range.starting-address and
        /// Clusters.Ipv4Range.address-count.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gateway", Required = Required.AllowNull)]
        public string Gateway { get; set; }
    }
}
