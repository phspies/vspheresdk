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
    public class VcenterClusterFilterSpecTypeA 
    {
        /// <summary>
        /// Identifiers of clusters that can match the filter.
        /// If unset or empty, clusters with any identifier match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<string> Clusters { get; set; }
        /// <summary>
        /// Names that clusters must have to match the filter (see Cluster.Info.name).
        /// If unset or empty, clusters with any name match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "names")]
        public IList<string> Names { get; set; }
        /// <summary>
        /// Folders that must contain the cluster for the cluster to match the filter.
        /// If unset or empty, clusters in any folder match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Folder. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Folder.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "folders")]
        public IList<string> Folders { get; set; }
        /// <summary>
        /// Datacenters that must contain the cluster for the cluster to match the filter.
        /// If unset or empty, clusters in any datacenter match the filter.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Datacenter. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Datacenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "datacenters")]
        public IList<string> Datacenters { get; set; }
    }
}
