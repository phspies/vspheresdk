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
    public class VcenterVmHardwareSataAddressInfoTypeA 
    {
        /// <summary>
        /// Bus number of the adapter to which the device is attached.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "bus", Required = Required.AllowNull)]
        public long Bus { get; set; }
        /// <summary>
        /// Unit number of the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "unit", Required = Required.AllowNull)]
        public long Unit { get; set; }
    }
}
