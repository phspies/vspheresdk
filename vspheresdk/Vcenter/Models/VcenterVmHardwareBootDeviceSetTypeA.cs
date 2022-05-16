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
    public class VcenterVmHardwareBootDeviceSetTypeA 
    {
        /// <summary>
        /// Ordered list of boot devices.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "devices", Required = Required.AllowNull)]
        public Dictionary<string,VcenterVmHardwareBootDeviceEntryTypeA> Devices { get; set; }
    }
}
