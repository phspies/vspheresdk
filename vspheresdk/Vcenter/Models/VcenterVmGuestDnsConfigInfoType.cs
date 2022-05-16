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
    public class VcenterVmGuestDnsConfigInfoType 
    {
        /// <summary>
        /// The IP addresses of the DNS servers in order of use. IPv4 addresses are specified using dotted decimal notation. For
        /// example, "192.0.2.1". IPv6 addresses are 128-bit addresses represented as eight fields of up to four hexadecimal digits.
        /// A colon separates each field (:). For example, 2001:DB8:101::230:6eff:fe04:d9ff. The address can also consist of the
        /// symbol '::' to represent multiple 16-bit groups of contiguous 0's only once in an address as described in RFC 2373.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// The domain in which to search for hosts, placed in order of preference. These are the domain name portion of the DNS
        /// names.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "search_domains", Required = Required.AllowNull)]
        public IList<string> SearchDomains { get; set; }
    }
}
