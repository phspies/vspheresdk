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
    public class VcenterVmToolsInstallerInfoTypeA 
    {
        /// <summary>
        /// Flag indicating whether the VMware Tools installer is mounted as a CD-ROM.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_connected", Required = Required.AllowNull)]
        public bool IsConnected { get; set; }
    }
}
