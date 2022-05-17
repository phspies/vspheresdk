using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsHardwareModuleDetailsType 
    {
        /// <summary>
        /// Class of module (BIOS, PCI Device, non-PCI hardware, etc.)
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "component_class", Required = Required.AllowNull)]
        public EsxSettingsHardwareModuleClassEnumType ComponentClass { get; set; }
        /// <summary>
        /// Descipription of the hardware module (e.g. "System BIOS" or "Frobozz 100Gb NIC").
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
