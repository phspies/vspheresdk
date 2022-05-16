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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersConsumerPrincipalsListTaskType 
    {
        /// <summary>
        /// The unqiue identifier of a connection profile.
        /// If unset, no filtration will be performed by ID.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// esx.authentication.clientprofile. When operations return a value of this structure as a result, the field will contain
        /// identifiers for the resource type: esx.authentication.clientprofile.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public IList<string> Id { get; set; }
        /// <summary>
        /// The principal used by the vCenter to retrieve tokens.
        /// If unset, no filtration will be performed by principals.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "principals")]
        public Dictionary<string,VcenterTrustedInfrastructureStsPrincipalType> Principals { get; set; }
        /// <summary>
        /// The service which created and signed the security token.
        /// If unset, no filtration will be performed by issuer.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// esx.authentication.trust.security-token-issuer. When operations return a value of this structure as a result, the field
        /// will contain identifiers for the resource type: esx.authentication.trust.security-token-issuer.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public IList<string> Issuer { get; set; }
    }
}
