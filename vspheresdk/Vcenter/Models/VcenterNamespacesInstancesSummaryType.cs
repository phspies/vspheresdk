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
    public class VcenterNamespacesInstancesSummaryType 
    {
        /// <summary>
        /// Identifier for the vSphere cluster hosting the namespace.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Identifier of the namespace.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace", Required = Required.AllowNull)]
        public string NamespaceProperty { get; set; }
        /// <summary>
        /// Description of the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description", Required = Required.AllowNull)]
        public string Description { get; set; }
        /// <summary>
        /// Current setting for Instances.ConfigStatus.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config_status", Required = Required.AllowNull)]
        public VcenterNamespacesInstancesConfigStatusType ConfigStatus { get; set; }
        /// <summary>
        /// Basic runtime statistics for the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "stats", Required = Required.AllowNull)]
        public VcenterNamespacesInstancesStatsType Stats { get; set; }
        /// <summary>
        /// Flag to indicate the self service namespace.
        /// If unset, the namespace is not marked as self service namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "self_service_namespace")]
        public bool? SelfServiceNamespace { get; set; }
    }
}
