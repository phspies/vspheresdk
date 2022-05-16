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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersFilterSpecType 
    {
        /// <summary>
        /// Identifies the cluster.
        /// cluster If {@term.unset} return all Trust Authority Clusters.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public IList<string> Cluster { get; set; }
        /// <summary>
        /// The state of the TrustAuthorityClusters.
        /// state If {@term.unset} return all Trust Authority Clusters.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public Dictionary<string,VcenterTrustedInfrastructureTrustAuthorityClustersStateType> State { get; set; }
    }
}
