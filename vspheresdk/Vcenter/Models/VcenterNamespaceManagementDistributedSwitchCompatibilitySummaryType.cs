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
    public class VcenterNamespaceManagementDistributedSwitchCompatibilitySummaryType 
    {
        /// <summary>
        /// Identifier of the switch. If DistributedSwitchCompatibility.Summary.network-provider is either unset or is set to
        /// NSXT_CONTAINER_PLUGIN, the value of this field will refer to the UUID of a vim.DistributedVirtualSwitch. Otherwise, the
        /// value of the field will refer to the ID of a vim.DistributedVirtualSwitch.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vSphereDistributedSwitch. When operations return a value of this structure as a result, the field will be an identifier
        /// for the resource type: vSphereDistributedSwitch.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "distributed_switch", Required = Required.AllowNull)]
        public string DistributedSwitch { get; set; }
        /// <summary>
        /// Compatibility of this switch with vSphere Namespaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible", Required = Required.AllowNull)]
        public bool Compatible { get; set; }
        /// <summary>
        /// List of reasons for incompatibility.
        /// If unset, this Distributed Switch is compatible.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "incompatibility_reasons")]
        public Dictionary<string,VapiStdLocalizableMessageType> IncompatibilityReasons { get; set; }
        /// <summary>
        /// The network provider whose networks were considered.
        /// If unset, clients clients should assume the value to be NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider")]
        public VcenterNamespaceManagementClustersNetworkProviderEnumType NetworkProvider { get; set; }
        /// <summary>
        /// List of compatible (PortGroup) Networks under the distributed switch.
        /// This field is optional because it was added in a newer version than its parent node.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// Network. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "compatible_networks")]
        public IList<string> CompatibleNetworks { get; set; }
    }
}
