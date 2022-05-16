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
    public class VcenterTopologyReplicationStatusSummaryTypeA 
    {
        /// <summary>
        /// Identifier for the vCenter or Platform Services Controller node. Identifier can be either IP address or DNS resolvable
        /// name of the node.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.VCenter.name. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vcenter.VCenter.name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "node", Required = Required.AllowNull)]
        public string Node { get; set; }
        /// <summary>
        /// Identifier for the vCenter or Platform Services Controller replication partner. Identifier can be either IP address or
        /// DNS resolvable name of the replication partner.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.VCenter.name. When operations return a value of this structure as a result, the field will be an identifier for
        /// the resource type: vcenter.VCenter.name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "replication_partner", Required = Required.AllowNull)]
        public string ReplicationPartner { get; set; }
        /// <summary>
        /// Indicates if the VMware Directory Service on partner is reachable or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "partner_available", Required = Required.AllowNull)]
        public bool PartnerAvailable { get; set; }
        /// <summary>
        /// Indicates if the replication status for the node with respect to replication partner can be retrieved or not.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status_available", Required = Required.AllowNull)]
        public bool StatusAvailable { get; set; }
        /// <summary>
        /// Indicates if node is processing replication changes from the replication partner.
        /// This field will be unset if the partner host or replication status is not available, i.e, if
        /// ReplicationStatus.Summary.partner-available or ReplicationStatus.Summary.status-available is false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "replicating")]
        public bool? Replicating { get; set; }
        /// <summary>
        /// Number of replication changes node is behind the replication partner.
        /// This field will be unset if the partner host or replication status is not available, i.e, if
        /// ReplicationStatus.Summary.partner-available or ReplicationStatus.Summary.status-available is false.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "change_lag")]
        public long? ChangeLag { get; set; }
    }
}
