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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtApplianceNetworkType 
    {
        /// <summary>
        /// List of Firewall Rules to be applied.
        /// Only set if the FirewallRulePolicy is set in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "firewall_rule_policies")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsApplmgmtFirewallRulePolicyType> FirewallRulePolicies { get; set; }
        /// <summary>
        /// DNS configuration to be applied.
        /// Only set if the DnsServerConfiguration is set in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_server_configuration")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtDnsServerConfigurationType DnsServerConfiguration { get; set; }
        /// <summary>
        /// Proxy configuration to be applied.
        /// Only set if the Proxy server configuration is set in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxy_configuration")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsApplmgmtProxyConfigurationType> ProxyConfiguration { get; set; }
        /// <summary>
        /// Interfaces configuration to be applied.
        /// Only set if the Interfaces configuration is set in vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "interfaces")]
        public Dictionary<string,ApplianceVcenterSettingsV1ConfigComponentsApplmgmtInterfaceType> Interfaces { get; set; }
    }
}
