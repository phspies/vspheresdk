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
    public class VcenterVmHardwareIdeAddressInfoTypeA 
    {
        /// <summary>
        /// Flag specifying whether the device is attached to the primary or secondary IDE adapter of the virtual machine.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "primary", Required = Required.AllowNull)]
        public bool Primary { get; set; }
        /// <summary>
        /// Flag specifying whether the device is the master or slave device on the IDE adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "master", Required = Required.AllowNull)]
        public bool Master { get; set; }
    }
}
