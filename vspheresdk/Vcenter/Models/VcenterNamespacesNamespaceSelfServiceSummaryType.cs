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
    public class VcenterNamespacesNamespaceSelfServiceSummaryType 
    {
        /// <summary>
        /// Identifier for the cluster to which namespace service is associated.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster", Required = Required.AllowNull)]
        public string Cluster { get; set; }
        /// <summary>
        /// The self-service namespace capability of the cluster with vSphere Namespaces enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "capability", Required = Required.AllowNull)]
        public VcenterNamespacesNamespaceSelfServiceCapabilityEnumType Capability { get; set; }
        /// <summary>
        /// The current status of the namespace-self-service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterNamespacesNamespaceSelfServiceStatusEnumType Status { get; set; }
    }
}
