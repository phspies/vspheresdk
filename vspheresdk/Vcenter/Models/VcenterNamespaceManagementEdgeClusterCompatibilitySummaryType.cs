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
    public class VcenterNamespaceManagementEdgeClusterCompatibilitySummaryType 
    {
        /// <summary>
        /// Identifier of the Edge Cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// NSXEdgeCluster. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: NSXEdgeCluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster", Required = Required.AllowNull)]
        public string EdgeCluster { get; set; }
        /// <summary>
        /// Display name of the Edge Cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name", Required = Required.AllowNull)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Compatibility of this Edge Cluster with Namespaces feature.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible", Required = Required.AllowNull)]
        public bool Compatible { get; set; }
        /// <summary>
        /// List of reasons for incompatibility.
        /// If unset, this Edge Cluster is compatible.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "incompatibility_reasons")]
        public Dictionary<string,VapiStdLocalizableMessageType> IncompatibilityReasons { get; set; }
    }
}
