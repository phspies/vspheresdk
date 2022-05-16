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
    public class VcenterNamespaceManagementStatsTimeSeriesPodIdentifierType 
    {
        /// <summary>
        /// The namespace that the pod is running in.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespaces.Instance. When operations return a value of this structure as a result, the field will be an
        /// identifier for the resource type: vcenter.namespaces.Instance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace", Required = Required.AllowNull)]
        public string NamespaceProperty { get; set; }
        /// <summary>
        /// The name of the pod itself.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "pod_name", Required = Required.AllowNull)]
        public string PodName { get; set; }
    }
}
