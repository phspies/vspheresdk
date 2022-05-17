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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtAccessSettingsType 
    {
        /// <summary>
        /// Get/Set enabled state of SSH-based controlled CLI. Ssh service provides operations
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssh")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtSshType Ssh { get; set; }
        /// <summary>
        /// Get/Set enabled of Direct Console User Interface (DCUI TTY2). Dcui service provides operations
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "dcui")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtDcuiType Dcui { get; set; }
        /// <summary>
        /// Get/Set enabled state of the console-based controlled CLI. Consolecli service provides operations
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "console_cli")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtConsolecliType ConsoleCli { get; set; }
        /// <summary>
        /// Get/Set enabled state of BASH. Shell service provides operations
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "shell")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtShellType Shell { get; set; }
    }
}
