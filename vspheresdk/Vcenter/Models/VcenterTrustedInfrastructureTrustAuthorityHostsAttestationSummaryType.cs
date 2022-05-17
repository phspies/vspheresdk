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
    public class VcenterTrustedInfrastructureTrustAuthorityHostsAttestationSummaryType 
    {
        /// <summary>
        /// Defines the verbosity of the summary.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "summary_type", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureTrustAuthorityHostsAttestationSummaryTypeEnum SummaryType { get; set; }
        /// <summary>
        /// The trusted ESX on which the service runs.
        /// This field is optional and it is only relevant when the value of Attestation.Summary.summary-type is one of BRIEF,
        /// NORMAL, or FULL.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// HostSystem. When operations return a value of this structure as a result, the field will be an identifier for the
        /// resource type: HostSystem.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string? Host { get; set; }
        /// <summary>
        /// The service's address.
        /// This field is optional and it is only relevant when the value of Attestation.Summary.summary-type is one of BRIEF,
        /// NORMAL, or FULL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public VcenterTrustedInfrastructureNetworkAddressType Address { get; set; }
        /// <summary>
        /// The group ID determines which Attestation Service instances this Attestation Service can communicate with.
        /// This field is optional and it is only relevant when the value of Attestation.Summary.summary-type is one of NORMAL or
        /// FULL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string? Group { get; set; }
        /// <summary>
        /// The opaque string identifier of the cluster in which the Attestation Service is part of.
        /// This field is optional and it is only relevant when the value of Attestation.Summary.summary-type is one of NORMAL or
        /// FULL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cluster")]
        public string? Cluster { get; set; }
        /// <summary>
        /// The service's TLS certificate chain.
        /// This field is optional and it is only relevant when the value of Attestation.Summary.summary-type is FULL.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "trusted_CA")]
        public VcenterTrustedInfrastructureX509CertChainType TrustedCA { get; set; }
    }
}
