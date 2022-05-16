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
    public class VcenterNamespaceManagementNetworksVsphereDvpgnetworkSetSpecType 
    {
        /// <summary>
        /// Identifier of the vSphere Distributed Portgroup backing the vSphere network object. If the network object is associated
        /// with a Namespace or is Clusters.WorkloadNetworksEnableSpec.supervisor-primary-workload-network, modification to existing
        /// portgroup will result in the operation failing with a ResourceInUse error.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// Network. When operations return a value of this structure as a result, the field will be an identifier for the resource
        /// type: Network.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "portgroup", Required = Required.AllowNull)]
        public string Portgroup { get; set; }
        /// <summary>
        /// Usable IP pools on this network. If the network object is associated with a Namespace or is
        /// Clusters.WorkloadNetworksEnableSpec.supervisor-primary-workload-network, then replacement of or modification to any
        /// existing range in this list will result in operation failing with a ResourceInUse error. To add new address ranges to
        /// the list, existing address ranges have to be passed in without modifications.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_ranges", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIprangeType> AddressRanges { get; set; }
        /// <summary>
        /// Gateway for the network. If the network object is associated with a Namespace or is
        /// Clusters.WorkloadNetworksEnableSpec.supervisor-primary-workload-network, then modification to existing gateway will
        /// result in the operation failing with a ResourceInUse error.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "gateway", Required = Required.AllowNull)]
        public string Gateway { get; set; }
        /// <summary>
        /// Subnet mask of the network. If the network object is associated with a Namespace or is
        /// Clusters.WorkloadNetworksEnableSpec.supervisor-primary-workload-network, then modification to existing subnet mask will
        /// result in the operation failing with a ResourceInUse error.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subnet_mask", Required = Required.AllowNull)]
        public string SubnetMask { get; set; }
    }
}
