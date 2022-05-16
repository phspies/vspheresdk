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
    public class VcenterVmGuestNetworkingInterfacesIpConfigInfoTypeA 
    {
        /// <summary>
        /// IP addresses configured on the interface.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        public Dictionary<string,VcenterVmGuestNetworkingInterfacesIpAddressInfoTypeA> IpAddresses { get; set; }
        /// <summary>
        /// Client side DHCP for an interface.
        /// If unset the IP was not configured by DHCP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dhcp")]
        public VcenterVmGuestDhcpConfigInfoTypeA Dhcp { get; set; }
    }
}
