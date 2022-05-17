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
    public class ApplianceNetworkingInterfacesInterfaceInfoType 
    {
        /// <summary>
        /// Interface name, for example, "nic0", "nic1".
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Interface status.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceNetworkingInterfacesInterfaceStatusEnumType Status { get; set; }
        /// <summary>
        /// MAC address. For example 00:0C:29:94:BB:5A.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac", Required = Required.AllowNull)]
        public string Mac { get; set; }
        /// <summary>
        /// IPv4 Address information.
        /// ipv4 This field will be unset if IPv4 is not enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv4")]
        public ApplianceNetworkingInterfacesIpv4InfoType Ipv4 { get; set; }
        /// <summary>
        /// IPv6 Address information.
        /// ipv6 This field will be unset if IPv6 is not enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6")]
        public ApplianceNetworkingInterfacesIpv6InfoType Ipv6 { get; set; }
    }
}
