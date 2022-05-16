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
    public class VcenterNamespaceManagementVirtualMachineClassesVgpudeviceType 
    {
        /// <summary>
        /// Profile name corresponding to the device.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "profile_name", Required = Required.AllowNull)]
        public string ProfileName { get; set; }
    }
}
