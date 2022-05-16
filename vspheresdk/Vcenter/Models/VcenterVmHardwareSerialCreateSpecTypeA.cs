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
    public class VcenterVmHardwareSerialCreateSpecTypeA 
    {
        /// <summary>
        /// CPU yield behavior. If set to true, the virtual machine will periodically relinquish the processor if its sole task is
        /// polling the virtual serial port. The amount of time it takes to regain the processor will depend on the degree of other
        /// virtual machine activity on the host.
        /// If unset, defaults to false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "yield_on_poll")]
        public bool? YieldOnPoll { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual serial port.
        /// If unset, defaults to automatic detection of a suitable host device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing")]
        public VcenterVmHardwareSerialBackingSpecTypeA Backing { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.
        /// Defaults to false if unset.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_connected")]
        public bool? StartConnected { get; set; }
        /// <summary>
        /// Flag indicating whether the guest can connect and disconnect the device.
        /// Defaults to false if unset.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "allow_guest_control")]
        public bool? AllowGuestControl { get; set; }
    }
}
