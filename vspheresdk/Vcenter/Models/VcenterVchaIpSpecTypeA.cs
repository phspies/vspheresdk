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
    public class VcenterVchaIpSpecTypeA 
    {
        /// <summary>
        /// Family of the IP address to configure the interface.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_family", Required = Required.AllowNull)]
        public VcenterVchaIpFamilyTypeA IpFamily { get; set; }
        /// <summary>
        /// If the family of the ip is IPV4, then this will point to IPv4 address specification.
        /// This field is optional and it is only relevant when the value of IpSpec.ip-family is IPV4.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv4")]
        public VcenterVchaIpv4SpecTypeA Ipv4 { get; set; }
        /// <summary>
        /// If the family of the ip is IPV6, then this will point to IPv6 address specification.
        /// This field is optional and it is only relevant when the value of IpSpec.ip-family is IPV6.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6")]
        public VcenterVchaIpv6SpecTypeA Ipv6 { get; set; }
        /// <summary>
        /// The IP address of the Gateway for this interface.
        /// If unset, gateway will not be used for the network interface.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        public string? DefaultGateway { get; set; }
        /// <summary>
        /// The list of IP addresses of the DNS servers for this interface. This list is a comma separated list.
        /// If unset, DNS servers will not be used for the network interface.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        public IList<string> DnsServers { get; set; }
    }
}
