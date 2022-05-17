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
    public class VcenterVmHardwareEthernetBackingInfoTypeA 
    {
        /// <summary>
        /// Backing type for the virtual Ethernet adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareEthernetBackingTypeEnumA Type { get; set; }
        /// <summary>
        /// Identifier of the network backing the virtual Ethernet adapter.
        /// If unset, the identifier of the network backing could not be determined.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
        /// <summary>
        /// Name of the standard portgroup backing the virtual Ethernet adapter.
        /// This field is optional and it is only relevant when the value of Ethernet.BackingInfo.type is STANDARD_PORTGROUP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_name")]
        public string? NetworkName { get; set; }
        /// <summary>
        /// Name of the device backing the virtual Ethernet adapter.
        /// This field is optional and it is only relevant when the value of Ethernet.BackingInfo.type is HOST_DEVICE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
        /// <summary>
        /// UUID of the distributed virtual switch that backs the virtual Ethernet adapter.
        /// This field is optional and it is only relevant when the value of Ethernet.BackingInfo.type is DISTRIBUTED_PORTGROUP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "distributed_switch_uuid")]
        public string? DistributedSwitchUuid { get; set; }
        /// <summary>
        /// Key of the distributed virtual port that backs the virtual Ethernet adapter.
        /// This field will be unset if the virtual Ethernet device is not bound to a distributed virtual port; this can happen if
        /// the virtual machine is powered off or the virtual Ethernet device is not connected.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "distributed_port")]
        public string? DistributedPort { get; set; }
        /// <summary>
        /// Server-generated cookie that identifies the connection to the port. This ookie may be used to verify that the virtual
        /// machine is the rightful owner of the port.
        /// This field will be unset if the virtual Ethernet device is not bound to a distributed virtual port; this can happen if
        /// the virtual machine is powered off or the virtual Ethernet device is not connected.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_cookie")]
        public long? ConnectionCookie { get; set; }
        /// <summary>
        /// Type of the opaque network that backs the virtual Ethernet adapter.
        /// This field is optional and it is only relevant when the value of Ethernet.BackingInfo.type is OPAQUE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "opaque_network_type")]
        public string? OpaqueNetworkType { get; set; }
        /// <summary>
        /// Identifier of the opaque network that backs the virtual Ethernet adapter.
        /// This field is optional and it is only relevant when the value of Ethernet.BackingInfo.type is OPAQUE_NETWORK.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "opaque_network_id")]
        public string? OpaqueNetworkId { get; set; }
    }
}
