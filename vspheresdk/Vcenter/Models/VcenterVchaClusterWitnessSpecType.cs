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
    public class VcenterVchaClusterWitnessSpecType 
    {
        /// <summary>
        /// Contains the placement configuration of the node.
        /// If unset, then it is assumed that the clone will be done manually by the customer. In this case, the placement
        /// configuration for the witness node should also be omitted. Only the network configuration will be setup. Once the
        /// passive and witness nodes are cloned from the active node, the VCHA high availability is turned on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVchaPlacementSpecType Placement { get; set; }
        /// <summary>
        /// IP specification for the HA network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_ip", Required = Required.AllowNull)]
        public VcenterVchaIpSpecType HaIp { get; set; }
    }
}
