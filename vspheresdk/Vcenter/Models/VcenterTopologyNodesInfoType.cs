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
    public class VcenterTopologyNodesInfoType 
    {
        /// <summary>
        /// Domain name of the node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain", Required = Required.AllowNull)]
        public string Domain { get; set; }
        /// <summary>
        /// Appliance type of the node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterTopologyNodesApplianceTypeEnum Type { get; set; }
        /// <summary>
        /// List of replication partners' node identifiers. Identifiers can be either IP address or DNS resolvable name of the
        /// partner node.
        /// This field is optional and it is only relevant when the value of Nodes.Info.type is one of VCSA_EMBEDDED or
        /// PSC_EXTERNAL.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.VCenter.name. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: vcenter.VCenter.name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "replication_partners")]
        public IList<string> ReplicationPartners { get; set; }
        /// <summary>
        /// Identifier of the affinitized Platform Services Controller node. Identifier can be either IP address or DNS resolvable
        /// name of the affinitized node.
        /// This field is optional and it is only relevant when the value of Nodes.Info.type is VCSA_EXTERNAL.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.VCenter.name. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vcenter.VCenter.name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "client_affinity")]
        public string? ClientAffinity { get; set; }
    }
}
