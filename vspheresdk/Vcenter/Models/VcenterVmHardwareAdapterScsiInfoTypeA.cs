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
    public class VcenterVmHardwareAdapterScsiInfoTypeA 
    {
        /// <summary>
        /// Device label.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        public string Label { get; set; }
        /// <summary>
        /// Adapter type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareAdapterScsiTypeA Type { get; set; }
        /// <summary>
        /// Address of the SCSI adapter on the SCSI bus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "scsi", Required = Required.AllowNull)]
        public VcenterVmHardwareScsiAddressInfoTypeA Scsi { get; set; }
        /// <summary>
        /// Address of the SCSI adapter on the PCI bus. If the PCI address is invalid, the server will change it when the VM is
        /// started or as the device is hot added.
        /// May be unset if the virtual machine has never been powered on since the adapter was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_slot_number")]
        public long? PciSlotNumber { get; set; }
        /// <summary>
        /// Bus sharing mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharing", Required = Required.AllowNull)]
        public VcenterVmHardwareAdapterScsiSharingTypeA Sharing { get; set; }
    }
}
