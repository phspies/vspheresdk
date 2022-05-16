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
    public class VcenterNamespaceManagementLoadBalancersSetType 
    {
        /// <summary>
        /// List of address ranges that will be used to derive frontend IP addresses for L4 virtual servers. At least one range must
        /// be provided. A set operation only allows for addition of new IP ranges to the existing list of IP ranges.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_ranges", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIprangeType> AddressRanges { get; set; }
        /// <summary>
        /// The LoadBalancers.SetSpec.provider selects a provider from the list of available providers to be used with vSphere
        /// Namespaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementLoadBalancersProviderType Provider { get; set; }
        /// <summary>
        /// The LoadBalancers.HAProxyConfigSetSpec is a conditional configuration made available upon selecting the HA_PROXY load
        /// balancer provider. It is used to configure the load balancer at run time.
        /// This field is optional and it is only relevant when the value of LoadBalancers.SetSpec.provider is HA_PROXY.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_proxy_config_set_spec")]
        public VcenterNamespaceManagementLoadBalancersHaproxyConfigSetSpecType HaProxyConfigSetSpec { get; set; }
        /// <summary>
        /// The LoadBalancers.AviConfigSetSpec is a conditional configuration made available upon selecting the AVI load balancer
        /// provider. It is used to configure the load balancer at run time.
        /// This field is optional and it is only relevant when the value of LoadBalancers.SetSpec.provider is AVI.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "avi_config_set_spec")]
        public VcenterNamespaceManagementLoadBalancersAviConfigSetSpecType AviConfigSetSpec { get; set; }
    }
}
