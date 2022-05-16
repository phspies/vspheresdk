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
    public class VcenterNamespaceManagementLoadBalancersHaproxyConfigUpdateSpecType 
    {
        /// <summary>
        /// An administrator user name for accessing the HAProxy Data Plane API server.
        /// If unset, the existing username will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// The password for the administrator user.
        /// If unset, the existing password will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the
        /// server.
        /// If unset, the existing PEM-encoded CA chain will not be modified.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate_authority_chain")]
        public string? CertificateAuthorityChain { get; set; }
    }
}
