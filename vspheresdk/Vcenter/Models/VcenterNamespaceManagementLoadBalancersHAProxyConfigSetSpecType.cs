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
    public class VcenterNamespaceManagementLoadBalancersHaproxyConfigSetSpecType 
    {
        /// <summary>
        /// Servers is a list of the addresses for the data plane API servers used to configure HAProxy. Note: This field cannot be
        /// updated and should match existing list of servers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "servers", Required = Required.AllowNull)]
        public Dictionary<string,VcenterNamespaceManagementLoadBalancersServerType> Servers { get; set; }
        /// <summary>
        /// An administrator user name for accessing the HAProxy Data Plane API server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// The password for the administrator user.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        public string Password { get; set; }
        /// <summary>
        /// CertificateAuthorityChain contains PEM-encoded CA chain which is used to verify x509 certificates received from the
        /// server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate_authority_chain", Required = Required.AllowNull)]
        public string CertificateAuthorityChain { get; set; }
    }
}
