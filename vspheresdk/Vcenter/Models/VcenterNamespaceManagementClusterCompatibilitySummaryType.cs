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
    public class VcenterNamespaceManagementClusterCompatibilitySummaryType 
    {
        /// <summary>
        /// Identifier of the vSphere cluster.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// Compatibility of this vSphere cluster. If false, the list of incompatibility issues will be given in the
        /// ClusterCompatibility.Summary.incompatibility-reasons field.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible", Required = Required.AllowNull)]
        public bool Compatible { get; set; }
        /// <summary>
        /// Reasons for incompatibility.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "incompatibility_reasons", Required = Required.AllowNull)]
        public Dictionary<string,VapiStdLocalizableMessageType> IncompatibilityReasons { get; set; }
    }
}
