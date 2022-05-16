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
    public class VcenterCertificateManagementVcenterSigningCertificateSetType 
    {
        /// <summary>
        /// Signing certificate chain that the vCenter token service will actively use to sign tokens. The chain must include a
        /// valid certificate chain with the leaf cert marked for digital signature key usage.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "signing_cert_chain", Required = Required.AllowNull)]
        public VcenterCertificateManagementX509CertChainType SigningCertChain { get; set; }
        /// <summary>
        /// The corresponding unencrypted PKCS#8 private key in base64-encoded PEM format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "private_key", Required = Required.AllowNull)]
        public string PrivateKey { get; set; }
    }
}
