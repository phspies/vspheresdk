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
    public class ContentLibraryItemCertificateVerificationInfoTypeA 
    {
        /// <summary>
        /// The certificate verification status of item.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ContentLibraryItemCertVerificationStatusEnumTypeA Status { get; set; }
        /// <summary>
        /// A certificate in base64 encoding.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_chain")]
        public IList<string> CertChain { get; set; }
    }
}
