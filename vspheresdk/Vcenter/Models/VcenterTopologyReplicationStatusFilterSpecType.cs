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
    public class VcenterTopologyReplicationStatusFilterSpecType 
    {
        /// <summary>
        /// Identifier that a vCenter and Platform Services Controller node must have to match the filter. (see
        /// ReplicationStatus.Summary.node).
        /// If unset or empty, all vCenter and Platform Services Controller nodes of type VCSA_EMBEDDED/PSC_EXTERNAL match the
        /// filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.VCenter.name. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: vcenter.VCenter.name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "nodes")]
        public IList<string> Nodes { get; set; }
    }
}
