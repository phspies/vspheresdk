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
    public class VcenterTrustedInfrastructureTrustedClustersKmsServicesInfoType 
    {
        /// <summary>
        /// The service's address.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureNetworkAddressType Address { get; set; }
        /// <summary>
        /// The service's TLS certificate chain.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trusted_CA", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureX509CertChainType TrustedCA { get; set; }
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
