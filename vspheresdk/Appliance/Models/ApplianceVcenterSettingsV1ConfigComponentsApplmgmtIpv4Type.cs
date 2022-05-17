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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtIpv4Type 
    {
        /// <summary>
        /// The Address assignment mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtIpv4ModeEnumType Mode { get; set; }
        /// <summary>
        /// The IPv4 address, for example, "10.20.80.191".
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// The IPv4 CIDR prefix, for example, 24. See http://www.oav.net/mirrors/cidr.html for netmask-to-prefix conversion.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        public long Prefix { get; set; }
        /// <summary>
        /// The IPv4 address of the default gateway. This configures the global default gateway on the appliance with the specified
        /// gateway address and interface. This gateway replaces the existing default gateway configured on the appliance. However,
        /// if the gateway address is link-local, then it is added for that interface. This does not support configuration of
        /// multiple global default gateways through different interfaces.
        /// If set, the defaultGateway was never set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway")]
        public string? DefaultGateway { get; set; }
        /// <summary>
        /// The IPv4 is configured or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "configurable")]
        public bool? Configurable { get; set; }
    }
}
