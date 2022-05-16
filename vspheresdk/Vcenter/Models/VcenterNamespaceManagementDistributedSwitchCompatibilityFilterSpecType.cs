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
    public class VcenterNamespaceManagementDistributedSwitchCompatibilityFilterSpecType 
    {
        /// <summary>
        /// Compatibility criteria for matching the filter. If true, only Distributed Switches which are compatible with vSphere
        /// Namespaces match the filter. If false, only Distributed Switches which are incompatible with vSphere Namespaces match
        /// the filter.
        /// If unset, both compatible and incompatible Distributed Switches match the filter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible")]
        public bool? Compatible { get; set; }
        /// <summary>
        /// The network provider whose networks will be considered. If unset, this will default to NSXT_CONTAINER_PLUGIN.
        /// This field is optional because it was added in a newer version than its parent node.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider")]
        public VcenterNamespaceManagementClustersNetworkProviderType NetworkProvider { get; set; }
    }
}
