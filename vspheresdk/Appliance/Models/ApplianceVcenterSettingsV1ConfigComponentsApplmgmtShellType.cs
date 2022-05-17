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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtShellType 
    {
        /// <summary>
        /// Enabled can be set to true or false
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The timeout (in seconds) specifies how long you enable the Shell access. The maximum timeout is 86400 seconds(1 day).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "timeout", Required = Required.AllowNull)]
        public long Timeout { get; set; }
    }
}
