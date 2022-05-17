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
    public class VcenterNamespaceManagementClustersSummaryType 
    {
        /// <summary>
        /// Identifier for the cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Name of the cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource.name. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: ClusterComputeResource.name.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster_name", Required = Required.AllowNull)]
        public string ClusterName { get; set; }
        /// <summary>
        /// Basic runtime statistics for the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "stats", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersStatsType Stats { get; set; }
        /// <summary>
        /// Current setting for Clusters.ConfigStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersConfigStatusEnumType ConfigStatus { get; set; }
        /// <summary>
        /// Current setting for Clusters.KubernetesStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "kubernetes_status", Required = Required.AllowNull)]
        public VcenterNamespaceManagementClustersKubernetesStatusEnumType KubernetesStatus { get; set; }
    }
}
