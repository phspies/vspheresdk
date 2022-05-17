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
    public class ApplianceNetworkingFirewallInboundSetType 
    {
        /// <summary>
        /// List of address-based firewall rules.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "rules", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceNetworkingFirewallInboundRuleType> Rules { get; set; }
    }
}
