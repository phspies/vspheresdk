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
    public class VcenterVmGuestNetworkingInterfacesIpAddressInfoType 
    {
        /// <summary>
        /// IPv4 address is specified using dotted decimal notation. For example, "192.0.2.1". IPv6 addresses are 128-bit addresses
        /// specified using eight fields of up to four hexadecimal digits. A colon separates each field (:). For example,
        /// 2001:DB8:101::230:6eff:fe04:d9ff. The address can also consist of the symbol '::' to represent multiple 16-bit groups of
        /// contiguous 0's only once in an address as described in RFC 2373.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// Denotes the length of a generic Internet network address prefix. Prefix length: the valid range of values is 0-32 for
        /// IPv4, and 0-128 for IPv6. A value of n corresponds to an IP address mask that has n contiguous 1-bits from the most
        /// significant bit (MSB), with all other bits set to 0. A value of zero is valid only if the calling context defines it.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix_length", Required = Required.AllowNull)]
        public long PrefixLength { get; set; }
        /// <summary>
        /// How this address was configured.
        /// If unset the data was not available.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public VcenterVmGuestNetworkingInterfacesIpAddressOriginEnumType Origin { get; set; }
        /// <summary>
        /// The state of this ipAddress.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterVmGuestNetworkingInterfacesIpAddressStatusEnumType State { get; set; }
    }
}
