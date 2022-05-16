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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersClientCertificateUpdateTaskType 
    {
        /// <summary>
        /// Public certificate used by every host in the cluster.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate", Required = Required.AllowNull)]
        public string Certificate { get; set; }
        /// <summary>
        /// Private part of the certificate.
        /// If unset, the update request is for a public/private client certificate pair, not for a signed CSR.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "private_key")]
        public string? PrivateKey { get; set; }
    }
}
