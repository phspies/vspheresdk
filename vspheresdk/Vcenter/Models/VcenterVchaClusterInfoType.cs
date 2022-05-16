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
    public class VcenterVchaClusterInfoType 
    {
        /// <summary>
        /// Configuration state of the VCHA cluster.
        /// The active node's management vCenter server credentials are not required to populate this field.
        /// If unset, then the information is unavailable.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_state")]
        public VcenterVchaClusterConfigStateType ConfigState { get; set; }
        /// <summary>
        /// Node configuration information for the VCHA cluster.
        /// If unset, then the information is unavailable.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "node1")]
        public VcenterVchaClusterNodeInfoType Node1 { get; set; }
        /// <summary>
        /// Node configuration information for the VCHA cluster.
        /// If unset, then the information is unavailable or the node is not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "node2")]
        public VcenterVchaClusterNodeInfoType Node2 { get; set; }
        /// <summary>
        /// Node configuration information for the VCHA cluster.
        /// If unset, then the information is unavailable or the node is not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "witness")]
        public VcenterVchaClusterWitnessInfoType Witness { get; set; }
        /// <summary>
        /// Operational mode of the VCHA Cluster.
        /// If unset, then the information is unavailable or the node is not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        public VcenterVchaClusterClusterModeType Mode { get; set; }
        /// <summary>
        /// Last known state of the VCHA Cluster.
        /// If unset, then the information is unavailable or the node is not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health_state")]
        public VcenterVchaClusterClusterStateType HealthState { get; set; }
        /// <summary>
        /// Health warning messages if the health information is unavailable.
        /// If unset, then the cluster is in a healthy state.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health_exception")]
        public Dictionary<string,VapiStdLocalizableMessageType> HealthException { get; set; }
        /// <summary>
        /// A collection of messages describing the reason for a non-healthy Cluster.
        /// If unset, then the cluster is in a healthy state.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health_warnings")]
        public Dictionary<string,VcenterVchaClusterErrorConditionType> HealthWarnings { get; set; }
        /// <summary>
        /// Specifies if manual failover is allowed.
        /// If unset, then the cluster state healthy and manual failover allowance in accordance with the cluster mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "manual_failover_allowed")]
        public bool? ManualFailoverAllowed { get; set; }
        /// <summary>
        /// Specifies if automatic failover is allowed.
        /// If unset, then the cluster state healthy and automatic failover allowance in accordance with the cluster mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "auto_failover_allowed")]
        public bool? AutoFailoverAllowed { get; set; }
    }
}
