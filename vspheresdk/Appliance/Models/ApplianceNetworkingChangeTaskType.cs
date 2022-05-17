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
    public class ApplianceNetworkingChangeTaskType 
    {
        /// <summary>
        /// New hostname to assign to the management network of vCenter appliance
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// vCenter Server SSO administrator username
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "SSO_user", Required = Required.AllowNull)]
        public string SSouser { get; set; }
        /// <summary>
        /// vCenter Server SSO administrator Password
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "SSO_password", Required = Required.AllowNull)]
        public string SSopassword { get; set; }
        /// <summary>
        /// DNS Configuration to set for the machine
        /// If unset DNS settings will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns")]
        public ApplianceNetworkingDnsServersDnsserverConfigType Dns { get; set; }
        /// <summary>
        /// IPv4 Configuration to set for the machine
        /// If unset IPv4 settings will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv4")]
        public ApplianceNetworkingInterfacesIpv4ConfigType Ipv4 { get; set; }
        /// <summary>
        /// IPv6 Configuration to set for the machine
        /// If unset IPv6 settings will not be changed
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6")]
        public ApplianceNetworkingInterfacesIpv6ConfigType Ipv6 { get; set; }
    }
}
