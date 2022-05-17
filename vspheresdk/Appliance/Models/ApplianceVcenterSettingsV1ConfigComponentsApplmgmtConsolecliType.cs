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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtConsolecliType 
    {
        /// <summary>
        /// Set enabled state of the console-based controlled CLI (TTY1).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
