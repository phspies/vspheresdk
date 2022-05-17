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
    public class VcenterVmHardwareEthernetCreateType 
    {
        /// <summary>
        /// Ethernet adapter emulation type.
        /// If unset, defaults to a guest-specific type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterVmHardwareEthernetEmulationTypeEnum Type { get; set; }
        /// <summary>
        /// Flag indicating whether Universal Pass-Through (UPT) compatibility is enabled on this virtual Ethernet adapter.
        /// If unset, defaults to false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upt_compatibility_enabled")]
        public bool? UptCompatibilityEnabled { get; set; }
        /// <summary>
        /// MAC address type.
        /// If unset, defaults to GENERATED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_type")]
        public VcenterVmHardwareEthernetMacAddressTypeEnum MacType { get; set; }
        /// <summary>
        /// MAC address.
        /// Workaround for PR1459647
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mac_address")]
        public string? MacAddress { get; set; }
        /// <summary>
        /// Address of the virtual Ethernet adapter on the PCI bus. If the PCI address is invalid, the server will change when it
        /// the VM is started or as the device is hot added.
        /// If unset, the server will choose an available address when the virtual machine is powered on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_slot_number")]
        public long? PciSlotNumber { get; set; }
        /// <summary>
        /// Flag indicating whether wake-on-LAN is enabled on this virtual Ethernet adapter.
        /// Defaults to false if unset.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "wake_on_lan_enabled")]
        public bool? WakeOnLanEnabled { get; set; }
        /// <summary>
        /// Physical resource backing for the virtual Ethernet adapter.
        /// If unset, the system may try to find an appropriate backing. If one is not found, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backing")]
        public VcenterVmHardwareEthernetBackingSpecType Backing { get; set; }
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
