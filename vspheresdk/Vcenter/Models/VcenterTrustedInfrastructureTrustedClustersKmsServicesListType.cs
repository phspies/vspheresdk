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
    public class VcenterTrustedInfrastructureTrustedClustersKmsServicesListType 
    {
        /// <summary>
        /// A set of IDs by which to filter the services.
        /// If unset, the services will not be filtered by ID.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.trusted_infrastructure.kms.Service. When operations return a value of this structure as a result, the field will
        /// contain identifiers for the resource type: vcenter.trusted_infrastructure.kms.Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<string> Services { get; set; }
        /// <summary>
        /// The service's address.
        /// If unset, the services will not be filtered by address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public Dictionary<string,VcenterTrustedInfrastructureNetworkAddressType> Address { get; set; }
        /// <summary>
        /// The group determines the Attestation Service instances this Key Provider Service can accept reports from.
        /// If unset, the services will not be filtered by group.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public IList<string> Group { get; set; }
        /// <summary>
        /// The cluster specifies the Trust Authority Cluster this Key Provider Service instance belongs to.
        /// If unset, the services will not be filtered by trustAuthorityCluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trust_authority_cluster")]
        public IList<string> TrustAuthorityCluster { get; set; }
    }
}
