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
    public class VcenterVchaClusterModeSetTaskTypeA 
    {
        /// <summary>
        /// Clustermode to change the VCHA cluster mode to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public VcenterVchaClusterModeClusterModeEnumTypeA Mode { get; set; }
    }
}
