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
    public class VcenterCertificateManagementVcenterVmcaRootCreateSpecType 
    {
        /// <summary>
        /// The size of the key to be used for public and private key generation.
        /// If unset the key size will be 2048.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        public long? KeySize { get; set; }
        /// <summary>
        /// The common name of the host for which certificate is generated.
        /// If unset the common name will be the primary network identifier (PNID) of the vCenter Virtual Server Appliance (VCSA).
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string? CommonName { get; set; }
        /// <summary>
        /// Organization field in certificate subject.
        /// If unset the organization will be 'VMware'.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization")]
        public string? Organization { get; set; }
        /// <summary>
        /// Organization unit field in certificate subject.
        /// If unset the organization unit will be 'VMware Engineering'.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "organization_unit")]
        public string? OrganizationUnit { get; set; }
        /// <summary>
        /// Locality field in certificate subject.
        /// If unset the locality will be 'Palo Alto'.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "locality")]
        public string? Locality { get; set; }
        /// <summary>
        /// State field in certificate subject.
        /// If unset the state will be 'California'.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state_or_province")]
        public string? StateOrProvince { get; set; }
        /// <summary>
        /// Country field in certificate subject.
        /// If unset the country will be 'US'.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string? Country { get; set; }
        /// <summary>
        /// Email field in Certificate extensions.
        /// If unset the emailAddress will be 'email@acme.com'.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "email_address")]
        public string? EmailAddress { get; set; }
        /// <summary>
        /// SubjectAltName is list of Dns Names and Ip addresses.
        /// If unset PNID of host will be used as IPAddress or Hostname for certificate generation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "subject_alt_name")]
        public IList<string> SubjectAltName { get; set; }
    }
}
