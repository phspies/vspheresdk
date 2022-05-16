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
    public class VcenterCertificateManagementVcenterSigningCertificateInfoType 
    {
        /// <summary>
        /// The certificate chain that is actively being use by vCenter token service to sign tokens.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "active_cert_chain", Required = Required.AllowNull)]
        public VcenterCertificateManagementX509CertChainType ActiveCertChain { get; set; }
        /// <summary>
        /// List of signing certificate chains for validating vCenter-issued tokens. The list contains X509 certificate chains, each
        /// of which is ordered and contains the leaf, intermediate and root certs needed for the complete chain of trust. The leaf
        /// certificate is first in the chain and should be used for verifying vCenter-issued tokens.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "signing_cert_chains", Required = Required.AllowNull)]
        public Dictionary<string,VcenterCertificateManagementX509CertChainType> SigningCertChains { get; set; }
    }
}
