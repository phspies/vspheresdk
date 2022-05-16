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
    public class VcenterCertificateManagementVcenterTlsReplaceVmcaSignedType 
    {
        /// <summary>
        /// The size of the key to be used for public and private key generation.
        /// If unset the key size will be '2048'.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        public long? KeySize { get; set; }
        /// <summary>
        /// The common name of the host for which certificate is generated
        /// If unset will default to PNID of host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string? CommonName { get; set; }
        /// <summary>
        /// Organization field in certificate subject
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization", Required = Required.AllowNull)]
        public string Organization { get; set; }
        /// <summary>
        /// Organization unit field in certificate subject
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization_unit", Required = Required.AllowNull)]
        public string OrganizationUnit { get; set; }
        /// <summary>
        /// Locality field in certificate subject
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "locality", Required = Required.AllowNull)]
        public string Locality { get; set; }
        /// <summary>
        /// State field in certificate subject
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state_or_province", Required = Required.AllowNull)]
        public string StateOrProvince { get; set; }
        /// <summary>
        /// Country field in certificate subject
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "country", Required = Required.AllowNull)]
        public string Country { get; set; }
        /// <summary>
        /// Email field in Certificate extensions
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_address", Required = Required.AllowNull)]
        public string EmailAddress { get; set; }
        /// <summary>
        /// SubjectAltName is list of Dns Names and Ip addresses
        /// If unset PNID of host will be used as IPAddress or Hostname for certificate generation .
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_alt_name")]
        public IList<string> SubjectAltName { get; set; }
    }
}
