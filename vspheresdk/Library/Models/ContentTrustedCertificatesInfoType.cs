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
    public class ContentTrustedCertificatesInfoType 
    {
        /// <summary>
        /// A certificate in Base64 encoding
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert_text", Required = Required.AllowNull)]
        public string CertText { get; set; }
    }
}
