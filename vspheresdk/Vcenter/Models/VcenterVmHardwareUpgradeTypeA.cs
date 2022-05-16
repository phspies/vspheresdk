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
    public class VcenterVmHardwareUpgradeTypeA 
    {
        /// <summary>
        /// New virtual machine version.
        /// If unset, defaults to the most recent virtual hardware version supported by the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public VcenterVmHardwareVersionTypeA Version { get; set; }
    }
}
