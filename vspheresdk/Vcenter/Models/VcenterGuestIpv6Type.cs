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
    public class VcenterGuestIpv6Type 
    {
        /// <summary>
        /// The IPv6 configuration type
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterGuestIpv6TypeA Type { get; set; }
        /// <summary>
        /// IPv6 address
        /// This field is optional and it is only relevant when the value of Ipv6.type is STATIC.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6")]
        public Dictionary<string,VcenterGuestIpv6AddressType> Ipv6 { get; set; }
        /// <summary>
        /// gateways for the IPv6 address.
        /// If unset, no gateways are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gateways")]
        public IList<string> Gateways { get; set; }
    }
}
