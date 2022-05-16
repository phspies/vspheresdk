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
    public class VcenterNamespaceManagementEdgeClusterCompatibilityFilterSpecType 
    {
        /// <summary>
        /// Compatibility criteria for matching the filter. If true, only Edge Clusters which are compatible with vSphere Namespaces
        /// match the filter. If false, only Edge Clusters which are incompatible with vSphere Namespaces match the filter.
        /// If unset, both compatible and incompatible Edge Clusters match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible")]
        public bool? Compatible { get; set; }
    }
}
