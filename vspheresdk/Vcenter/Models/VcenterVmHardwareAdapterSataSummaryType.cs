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
    public class VcenterVmHardwareAdapterSataSummaryType 
    {
        /// <summary>
        /// Identifier of the virtual SATA adapter.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.vm.hardware.SataAdapter. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.vm.hardware.SataAdapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "adapter", Required = Required.AllowNull)]
        public string Adapter { get; set; }
    }
}
