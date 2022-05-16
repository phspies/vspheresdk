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
    public class VcenterNamespaceManagementLoadBalancersInfoType 
    {
        /// <summary>
        /// An DNS compliant identifier for a load balancer, which can be used to query or configure the load balancer properties.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.LoadBalancerConfig. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: vcenter.namespace_management.LoadBalancerConfig.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// IP address range from which virtual servers are assigned their IPs.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_ranges", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIprangeType> AddressRanges { get; set; }
        /// <summary>
        /// Load balancer provider for the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementLoadBalancersProviderType Provider { get; set; }
        /// <summary>
        /// The LoadBalancers.HAProxyInfo is a conditional configuration made available upon selecting the HA_PROXY load balancer
        /// provider. It is used to configure the load balancer at run time.
        /// This field is optional and it is only relevant when the value of LoadBalancers.Info.provider is HA_PROXY.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_proxy_info")]
        public VcenterNamespaceManagementLoadBalancersHaproxyInfoType HaProxyInfo { get; set; }
        /// <summary>
        /// The LoadBalancers.AviInfo is a conditional configuration made available upon selecting the AVI load balancer provider.
        /// It is used to configure the load balancer at run time.
        /// This field is optional and it is only relevant when the value of LoadBalancers.Info.provider is AVI.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "avi_info")]
        public VcenterNamespaceManagementLoadBalancersAviInfoType AviInfo { get; set; }
    }
}
