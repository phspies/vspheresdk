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
    public class VcenterVchaClusterNodeRuntimeInfoTypeA 
    {
        /// <summary>
        /// Last known state of the node.
        /// The active node's management vCenter server credentials are not required to populate Cluster.NodeRuntimeInfo.state.
        /// If unset, then information is unavailable or the passive and witness nodes are not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public VcenterVchaClusterNodeStateEnumTypeA State { get; set; }
        /// <summary>
        /// Last known role of the node.
        /// The active node's management vCenter server credentials are not required to populate Cluster.NodeRuntimeInfo.role.
        /// If unset, then information is unavailable or the passive and witness nodes are not cloned yet.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public VcenterVchaClusterNodeRoleEnumTypeA Role { get; set; }
        /// <summary>
        /// Placement information of the node.
        /// The active node's management vCenter server credentials are required to populate most fields of
        /// Cluster.NodeRuntimeInfo.placement.
        /// If unset, then the information is unavailable or the specified Active vCenter server management credentials are invalid
        /// or the node is not cloned yet or the VCHA cluster was deployed in a manual fashion.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "placement")]
        public VcenterVchaPlacementInfoTypeA Placement { get; set; }
    }
}
