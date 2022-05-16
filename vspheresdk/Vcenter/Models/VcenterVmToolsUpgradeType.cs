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
    public class VcenterVmToolsUpgradeType 
    {
        /// <summary>
        /// Command line options passed to the installer to modify the installation procedure for Tools.
        /// Set if any additional options are desired.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "command_line_options")]
        public string? CommandLineOptions { get; set; }
    }
}
