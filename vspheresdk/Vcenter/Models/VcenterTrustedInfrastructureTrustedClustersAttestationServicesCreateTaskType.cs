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
    public class VcenterTrustedInfrastructureTrustedClustersAttestationServicesCreateTaskType 
    {
        /// <summary>
        /// Source of truth for the configuration of the Attestation Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureTrustedClustersAttestationServicesCreateSpecSourceTypeEnum Type { get; set; }
        /// <summary>
        /// The service's unique ID.
        /// This field is optional and it is only relevant when the value of Services.CreateSpec.type is SERVICE.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.trusted_infrastructure.attestation.Service. When operations return a value of this structure as a result, the
        /// field will be an identifier for the resource type: vcenter.trusted_infrastructure.attestation.Service.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string? Service { get; set; }
        /// <summary>
        /// The attestation cluster's unique ID.
        /// This field is optional and it is only relevant when the value of Services.CreateSpec.type is CLUSTER.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trust_authority_cluster")]
        public string? TrustAuthorityCluster { get; set; }
    }
}
