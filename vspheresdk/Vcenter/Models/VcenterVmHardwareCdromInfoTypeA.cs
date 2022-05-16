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
    public class VcenterVmHardwareCdromInfoTypeA 
    {
        /// <summary>
        /// Type of host bus adapter to which the device is attached.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareCdromHostBusAdapterTypeA Type { get; set; }
        /// <summary>
        /// Device label.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        public string Label { get; set; }
        /// <summary>
        /// Address of device attached to a virtual IDE adapter.
        /// This field is optional and it is only relevant when the value of Cdrom.Info.type is IDE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ide")]
        public VcenterVmHardwareIdeAddressInfoTypeA Ide { get; set; }
        /// <summary>
        /// Address of device attached to a virtual SATA adapter.
        /// This field is optional and it is only relevant when the value of Cdrom.Info.type is SATA.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sata")]
        public VcenterVmHardwareSataAddressInfoTypeA Sata { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual CD-ROM device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing", Required = Required.AllowNull)]
        public VcenterVmHardwareCdromBackingInfoTypeA Backing { get; set; }
        /// <summary>
        /// Connection status of the virtual device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterVmHardwareConnectionStateTypeA State { get; set; }
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
