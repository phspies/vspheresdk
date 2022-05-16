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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersAttestationTpm2CaCertificatesCreateSpecType 
    {
        /// <summary>
        /// A unique name for the TPM CA certificate.
        /// When clients pass a value of this structure as a parameter, the field must be an identifier for the resource type:
        /// vcenter.trusted_infrastructure.trust_authority_clusters.attestation.tpm2.CaCertificate. When operations return a value
        /// of this structure as a result, the field will be an identifier for the resource type:
        /// vcenter.trusted_infrastructure.trust_authority_clusters.attestation.tpm2.CaCertificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// The CA certificate chain.
        /// Certificates may either be added one at a time, or as a chain. Adding the certificates as a chain allows the group to be
        /// managed as a whole. For example, an entire chain can be deleted in one CaCertificates.delete operation.
        /// 
        /// When certificates are added one at a time, the order must be root first, followed by any intermediates. The
        /// intermediates certificates must also be ordered in the direction from root to leaf.
        /// 
        /// Similarly, when added as a chain the list must be ordered in the direction from root to leaf.
        /// 
        /// If unset creation will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain")]
        public VcenterTrustedInfrastructureX509CertChainType CertChain { get; set; }
    }
}
