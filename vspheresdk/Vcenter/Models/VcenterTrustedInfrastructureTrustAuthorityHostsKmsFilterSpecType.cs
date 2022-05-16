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
    public class VcenterTrustedInfrastructureTrustAuthorityHostsKmsFilterSpecType 
    {
        /// <summary>
        /// A set of host IDs by which to filter the services.
        /// If unset, the services will not be filtered by the hosts on which they run.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will contain identifiers for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }
        /// <summary>
        /// A set of cluster IDs by which to filter the services.
        /// If unset, the services will not be filtered by the clusters on which they run.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// ClusterComputeResource. When operations return a value of this structure as a result, the field will contain identifiers
        /// for the resource type: ClusterComputeResource.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "clusters")]
        public IList<string> Clusters { get; set; }
        /// <summary>
        /// The service's address.
        /// If unset, the services will not be filtered by address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public Dictionary<string,VcenterTrustedInfrastructureNetworkAddressType> Address { get; set; }
        /// <summary>
        /// The group determines reports issued by which Attestation Service instances this Key Provider Service can accept.
        /// If unset, the services will not be filtered by groupId.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }
    }
}
