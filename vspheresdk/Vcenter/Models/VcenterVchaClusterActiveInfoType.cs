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
    public class VcenterVchaClusterActiveInfoType 
    {
        /// <summary>
        /// IP specification for the Management network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "management", Required = Required.AllowNull)]
        public VcenterVchaIpSpecType Management { get; set; }
        /// <summary>
        /// IP specification for the HA network.
        /// If unset, then the second NIC of the Active Node of the VCHA cluster is not configured.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha")]
        public VcenterVchaIpSpecType Ha { get; set; }
        /// <summary>
        /// Contains the placement information of the active node.
        /// If unset, the request specified that placement information of the active node should not be included.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVchaPlacementInfoType Placement { get; set; }
    }
}
