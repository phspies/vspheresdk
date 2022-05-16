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
    public class VcenterGuestWindowsNetworkAdapterSettingsType 
    {
        /// <summary>
        /// A list of server IP addresses to use for DNS lookup in a Windows guest operating system.
        /// These servers should be specified in the order of preference. If this list is not empty, and if a DHCP IP address is
        /// used, then these settings override the DHCP settings.
        /// 
        /// If unset, no DNS servers are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// A DNS domain suffix such as vmware.com.
        /// If unset, no DNS domain is set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_domain")]
        public string? DnsDomain { get; set; }
        /// <summary>
        /// List of WINS Servers to set for the Windows guest operating system. A Maximum of two IP addresses can be specified in
        /// this list. The first IP address will be set as the primary WINS server. The second IP address will be set as the
        /// secondary WINS server.
        /// If unset, no WINS Servers are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "wins_servers")]
        public IList<string> WinsServers { get; set; }
        /// <summary>
        /// NetBIOS setting for Windows.
        /// If unset, existing NetBIOS mode will be retained.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "net_BIOS_mode")]
        public VcenterGuestWindowsNetworkAdapterSettingsNetBiosmodeType NetBiosmode { get; set; }
    }
}
