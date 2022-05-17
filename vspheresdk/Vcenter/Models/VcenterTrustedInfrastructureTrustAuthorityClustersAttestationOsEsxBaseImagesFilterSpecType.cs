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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersAttestationOsEsxBaseImagesFilterSpecType 
    {
        /// <summary>
        /// Search criteria by ESX base image version numbers.
        /// version if {@term.unset} return all ESX version numbers.
        /// When clients pass a value of this structure as a parameter, the field must contain identifiers for the resource type:
        /// vcenter.trusted_infrastructure.trust_authority_clusters.attestation.os.esx.BaseImage. When operations return a value of
        /// this structure as a result, the field will contain identifiers for the resource type:
        /// vcenter.trusted_infrastructure.trust_authority_clusters.attestation.os.esx.BaseImage.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public IList<string> Version { get; set; }
        /// <summary>
        /// Search criteria by ESX base image version version numbers.
        /// displayName if {@term.unset} return all ESX display version numbers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public IList<string> DisplayName { get; set; }
        /// <summary>
        /// Search criteria by health indicator.
        /// health if {@term.unset} return all health indicators.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "health")]
        public Dictionary<string,VcenterTrustedInfrastructureTrustAuthorityClustersAttestationOsEsxBaseImagesHealthEnumType> Health { get; set; }
    }
}
