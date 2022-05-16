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
    public class VcenterCertificateManagementVcenterTlsCsrSpecTypeA 
    {
        /// <summary>
        /// keySize will take 2048 bits if not modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        public long? KeySize { get; set; }
        /// <summary>
        /// commonName will take PNID if not modified.
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
        /// subjectAltName is list of Dns Names and Ip addresses
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_alt_name")]
        public IList<string> SubjectAltName { get; set; }
    }
}
