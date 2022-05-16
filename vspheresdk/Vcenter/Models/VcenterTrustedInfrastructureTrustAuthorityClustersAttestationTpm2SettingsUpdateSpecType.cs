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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersAttestationTpm2SettingsUpdateSpecType 
    {
        /// <summary>
        /// Require registered TPM endorsement keys.
        /// If unset the current state will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "require_endorsement_keys")]
        public bool? RequireEndorsementKeys { get; set; }
        /// <summary>
        /// Require TPM endorsement key certificate validation.
        /// If unset the current state will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "require_certificate_validation")]
        public bool? RequireCertificateValidation { get; set; }
    }
}
