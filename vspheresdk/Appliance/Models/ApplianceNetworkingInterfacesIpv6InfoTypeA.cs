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
    public class ApplianceNetworkingInterfacesIpv6InfoTypeA 
    {
        /// <summary>
        /// DHCP is on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dhcp", Required = Required.AllowNull)]
        public bool Dhcp { get; set; }
        /// <summary>
        /// Stateless Address Autoconfiguration (SLAAC) is on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "autoconf", Required = Required.AllowNull)]
        public bool Autoconf { get; set; }
        /// <summary>
        /// List of addresses with their origins and statuses.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "addresses", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceNetworkingInterfacesIpv6AddressInfoTypeA> Addresses { get; set; }
        /// <summary>
        /// The default gateway for static IP address assignment. This configures the global IPv6 default gateway on the appliance
        /// with the specified gateway address and interface. This gateway replaces the existing default gateway configured on the
        /// appliance. However, if the gateway address is link-local, then it is added for that interface. This does not support
        /// configuration of multiple global default gateways through different interfaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway", Required = Required.AllowNull)]
        public string DefaultGateway { get; set; }
        /// <summary>
        /// Is NIC configurable or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "configurable", Required = Required.AllowNull)]
        public bool Configurable { get; set; }
    }
}
