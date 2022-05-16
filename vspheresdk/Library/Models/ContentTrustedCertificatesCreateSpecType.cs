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
    public class ContentTrustedCertificatesCreateSpecType 
    {
        /// <summary>
        /// A certText is the certificate in Base64 encoded PEM format. The input must be a single line string with escape sequence
        /// for new-lines.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_text", Required = Required.AllowNull)]
        public string CertText { get; set; }
    }
}
