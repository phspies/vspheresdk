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
    public class VcenterVmGuestDhcpConfigInfoType 
    {
        /// <summary>
        /// True if IPv4 DHCP is enabled, false otherwise.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv4_enabled", Required = Required.AllowNull)]
        public bool Ipv4Enabled { get; set; }
        /// <summary>
        /// True if IPv6 DHCP is enabled, false otherwise.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_enabled", Required = Required.AllowNull)]
        public bool Ipv6Enabled { get; set; }
    }
}
