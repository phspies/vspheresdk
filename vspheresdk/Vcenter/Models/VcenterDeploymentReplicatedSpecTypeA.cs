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
    public class VcenterDeploymentReplicatedSpecTypeA 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the partner PSC appliance.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "partner_hostname", Required = Required.AllowNull)]
        public string PartnerHostname { get; set; }
        /// <summary>
        /// The HTTPS port of the external PSC appliance.
        /// If unset, port 443 will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public long? HttpsPort { get; set; }
        /// <summary>
        /// The SSO administrator account password.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "sso_admin_password", Required = Required.AllowNull)]
        public string SsoAdminPassword { get; set; }
        /// <summary>
        /// SHA1 thumbprint of the server SSL certificate will be used for verification.
        /// This field is only relevant if ReplicatedSpec.ssl-verify is unset or has the value true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint")]
        public string? SslThumbprint { get; set; }
        /// <summary>
        /// SSL verification should be enabled or disabled.
        /// If unset, ssl_verify true will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_verify")]
        public bool? SslVerify { get; set; }
    }
}
