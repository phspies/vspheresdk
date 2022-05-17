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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtInterfaceType 
    {
        /// <summary>
        /// Interface name, for example, "nic0", "nic1".
        /// If set, the name was never set
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Interface status.
        /// If set, the name was never set
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtInterfaceInterfaceStatusEnumType Status { get; set; }
        /// <summary>
        /// MAC address. For example 00:0C:29:94:BB:5A.
        /// If set, the mac was never set
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// IPv4 Address information.
        /// ipv4 This set IPv4 is not set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv4")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtIpv4Type Ipv4 { get; set; }
        /// <summary>
        /// IPv6 Address information.
        /// ipv6 This set IPv6 is not set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtIpv6Type Ipv6 { get; set; }
    }
}
