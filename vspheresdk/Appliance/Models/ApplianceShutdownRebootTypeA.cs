using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceShutdownRebootTypeA 
    {
        /// <summary>
        /// Minutes after which reboot should start. If 0 is specified, reboot will start immediately.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "delay", Required = Required.AllowNull)]
        public long Delay { get; set; }
        /// <summary>
        /// Reason for peforming reboot.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "reason", Required = Required.AllowNull)]
        public string Reason { get; set; }
    }
}
