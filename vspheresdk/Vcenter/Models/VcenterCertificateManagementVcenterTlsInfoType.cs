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
    public class VcenterCertificateManagementVcenterTlsInfoType 
    {
        /// <summary>
        /// Version (version number) value from the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "version", Required = Required.AllowNull)]
        public long Version { get; set; }
        /// <summary>
        /// SerialNumber value from the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "serial_number", Required = Required.AllowNull)]
        public string SerialNumber { get; set; }
        /// <summary>
        /// Signature algorithm name from the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "signature_algorithm", Required = Required.AllowNull)]
        public string SignatureAlgorithm { get; set; }
        /// <summary>
        /// Issuer (issuer distinguished name) value from the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "issuer_dn", Required = Required.AllowNull)]
        public string IssuerDn { get; set; }
        /// <summary>
        /// validFrom specify the start date of the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "valid_from", Required = Required.AllowNull)]
        public DateTime ValidFrom { get; set; }
        /// <summary>
        /// validTo specify the end date of the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "valid_to", Required = Required.AllowNull)]
        public DateTime ValidTo { get; set; }
        /// <summary>
        /// Subject (subject distinguished name) value from the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_dn", Required = Required.AllowNull)]
        public string SubjectDn { get; set; }
        /// <summary>
        /// Thumbprint value from the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint", Required = Required.AllowNull)]
        public string Thumbprint { get; set; }
        /// <summary>
        /// Certificate constraints isCA from the critical BasicConstraints extension, (OID = 2.5.29.19).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "is_CA", Required = Required.AllowNull)]
        public bool IsCA { get; set; }
        /// <summary>
        /// Certificate constraints path length from the critical BasicConstraints extension, (OID = 2.5.29.19).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "path_length_constraint", Required = Required.AllowNull)]
        public long PathLengthConstraint { get; set; }
        /// <summary>
        /// Collection of keyusage contained in the certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_usage", Required = Required.AllowNull)]
        public IList<string> KeyUsage { get; set; }
        /// <summary>
        /// Collection of extended keyusage that contains details for which the certificate can be used for.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "extended_key_usage", Required = Required.AllowNull)]
        public IList<string> ExtendedKeyUsage { get; set; }
        /// <summary>
        /// Collection of subject alternative names.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_alternative_name", Required = Required.AllowNull)]
        public IList<string> SubjectAlternativeName { get; set; }
        /// <summary>
        /// Collection of authority information access URI.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "authority_information_access_uri", Required = Required.AllowNull)]
        public IList<string> AuthorityInformationAccessUri { get; set; }
        /// <summary>
        /// TLS certificate in PEM format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "cert", Required = Required.AllowNull)]
        public string Cert { get; set; }
    }
}
