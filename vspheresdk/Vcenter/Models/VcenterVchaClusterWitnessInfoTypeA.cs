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
    public class VcenterVchaClusterWitnessInfoTypeA 
    {
        /// <summary>
        /// VCHA Cluster network configuration of the node. All cluster communication (state replication, heartbeat, cluster
        /// messages) happens over this network.
        /// The active node's management vCenter server credentials are not required to populate Cluster.WitnessInfo.ha-ip.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_ip", Required = Required.AllowNull)]
        public VcenterVchaClusterIpInfoTypeA HaIp { get; set; }
        /// <summary>
        /// Runtime information for the node in the VCHA Cluster.
        /// The active node's management vCenter server credentials are required to populate some fields of
        /// Cluster.WitnessInfo.runtime.
        /// If unset, then the information is unavailable or the node is not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "runtime")]
        public VcenterVchaClusterNodeRuntimeInfoTypeA Runtime { get; set; }
    }
}
