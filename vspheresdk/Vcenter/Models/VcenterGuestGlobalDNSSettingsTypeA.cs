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
    public class VcenterGuestGlobalDNSSettingsTypeA 
    {
        /// <summary>
        /// List of name resolution suffixes for the virtual network adapter. This list applies to both Windows and Linux guest
        /// customization. For Linux, this setting is global, whereas in Windows, this setting is listed on a per-adapter basis.
        /// If unset, no DNS suffixes are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_suffix_list")]
        public IList<string> DnsSuffixList { get; set; }
        /// <summary>
        /// List of DNS servers, for a virtual network adapter with a static IP address. If this list is empty, then the guest
        /// operating system is expected to use a DHCP server to get its DNS server settings. These settings configure the virtual
        /// machine to use the specified DNS servers. These DNS server settings are listed in the order of preference.
        /// If unset, no DNS servers are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        public IList<string> DnsServers { get; set; }
    }
}
