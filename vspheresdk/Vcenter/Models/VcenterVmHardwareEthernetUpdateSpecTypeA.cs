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
    public class VcenterVmHardwareEthernetUpdateSpecTypeA 
    {
        /// <summary>
        /// Flag indicating whether Universal Pass-Through (UPT) compatibility should be enabled on this virtual Ethernet adapter.
        /// This field may be modified at any time, and changes will be applied the next time the virtual machine is powered on.
        /// 
        /// If unset, the value is unchanged. Must be unset if the emulation type of the virtual Ethernet adapter is not VMXNET3.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upt_compatibility_enabled")]
        public bool? UptCompatibilityEnabled { get; set; }
        /// <summary>
        /// MAC address type.
        /// This field may be modified at any time, and changes will be applied the next time the virtual machine is powered on.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_type")]
        public VcenterVmHardwareEthernetMacAddressTypeEnumA MacType { get; set; }
        /// <summary>
        /// MAC address.
        /// This field may be modified at any time, and changes will be applied the next time the virtual machine is powered on.
        /// 
        /// If unset, the value is unchanged. Must be specified if Ethernet.UpdateSpec.mac-type is MANUAL. Must be unset if the MAC
        /// address type is not MANUAL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// Flag indicating whether wake-on-LAN shoud be enabled on this virtual Ethernet adapter.
        /// This field may be modified at any time, and changes will be applied the next time the virtual machine is powered on.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "wake_on_lan_enabled")]
        public bool? WakeOnLanEnabled { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual Ethernet adapter.
        /// This field may be modified at any time, and changes will be applied the next time the virtual machine is powered on.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing")]
        public VcenterVmHardwareEthernetBackingSpecTypeA Backing { get; set; }
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
