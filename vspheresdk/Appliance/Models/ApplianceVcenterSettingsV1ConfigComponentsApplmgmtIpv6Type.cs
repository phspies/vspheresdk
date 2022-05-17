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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtIpv6Type 
    {
        /// <summary>
        /// An address will be assigned by a DHCP server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dhcp", Required = Required.AllowNull)]
        public bool Dhcp { get; set; }
        /// <summary>
        /// An address will be assigned by Stateless Address Autoconfiguration (SLAAC).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "autoconf", Required = Required.AllowNull)]
        public bool Autoconf { get; set; }
        /// <summary>
        /// The IPv6 is configured or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "configurable", Required = Required.AllowNull)]
        public bool Configurable { get; set; }
        /// <summary>
        /// The list of addresses to be statically assigned.
        /// If set, the addresses were never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "addresses")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsApplmgmtAddressType> Addresses { get; set; }
        /// <summary>
        /// The default gateway for static IP address assignment. This configures the global IPv6 default gateway on the appliance
        /// with the specified gateway address and interface. This gateway replaces the existing default gateway configured on the
        /// appliance. However, if the gateway address is link-local, then it is added for that interface. This does not support
        /// configuration of multiple global default gateways through different interfaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway", Required = Required.AllowNull)]
        public string DefaultGateway { get; set; }
    }
}
