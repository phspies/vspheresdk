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
    public class VcenterNamespaceManagementLoadBalancersSummaryType 
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
        /// Load balancer provider for the namespace.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "provider", Required = Required.AllowNull)]
        public VcenterNamespaceManagementLoadBalancersProviderType Provider { get; set; }
    }
}
