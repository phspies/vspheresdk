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
    public class VcenterVmHardwareFloppySummaryType 
    {
        /// <summary>
        /// Identifier of the virtual floppy drive.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.vm.hardware.Floppy. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.vm.hardware.Floppy.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "floppy", Required = Required.AllowNull)]
        public string Floppy { get; set; }
    }
}
