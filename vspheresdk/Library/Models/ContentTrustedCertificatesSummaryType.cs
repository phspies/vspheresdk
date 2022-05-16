using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Library.Models.Enums;

namespace vspheresdk.Library.Models
{
    public class ContentTrustedCertificatesSummaryType 
    {
        /// <summary>
        /// Unique identifier for the certificate. It is the TrustStore alias of the certificate. The alias is the SHA256 hash of
        /// the raw certificate data.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate", Required = Required.AllowNull)]
        public string Certificate { get; set; }
        /// <summary>
        /// Certificate in Base64 encoded PEM format..
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_text", Required = Required.AllowNull)]
        public string CertText { get; set; }
    }
}
