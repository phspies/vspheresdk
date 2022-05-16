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
    public class VcenterVmHardwareCdromSummaryType 
    {
        /// <summary>
        /// Identifier of the virtual CD-ROM device.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.vm.hardware.Cdrom. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: vcenter.vm.hardware.Cdrom.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cdrom", Required = Required.AllowNull)]
        public string Cdrom { get; set; }
    }
}
