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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtDnsServerConfigurationType 
    {
        /// <summary>
        /// Define how to determine the DNS servers. Leave the servers argument empty if the mode argument is "DHCP". Set the
        /// servers argument to a comma-separated list of DNS servers if the mode argument is "static". The DNS server are assigned
        /// from the specified list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtDnsServerConfigurationDnsserverModeType Mode { get; set; }
        /// <summary>
        /// List of the currently used DNS servers. DNS server configuration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "servers", Required = Required.AllowNull)]
        public IList<string> Servers { get; set; }
        /// <summary>
        /// List of the search domains. DNS Search Domains.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domains")]
        public IList<string> Domains { get; set; }
    }
}
