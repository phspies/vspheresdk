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
    public class VcenterVmHardwareBootDeviceEntryCreateSpecTypeA 
    {
        /// <summary>
        /// Virtual Boot device type.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterVmHardwareBootDeviceTypeA Type { get; set; }
    }
}
