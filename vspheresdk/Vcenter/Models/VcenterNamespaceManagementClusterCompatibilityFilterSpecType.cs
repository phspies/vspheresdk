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
    public class VcenterNamespaceManagementClusterCompatibilityFilterSpecType 
    {
        /// <summary>
        /// Set this flag to true to only list vSphere clusters that are currently compatible with the Namespaces feature. If set to
        /// false, both compatible and incompatible vSphere clusters will be listed.
        /// If unset, both compatible and incompatible vSphere clusters will be listed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible")]
        public bool? Compatible { get; set; }
        /// <summary>
        /// The network provider whose networks will be considered.
        /// If unset, this will default to NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider")]
        public VcenterNamespaceManagementClustersNetworkProviderEnumType NetworkProvider { get; set; }
    }
}
