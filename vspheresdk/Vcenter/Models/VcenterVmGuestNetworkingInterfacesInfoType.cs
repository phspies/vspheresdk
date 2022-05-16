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
    public class VcenterVmGuestNetworkingInterfacesInfoType 
    {
        /// <summary>
        /// Client DNS values. Data assigned by DNS.
        /// If unset no DNS assigned value exists.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns_values")]
        public VcenterVmGuestDnsAssignedValuesType DnsValues { get; set; }
        /// <summary>
        /// MAC address of the adapter.
        /// If unset then not supported by the Guest OS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// DNS configuration of the adapter. See Networking.Info.dns for system wide settings.
        /// If unset then not assigned by the Guest OS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dns")]
        public VcenterVmGuestDnsConfigInfoType Dns { get; set; }
        /// <summary>
        /// IP configuration settings of the adapter
        /// If unset then not supported by the Guest OS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ip")]
        public VcenterVmGuestNetworkingInterfacesIpConfigInfoType Ip { get; set; }
        /// <summary>
        /// The IP addresses of any WINS name servers for the adapter.
        /// If unset then not supported by the Guest OS.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "wins_servers")]
        public IList<string> WinsServers { get; set; }
        /// <summary>
        /// Link to the corresponding virtual device.
        /// If unset then the interface is not backed by a virtual device.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.vm.hardware.Ethernet. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.vm.hardware.Ethernet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nic")]
        public string? Nic { get; set; }
    }
}
