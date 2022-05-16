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
    public class VcenterVchaClusterNodeInfoTypeA 
    {
        /// <summary>
        /// Failover IP address that this node will assume after the failover to serve client requests. Each failover node can have
        /// a different failover IP address.
        /// The active node's management vCenter server credentials are not required to populate Cluster.NodeInfo.failover-ip.
        /// If unset, then it will assume the public IP address of the Active vCenter Server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "failover_ip")]
        public VcenterVchaClusterIpInfoTypeA FailoverIp { get; set; }
        /// <summary>
        /// VCHA Cluster network configuration of the node. All cluster communication (state replication, heartbeat, cluster
        /// messages) happens over this network.
        /// The active node's management vCenter server credentials are not required to populate this Cluster.NodeInfo.ha-ip.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_ip", Required = Required.AllowNull)]
        public VcenterVchaClusterIpInfoTypeA HaIp { get; set; }
        /// <summary>
        /// Runtime information for the node in the VCHA Cluster.
        /// The active node's management vCenter server credentials are required to populate some fields of
        /// Cluster.NodeInfo.runtime.
        /// If unset, then the information is unavailable or the specified Active vCenter server management credentials are invalid
        /// or the node is not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "runtime")]
        public VcenterVchaClusterNodeRuntimeInfoTypeA Runtime { get; set; }
    }
}
