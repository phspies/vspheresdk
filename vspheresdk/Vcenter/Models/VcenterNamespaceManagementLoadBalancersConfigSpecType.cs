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
    public class VcenterNamespaceManagementLoadBalancersConfigSpecType 
    {
        /// <summary>
        /// An identifier that identifies a load balancer and can be used to query or configure load balancer properties via these
        /// resources. The identifier has DNS_LABEL restrictions as specified in . This must be an alphanumeric (a-z and 0-9)
        /// string, with a maximum length of 63 characters and with the '-' character allowed anywhere except the first or last
        /// character. This name is unique across all Namespaces in this vCenter server.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.namespace_management.LoadBalancerConfig. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: vcenter.namespace_management.LoadBalancerConfig.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// List of address ranges that will be used to derive frontend IP addresses for L4 virtual servers. At least one range must
        /// be provided.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address_ranges", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementIprangeType> AddressRanges { get; set; }
        /// <summary>
        /// The LoadBalancers.ConfigSpec.provider selects a provider from the list of available providers to be used with vSphere
        /// Namespaces.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementLoadBalancersProviderEnumType Provider { get; set; }
        /// <summary>
        /// The LoadBalancers.HAProxyConfigCreateSpec is a conditional configuration made available upon selecting the HA_PROXY load
        /// balancer provider. It is used to configure the load balancer at run time.
        /// This field is optional and it is only relevant when the value of LoadBalancers.ConfigSpec.provider is HA_PROXY.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ha_proxy_config_create_spec")]
        public VcenterNamespaceManagementLoadBalancersHaproxyConfigCreateSpecType HaProxyConfigCreateSpec { get; set; }
        /// <summary>
        /// The LoadBalancers.AviConfigCreateSpec is a conditional configuration made available upon selecting the AVI load balancer
        /// provider. It is used to configure the load balancer at run time.
        /// This field is optional and it is only relevant when the value of LoadBalancers.ConfigSpec.provider is AVI.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "avi_config_create_spec")]
        public VcenterNamespaceManagementLoadBalancersAviConfigCreateSpecType AviConfigCreateSpec { get; set; }
    }
}
