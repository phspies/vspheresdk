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
    public class VcenterCertificateManagementVcenterTrustedRootChainsInfoTypeA 
    {
        /// <summary>
        /// A certificate chain in base64 encoding
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain", Required = Required.AllowNull)]
        public VcenterCertificateManagementX509CertChainTypeA CertChain { get; set; }
    }
}
