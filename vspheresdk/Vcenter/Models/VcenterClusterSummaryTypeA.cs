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
    public class VcenterClusterSummaryTypeA 
    {
        /// <summary>
        /// Identifier of the cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Name of the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Flag indicating whether the vSphere HA feature is enabled for the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_enabled", Required = Required.AllowNull)]
        public bool HaEnabled { get; set; }
        /// <summary>
        /// Flag indicating whether the vSphere DRS service is enabled for the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "drs_enabled", Required = Required.AllowNull)]
        public bool DrsEnabled { get; set; }
    }
}
