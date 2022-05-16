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
    public class VcenterVmTemplateLibraryItemsHardwareCustomizationSpecTypeA 
    {
        /// <summary>
        /// Map of Ethernet network adapters to update.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nics")]
        public IList<object> Nics { get; set; }
        /// <summary>
        /// Idenfiers of disks to remove from the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks_to_remove")]
        public IList<string> DisksToRemove { get; set; }
        /// <summary>
        /// Disk update specification for individual disks in the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "disks_to_update")]
        public IList<object> DisksToUpdate { get; set; }
        /// <summary>
        /// CPU update specification for the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cpu_update")]
        public VcenterVmTemplateLibraryItemsCpuUpdateSpecTypeA CpuUpdate { get; set; }
        /// <summary>
        /// Memory update specification for the deployed virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "memory_update")]
        public VcenterVmTemplateLibraryItemsMemoryUpdateSpecTypeA MemoryUpdate { get; set; }
    }
}
