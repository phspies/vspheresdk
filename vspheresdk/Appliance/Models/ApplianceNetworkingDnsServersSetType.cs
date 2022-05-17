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
    public class ApplianceNetworkingDnsServersSetType 
    {
        /// <summary>
        /// Define how to determine the DNS servers. Leave the servers argument empty if the mode argument is "DHCP". Set the
        /// servers argument to a comma-separated list of DNS servers if the mode argument is "static". The DNS server are assigned
        /// from the specified list.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public ApplianceNetworkingDnsServersDnsserverModeType Mode { get; set; }
        /// <summary>
        /// List of the currently used DNS servers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "servers", Required = Required.AllowNull)]
        public IList<string> Servers { get; set; }
    }
}
