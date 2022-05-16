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
    public class VcenterNamespacesInstancesNetworkCreateSpecType 
    {
        /// <summary>
        /// The network provider that will manage the vSphere Namespaces network object.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network_provider", Required = Required.AllowNull)]
        public VcenterNamespacesInstancesNetworkProviderType NetworkProvider { get; set; }
        /// <summary>
        /// The create spec for an NSXT-backed Namespaces network configuration, supported by NSXT_CONTAINER_PLUGIN network
        /// provider.
        /// This field is optional and it is only relevant when the value of Instances.NetworkCreateSpec.network-provider is
        /// NSXT_CONTAINER_PLUGIN.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public VcenterNamespacesInstancesNsxNetworkCreateSpecType Network { get; set; }
    }
}
