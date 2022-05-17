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
    public class VcenterVmHardwareAdapterScsiUpdateType 
    {
        /// <summary>
        /// Bus sharing mode.
        /// This field may only be modified if the virtual machine is not powered on.
        /// 
        /// If unset, the value is unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sharing")]
        public VcenterVmHardwareAdapterScsiSharingEnumType Sharing { get; set; }
    }
}
