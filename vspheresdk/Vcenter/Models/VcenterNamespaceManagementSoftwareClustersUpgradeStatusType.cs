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
    public class VcenterNamespaceManagementSoftwareClustersUpgradeStatusType 
    {
        /// <summary>
        /// Desired version the cluster will be upgraded to.
        /// If unset, the cluster upgrade is not in progress.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "desired_version")]
        public string? DesiredVersion { get; set; }
        /// <summary>
        /// Current set of messages associated with the upgrade state.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementSoftwareClustersMessageType> Messages { get; set; }
        /// <summary>
        /// Information about upgrade progess.
        /// If unset, the cluster upgrade is not in progress.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress")]
        public VcenterNamespaceManagementSoftwareClustersUpgradeProgressType Progress { get; set; }
    }
}
