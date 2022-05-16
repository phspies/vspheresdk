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
    public class VcenterVchaCredentialsSpecType 
    {
        /// <summary>
        /// Connection information for the management vCenter Server of the Active Node in a VCHA Cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active_location", Required = Required.AllowNull)]
        public VcenterVchaConnectionSpecType ActiveLocation { get; set; }
    }
}
