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
    public class VcenterLcmDiscoveryInteropReportCreateTaskType 
    {
        /// <summary>
        /// The vCenter Server version.
        /// It is used for checking against the other products registered with that instance of vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "target_version", Required = Required.AllowNull)]
        public string TargetVersion { get; set; }
    }
}
