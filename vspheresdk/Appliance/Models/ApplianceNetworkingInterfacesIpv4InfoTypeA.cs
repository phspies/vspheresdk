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
    public class ApplianceNetworkingInterfacesIpv4InfoTypeA 
    {
        /// <summary>
        /// The specified network interface is configurable or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "configurable", Required = Required.AllowNull)]
        public bool Configurable { get; set; }
        /// <summary>
        /// The Address assignment mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public ApplianceNetworkingInterfacesIpv4ModeTypeA Mode { get; set; }
        /// <summary>
        /// The IPv4 address, for example, "10.20.80.191".
        /// This field is optional and it is only relevant when the value of Ipv4.Info.mode is one of STATIC or DHCP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string? Address { get; set; }
        /// <summary>
        /// The IPv4 CIDR prefix, for example, 24. See http://www.oav.net/mirrors/cidr.html for netmask-to-prefix conversion.
        /// This field is optional and it is only relevant when the value of Ipv4.Info.mode is one of STATIC or DHCP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public long? Prefix { get; set; }
        /// <summary>
        /// The IPv4 address of the default gateway. This configures the global default gateway on the appliance with the specified
        /// gateway address and interface. This gateway replaces the existing default gateway configured on the appliance. However,
        /// if the gateway address is link-local, then it is added for that interface. This does not support configuration of
        /// multiple global default gateways through different interfaces.
        /// This field is optional and it is only relevant when the value of Ipv4.Info.mode is one of STATIC or DHCP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        public string? DefaultGateway { get; set; }
    }
}
