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
    public class VcenterGuestIpv4Type 
    {
        /// <summary>
        /// The type of the IPv4 configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterGuestIpv4TypeEnum Type { get; set; }
        /// <summary>
        /// The static IPv4 address
        /// This field is optional and it is only relevant when the value of Ipv4.type is STATIC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
        /// <summary>
        /// The IPv4 CIDR prefix, for example, 24. See http://www.oav.net/mirrors/cidr.html for netmask-to-prefix conversion.
        /// This field is optional and it is only relevant when the value of Ipv4.type is STATIC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public long? Prefix { get; set; }
        /// <summary>
        /// Gateways for the IPv4 address.
        /// If unset, no gateways are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gateways")]
        public IList<string> Gateways { get; set; }
    }
}
