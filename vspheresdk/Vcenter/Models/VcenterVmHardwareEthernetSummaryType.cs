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
    public class VcenterVmHardwareEthernetSummaryType 
    {
        /// <summary>
        /// Identifier of the virtual Ethernet adapter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.vm.hardware.Ethernet. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.vm.hardware.Ethernet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nic", Required = Required.AllowNull)]
        public string Nic { get; set; }
    }
}
