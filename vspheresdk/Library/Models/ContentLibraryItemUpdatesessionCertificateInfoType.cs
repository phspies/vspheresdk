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
    public class ContentLibraryItemUpdatesessionCertificateInfoType 
    {
        /// <summary>
        /// Certificate issuer. For example: /C=US/ST=California/L=Palo Alto/O=VMware, Inc.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer", Required = Required.AllowNull)]
        public string Issuer { get; set; }
        /// <summary>
        /// Certificate subject. For example: C=US/ST=Massachusetts/L=Hopkinton/O=EMC Corporation/OU=EMC Avamar/CN=EMC Corporation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject", Required = Required.AllowNull)]
        public string Subject { get; set; }
        /// <summary>
        /// Whether the certificate is self-signed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "self_signed", Required = Required.AllowNull)]
        public bool SelfSigned { get; set; }
        /// <summary>
        /// The X509 representation of the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "x509", Required = Required.AllowNull)]
        public string X509 { get; set; }
    }
}
