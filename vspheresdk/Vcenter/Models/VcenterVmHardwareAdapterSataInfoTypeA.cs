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
    public class VcenterVmHardwareAdapterSataInfoTypeA 
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
        public VcenterVmHardwareAdapterSataTypeEnumA Type { get; set; }
        /// <summary>
        /// SATA bus number.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bus", Required = Required.AllowNull)]
        public long Bus { get; set; }
        /// <summary>
        /// Address of the SATA adapter on the PCI bus.
        /// May be unset if the virtual machine has never been powered on since the adapter was created.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_slot_number")]
        public long? PciSlotNumber { get; set; }
    }
}
