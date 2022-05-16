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
    public class VcenterCertificateManagementX509CertChainTypeA 
    {
        /// <summary>
        /// Certificate chain in base64 format
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain", Required = Required.AllowNull)]
        public IList<string> CertChain { get; set; }
    }
}
