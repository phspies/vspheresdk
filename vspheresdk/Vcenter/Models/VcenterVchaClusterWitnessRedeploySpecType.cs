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
    public class VcenterVchaClusterWitnessRedeploySpecType 
    {
        /// <summary>
        /// Contains the active node's management vCenter server credentials.
        /// If unset, then the active vCenter Server instance is assumed to be either self-managed or else in enhanced linked mode
        /// and managed by a linked vCenter Server instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "vc_spec")]
        public VcenterVchaCredentialsSpecType VcSpec { get; set; }
        /// <summary>
        /// Contains the node's placement information.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement", Required = Required.AllowNull)]
        public VcenterVchaPlacementSpecType Placement { get; set; }
        /// <summary>
        /// Contains the VCHA HA network configuration of the node. All cluster communication (state replication, heartbeat, cluster
        /// messages) happens over this network.
        /// If unset, then the stored network configuration for the VCHA HA network for the witness node will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_ip")]
        public VcenterVchaIpSpecType HaIp { get; set; }
    }
}
