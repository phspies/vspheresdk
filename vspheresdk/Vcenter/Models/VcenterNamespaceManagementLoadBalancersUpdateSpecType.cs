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
    public class VcenterNamespaceManagementLoadBalancersUpdateSpecType 
    {
        /// <summary>
        /// List of address ranges that will be used to derive frontend IP addresses for L4 virtual servers. At least one range must
        /// be provided. An update operation only allows for addition of new IP ranges to the existing list of IP ranges.
        /// If unset, the existing list of address ranges will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_ranges")]
        public Dictionary<string,VcenterNamespaceManagementIprangeType> AddressRanges { get; set; }
        /// <summary>
        /// The LoadBalancers.UpdateSpec.provider selects a provider from the list of available providers to be used with vSphere
        /// Namespaces.
        /// If set, corresponding load balancer UpdateSpec will be used to update the configuration. Note: This field cannot be
        /// updated and can only be used a qualifer for the provider specific update spec.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider")]
        public VcenterNamespaceManagementLoadBalancersProviderEnumType Provider { get; set; }
        /// <summary>
        /// The LoadBalancers.HAProxyConfigUpdateSpec is a conditional configuration made available upon selecting the HA_PROXY load
        /// balancer provider. It is used to configure the load balancer at run time.
        /// If unset, the HAProxy load balancer configuration will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_proxy_config_update_spec")]
        public VcenterNamespaceManagementLoadBalancersHaproxyConfigUpdateSpecType HaProxyConfigUpdateSpec { get; set; }
        /// <summary>
        /// The LoadBalancers.AviConfigUpdateSpec is a conditional configuration made available upon selecting the AVI load balancer
        /// provider. It is used to configure the load balancer at run time.
        /// If unset, the Avi load balancer configuration will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "avi_config_update_spec")]
        public VcenterNamespaceManagementLoadBalancersAviConfigUpdateSpecType AviConfigUpdateSpec { get; set; }
    }
}
