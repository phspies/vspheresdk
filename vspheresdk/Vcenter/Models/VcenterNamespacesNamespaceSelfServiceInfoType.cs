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
    public class VcenterNamespacesNamespaceSelfServiceInfoType 
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
        public VcenterNamespacesNamespaceSelfServiceCapabilityType Capability { get; set; }
        /// <summary>
        /// The current status of the namespace-self-service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public VcenterNamespacesNamespaceSelfServiceStatusType Status { get; set; }
        /// <summary>
        /// Current set of messages associated with the object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespacesInstancesMessageType> Messages { get; set; }
    }
}
