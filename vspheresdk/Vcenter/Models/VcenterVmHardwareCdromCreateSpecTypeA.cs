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
    public class VcenterVmHardwareCdromCreateSpecTypeA 
    {
        /// <summary>
        /// Type of host bus adapter to which the device should be attached.
        /// If unset, guest-specific default values will be used
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterVmHardwareCdromHostBusAdapterTypeA Type { get; set; }
        /// <summary>
        /// Address for attaching the device to a virtual IDE adapter.
        /// If unset, the server will choose an available address; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ide")]
        public VcenterVmHardwareIdeAddressSpecTypeA Ide { get; set; }
        /// <summary>
        /// Address for attaching the device to a virtual SATA adapter.
        /// If unset, the server will choose an available address; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sata")]
        public VcenterVmHardwareSataAddressSpecTypeA Sata { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual CD-ROM device.
        /// If unset, defaults to automatic detection of a suitable host device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing")]
        public VcenterVmHardwareCdromBackingSpecTypeA Backing { get; set; }
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
