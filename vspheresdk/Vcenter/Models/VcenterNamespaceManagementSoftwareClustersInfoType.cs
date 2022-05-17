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
    public class VcenterNamespaceManagementSoftwareClustersInfoType 
    {
        /// <summary>
        /// Current version of the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "current_version", Required = Required.AllowNull)]
        public string CurrentVersion { get; set; }
        /// <summary>
        /// Set of available versions can be upgraded to.
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
        /// Current set of messages associated with the cluster version.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementSoftwareClustersMessageType> Messages { get; set; }
        /// <summary>
        /// Current state of the upgrade.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSoftwareClustersStateEnumType State { get; set; }
        /// <summary>
        /// Information about upgrade in progress.
        /// If unset, the cluster upgrade is not in progress.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_status")]
        public VcenterNamespaceManagementSoftwareClustersUpgradeStatusType UpgradeStatus { get; set; }
    }
}
