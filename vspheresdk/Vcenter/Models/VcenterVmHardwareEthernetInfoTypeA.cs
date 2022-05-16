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
    public class VcenterVmHardwareEthernetInfoTypeA 
    {
        /// <summary>
        /// Device label.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        public string Label { get; set; }
        /// <summary>
        /// Ethernet adapter emulation type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareEthernetEmulationTypeA Type { get; set; }
        /// <summary>
        /// Flag indicating whether Universal Pass-Through (UPT) compatibility is enabled on this virtual Ethernet adapter.
        /// This field is optional and it is only relevant when the value of Ethernet.Info.type is VMXNET3.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upt_compatibility_enabled")]
        public bool? UptCompatibilityEnabled { get; set; }
        /// <summary>
        /// MAC address type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_type", Required = Required.AllowNull)]
        public VcenterVmHardwareEthernetMacAddressTypeA MacType { get; set; }
        /// <summary>
        /// MAC address.
        /// May be unset if Ethernet.Info.mac-type is MANUAL and has not been specified, or if Ethernet.Info.mac-type is GENERATED
        /// and the virtual machine has never been powered on since the Ethernet adapter was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// Address of the virtual Ethernet adapter on the PCI bus. If the PCI address is invalid, the server will change it when
        /// the VM is started or as the device is hot added.
        /// May be unset if the virtual machine has never been powered on since the adapter was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_slot_number")]
        public long? PciSlotNumber { get; set; }
        /// <summary>
        /// Flag indicating whether wake-on-LAN is enabled on this virtual Ethernet adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "wake_on_lan_enabled", Required = Required.AllowNull)]
        public bool WakeOnLanEnabled { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual Ethernet adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing", Required = Required.AllowNull)]
        public VcenterVmHardwareEthernetBackingInfoTypeA Backing { get; set; }
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
