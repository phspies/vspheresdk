using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceNetworkingInterfacesIpv6AddressTypeA 
    {
        /// <summary>
        /// The IPv6 address, for example, fc00:10:20:83:20c:29ff:fe94:bb5a.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// The IPv6 CIDR prefix, for example, 64.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        public long Prefix { get; set; }
    }
}
