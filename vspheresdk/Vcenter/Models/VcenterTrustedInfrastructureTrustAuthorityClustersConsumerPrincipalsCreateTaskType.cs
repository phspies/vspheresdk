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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersConsumerPrincipalsCreateTaskType 
    {
        /// <summary>
        /// The certificates used by the vCenter STS to sign tokens.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificates", Required = Required.AllowNull)]
        public Dictionary<string,VcenterTrustedInfrastructureX509CertChainType> Certificates { get; set; }
        /// <summary>
        /// A user-friendly alias of the service which created and signed the security token.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// esx.authentication.trust.security-token-issuer. When operations return a value of this structure as a result, the field
        /// will be an identifier for the resource type: esx.authentication.trust.security-token-issuer.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer_alias", Required = Required.AllowNull)]
        public string IssuerAlias { get; set; }
        /// <summary>
        /// The service which created and signed the security token.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer", Required = Required.AllowNull)]
        public string Issuer { get; set; }
        /// <summary>
        /// The principal used by the vCenter to retrieve tokens.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "principal", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureStsPrincipalType Principal { get; set; }
    }
}
