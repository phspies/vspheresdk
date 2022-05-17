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
    public class VcenterVmHardwareAdapterSataCreateSpecType 
    {
        /// <summary>
        /// Adapter type.
        /// If unset, a guest-specific default value will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterVmHardwareAdapterSataTypeEnum Type { get; set; }
        /// <summary>
        /// SATA bus number.
        /// If unset, the server will choose an available bus number; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bus")]
        public long? Bus { get; set; }
        /// <summary>
        /// Address of the SATA adapter on the PCI bus.
        /// If unset, the server will choose an available address when the virtual machine is powered on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_slot_number")]
        public long? PciSlotNumber { get; set; }
    }
}
