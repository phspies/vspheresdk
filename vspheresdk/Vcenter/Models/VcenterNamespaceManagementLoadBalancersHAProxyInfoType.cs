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
    public class VcenterNamespaceManagementLoadBalancersHaproxyInfoType 
    {
        /// <summary>
        /// A list of the addresses for the DataPlane API servers used to configure HAProxy.
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
        /// PEM-encoded CA certificate chain which is used to verify x509 certificates received from the server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "certificate_authority_chain", Required = Required.AllowNull)]
        public string CertificateAuthorityChain { get; set; }
    }
}
