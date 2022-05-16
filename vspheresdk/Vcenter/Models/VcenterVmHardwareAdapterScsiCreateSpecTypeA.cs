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
    public class VcenterVmHardwareAdapterScsiCreateSpecTypeA 
    {
        /// <summary>
        /// Adapter type.
        /// If unset, a guest-specific default value will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterVmHardwareAdapterScsiTypeA Type { get; set; }
        /// <summary>
        /// SCSI bus number.
        /// If unset, the server will choose an available bus number; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bus")]
        public long? Bus { get; set; }
        /// <summary>
        /// Address of the SCSI adapter on the PCI bus. If the PCI address is invalid, the server will change it when the VM is
        /// started or as the device is hot added.
        /// If unset, the server will choose an available address when the virtual machine is powered on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_slot_number")]
        public long? PciSlotNumber { get; set; }
        /// <summary>
        /// Bus sharing mode.
        /// If unset, the adapter will default to NONE.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharing")]
        public VcenterVmHardwareAdapterScsiSharingTypeA Sharing { get; set; }
    }
}
