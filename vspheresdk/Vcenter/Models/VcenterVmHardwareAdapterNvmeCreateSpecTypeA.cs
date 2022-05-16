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
    public class VcenterVmHardwareAdapterNvmeCreateSpecTypeA 
    {
        /// <summary>
        /// NVMe bus number.
        /// If unset, the server will choose an available bus number; if none is available, the request will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bus")]
        public long? Bus { get; set; }
        /// <summary>
        /// Address of the NVMe adapter on the PCI bus.
        /// If unset, the server will choose an available address when the virtual machine is powered on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pci_slot_number")]
        public long? PciSlotNumber { get; set; }
    }
}
