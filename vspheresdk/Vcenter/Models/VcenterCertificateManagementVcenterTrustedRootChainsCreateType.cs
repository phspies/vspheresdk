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
    public class VcenterCertificateManagementVcenterTrustedRootChainsCreateType 
    {
        /// <summary>
        /// Certificate chain in base64 encoding
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain", Required = Required.AllowNull)]
        public VcenterCertificateManagementX509CertChainType CertChain { get; set; }
        /// <summary>
        /// Unique identifier for this trusted root. Client can specify at creation as long as it is unique, otherwise one will be
        /// generated. An example of a client providing the identifier would be if this trusted root is associated with a VC trust.
        /// In this case the identifier would be the domain id.
        /// A unique id will be generated if not given.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "chain")]
        public string? Chain { get; set; }
    }
}
