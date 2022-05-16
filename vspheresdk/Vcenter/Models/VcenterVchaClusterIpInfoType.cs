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
    public class VcenterVchaClusterIpInfoType 
    {
        /// <summary>
        /// Family of the ip.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_family", Required = Required.AllowNull)]
        public VcenterVchaClusterIpFamilyType IpFamily { get; set; }
        /// <summary>
        /// If the type of the ip family is IPV4, then this will point to IPv4 address specification.
        /// This field is optional and it is only relevant when the value of Cluster.IpInfo.ip-family is IPV4.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv4")]
        public VcenterVchaClusterIpv4InfoType Ipv4 { get; set; }
        /// <summary>
        /// If the type of the ip family is IPV6, then this will point to IPv6 address specification.
        /// This field is optional and it is only relevant when the value of Cluster.IpInfo.ip-family is IPV6.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6")]
        public VcenterVchaClusterIpv6InfoType Ipv6 { get; set; }
        /// <summary>
        /// Gateway IP address.
        /// If unset, no gateway is specified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gateway_ip")]
        public string? GatewayIp { get; set; }
    }
}
