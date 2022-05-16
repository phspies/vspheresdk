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
    public class VcenterGuestIPSettingsTypeA 
    {
        /// <summary>
        /// Specification to configure IPv4 address, subnet mask and gateway info for this virtual network adapter.
        /// If unset, no IPv4 addresses are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv4")]
        public VcenterGuestIpv4TypeA Ipv4 { get; set; }
        /// <summary>
        /// Specification to configure IPv6 address, subnet mask and gateway info for this virtual network adapter.
        /// If unset, no IPv6 addresses are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6")]
        public VcenterGuestIpv6TypeA Ipv6 { get; set; }
        /// <summary>
        /// Windows settings to be configured for this specific virtual Network adapter. This is valid only for Windows guest
        /// operating systems.
        /// If unset, no specific Windows settings are set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "windows")]
        public VcenterGuestWindowsNetworkAdapterSettingsTypeA Windows { get; set; }
    }
}
