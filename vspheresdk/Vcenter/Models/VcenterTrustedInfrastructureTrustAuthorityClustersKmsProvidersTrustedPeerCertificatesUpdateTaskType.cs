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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersTrustedPeerCertificatesUpdateTaskType 
    {
        /// <summary>
        /// Public certificates of key server to trust.
        /// If unset, the trusted server certificates will not be updated.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        public IList<string> Certificates { get; set; }
    }
}
