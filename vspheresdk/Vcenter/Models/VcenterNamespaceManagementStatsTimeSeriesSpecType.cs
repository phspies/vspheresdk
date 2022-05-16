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
    public class VcenterNamespaceManagementStatsTimeSeriesSpecType 
    {
        /// <summary>
        /// Type of statistics object that the request is operating on.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "obj_type", Required = Required.AllowNull)]
        public VcenterNamespaceManagementStatsTimeSeriesSpecObjType ObjType { get; set; }
        /// <summary>
        /// Pod Identifier for queries on an individual pod.
        /// This field is optional and it is only relevant when the value of TimeSeries.Spec.obj-type is POD.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pod")]
        public VcenterNamespaceManagementStatsTimeSeriesPodIdentifierType Pod { get; set; }
        /// <summary>
        /// Namespace name for queries for a namespace.
        /// This field is optional and it is only relevant when the value of TimeSeries.Spec.obj-type is NAMESPACE.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string? NamespaceProperty { get; set; }
        /// <summary>
        /// Cluster identifier for queries for a cluster.
        /// This field is optional and it is only relevant when the value of TimeSeries.Spec.obj-type is CLUSTER.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// UNIX timestamp value indicating when the requested series of statistical samples should begin.
        /// https://en.wikipedia.org/wiki/Unix_time
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start", Required = Required.AllowNull)]
        public long Start { get; set; }
        /// <summary>
        /// UNIX timestamp value indicating when the requested series of statistical samples should end.
        /// https://en.wikipedia.org/wiki/Unix_time
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end", Required = Required.AllowNull)]
        public long End { get; set; }
    }
}
