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
    public class VcenterNamespaceManagementSoftwareClustersResultType 
    {
        /// <summary>
        /// The result of batch upgrade method.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "res", Required = Required.AllowNull)]
        public VcenterNamespaceManagementSoftwareClustersResultResType Res { get; set; }
        /// <summary>
        /// Exception when cluster pre-check failed during upgrade invocation.
        /// This field is optional and it is only relevant when the value of Clusters.Result.res is REJECTED.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "exception")]
        public string? Exception { get; set; }
    }
}
