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
    public class VcenterCertificateManagementVcenterTlsSpecType 
    {
        /// <summary>
        /// Certificate string in PEM format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert", Required = Required.AllowNull)]
        public string Cert { get; set; }
        /// <summary>
        /// Private key string in PEM format.
        /// If unset the private key from the certificate store will be used. It is required when replacing the certificate with a
        /// third party signed certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// Third party Root CA certificate in PEM format.
        /// If unset the new third party root CA certificate will not be added to the trust store. It is required when replacing the
        /// certificate with a third party signed certificate if the root certificate of the third party is not already a trusted
        /// root.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "root_cert")]
        public string? RootCert { get; set; }
    }
}
