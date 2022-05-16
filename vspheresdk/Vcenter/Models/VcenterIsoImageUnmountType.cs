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
    public class VcenterIsoImageUnmountType 
    {
        /// <summary>
        /// The identifier of the virtual machine from which to unmount the virtual CD-ROM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vm", Required = Required.AllowNull)]
        public string Vm { get; set; }
        /// <summary>
        /// The device identifier of the CD-ROM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cdrom", Required = Required.AllowNull)]
        public string Cdrom { get; set; }
    }
}
