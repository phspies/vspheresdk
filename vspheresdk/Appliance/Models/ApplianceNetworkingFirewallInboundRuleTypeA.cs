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
    public class ApplianceNetworkingFirewallInboundRuleTypeA 
    {
        /// <summary>
        /// IPv4 or IPv6 address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
        /// <summary>
        /// CIDR prefix used to mask address. For example, an IPv4 prefix of 24 ignores the low-order 8 bits of address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "prefix", Required = Required.AllowNull)]
        public long Prefix { get; set; }
        /// <summary>
        /// The allow or deny policy of this rule.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "policy", Required = Required.AllowNull)]
        public ApplianceNetworkingFirewallInboundPolicyEnumTypeA Policy { get; set; }
        /// <summary>
        /// The interface to which this rule applies. An empty string indicates that the rule applies to all interfaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interface_name")]
        public string? InterfaceName { get; set; }
    }
}
