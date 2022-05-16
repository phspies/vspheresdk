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
    public class VcenterVmHardwareFloppyInfoType 
    {
        /// <summary>
        /// Device label.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        public string Label { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual floppy drive.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing", Required = Required.AllowNull)]
        public VcenterVmHardwareFloppyBackingInfoType Backing { get; set; }
        /// <summary>
        /// Connection status of the virtual device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterVmHardwareConnectionStateType State { get; set; }
        /// <summary>
        /// Flag indicating whether the virtual device should be connected whenever the virtual machine is powered on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_connected", Required = Required.AllowNull)]
        public bool StartConnected { get; set; }
        /// <summary>
        /// Flag indicating whether the guest can connect and disconnect the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "allow_guest_control", Required = Required.AllowNull)]
        public bool AllowGuestControl { get; set; }
    }
}
