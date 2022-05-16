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
    public class VcenterVmHardwareAdapterScsiUpdateTypeA 
    {
        /// <summary>
        /// Specification for updating the virtual SCSI adapter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "spec", Required = Required.AllowNull)]
        public VcenterVmHardwareAdapterScsiUpdateSpecTypeA Spec { get; set; }
    }
}
