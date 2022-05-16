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
    public class VcenterTrustedInfrastructureTrustedClustersKmsServicesSummaryType 
    {
        /// <summary>
        /// The service's unique identifier.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.trusted_infrastructure.kms.Service. When operations return a value of this structure as a result, the field will
        /// be an identifier for the resource type: vcenter.trusted_infrastructure.kms.Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service", Required = Required.AllowNull)]
        public string Service { get; set; }
        /// <summary>
        /// The service's address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureNetworkAddressType Address { get; set; }
        /// <summary>
        /// The group determines the Attestation Service instances this Key Provider Service can accept reports from.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group", Required = Required.AllowNull)]
        public string Group { get; set; }
        /// <summary>
        /// The cluster specifies the Trust Authority Cluster this Key Provider Service belongs to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trust_authority_cluster", Required = Required.AllowNull)]
        public string TrustAuthorityCluster { get; set; }
    }
}
