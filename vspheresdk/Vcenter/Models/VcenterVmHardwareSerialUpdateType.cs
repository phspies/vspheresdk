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
    public class VcenterVmHardwareSerialUpdateType 
    {
        /// <summary>
        /// CPU yield behavior. If set to true, the virtual machine will periodically relinquish the processor if its sole task is
        /// polling the virtual serial port. The amount of time it takes to regain the processor will depend on the degree of other
        /// virtual machine activity on the host.
        /// This field may be modified at any time, and changes applied to a connected virtual serial port take effect immediately.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "yield_on_poll")]
        public bool? YieldOnPoll { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual serial port.
        /// This field may only be modified if the virtual machine is not powered on or the virtual serial port is not connected.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing")]
        public VcenterVmHardwareSerialBackingSpecType Backing { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_connected")]
        public bool? StartConnected { get; set; }
        /// <summary>
        /// Flag indicating whether the guest can connect and disconnect the device.
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "allow_guest_control")]
        public bool? AllowGuestControl { get; set; }
    }
}
