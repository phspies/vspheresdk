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
    public class VcenterVmHardwareSerialBackingInfoType 
    {
        /// <summary>
        /// Backing type for the virtual serial port.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareSerialBackingTypeEnum Type { get; set; }
        /// <summary>
        /// Path of the file backing the virtual serial port.
        /// This field is optional and it is only relevant when the value of Serial.BackingInfo.type is FILE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public string? File { get; set; }
        /// <summary>
        /// Name of the device backing the virtual serial port.
        /// 
        /// 
        /// This field will be unset if Serial.BackingInfo.auto-detect is true and the virtual serial port is not connected or no
        /// suitable device is available on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_device")]
        public string? HostDevice { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual serial port is configured to automatically detect a suitable host device.
        /// This field is optional and it is only relevant when the value of Serial.BackingInfo.type is HOST_DEVICE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_detect")]
        public bool? AutoDetect { get; set; }
        /// <summary>
        /// Name of the pipe backing the virtual serial port.
        /// This field is optional and it is only relevant when the value of Serial.BackingInfo.type is one of PIPE_SERVER or
        /// PIPE_CLIENT.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pipe")]
        public string? Pipe { get; set; }
        /// <summary>
        /// Flag that enables optimized data transfer over the pipe. When the value is true, the host buffers data to prevent data
        /// overrun. This allows the virtual machine to read all of the data transferred over the pipe with no data loss.
        /// This field is optional and it is only relevant when the value of Serial.BackingInfo.type is one of PIPE_SERVER or
        /// PIPE_CLIENT.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "no_rx_loss")]
        public bool? NoRxLoss { get; set; }
        /// <summary>
        /// URI specifying the location of the network service backing the virtual serial port.
        /// - If Serial.BackingInfo.type is NETWORK_SERVER, this field is the location used by clients to connect to this server.
        /// The hostname part of the URI should either be empty or should specify the address of the host on which the virtual
        /// machine is running.
        /// - If Serial.BackingInfo.type is NETWORK_CLIENT, this field is the location used by the virtual machine to connect to the
        /// remote server.
        /// 
        /// This field is optional and it is only relevant when the value of Serial.BackingInfo.type is one of NETWORK_SERVER or
        /// NETWORK_CLIENT.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_location")]
        public string? NetworkLocation { get; set; }
        /// <summary>
        /// Proxy service that provides network access to the network backing. If set, the virtual machine initiates a connection
        /// with the proxy service and forwards the traffic to the proxy.
        /// If unset, no proxy service is configured.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxy")]
        public string? Proxy { get; set; }
    }
}
