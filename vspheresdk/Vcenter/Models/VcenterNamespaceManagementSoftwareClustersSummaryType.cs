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
    public class VcenterNamespaceManagementSoftwareClustersSummaryType 
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
        /// Current version of the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_version", Required = Required.AllowNull)]
        public string CurrentVersion { get; set; }
        /// <summary>
        /// Set of versions available for upgrade.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "available_versions", Required = Required.AllowNull)]
        public IList<string> AvailableVersions { get; set; }
        /// <summary>
        /// Date of last successful upgrade.
        /// If unset, the cluster has not yet been upgraded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_upgraded_date")]
        public DateTime? LastUpgradedDate { get; set; }
        /// <summary>
        /// Desired version the cluster will be upgraded to.
        /// If unset, the cluster upgrade is not in progress.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_version")]
        public string? DesiredVersion { get; set; }
        /// <summary>
        /// Current state of the upgrade.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSoftwareClustersStateType State { get; set; }
    }
}
