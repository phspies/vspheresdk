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
    public class VcenterSystemConfigPscRegistrationRepointType 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the remote PSC to which this configuring vCenter Server will be registered to.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "psc_hostname", Required = Required.AllowNull)]
        public string PscHostname { get; set; }
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
        /// SHA1 thumbprint of the server SSL certificate will be used for verification when ssl_verify field is set to true.
        /// This field is only relevant if RemotePscSpec.ssl-verify is unset or has the value true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint")]
        public string? SslThumbprint { get; set; }
        /// <summary>
        /// SSL verification should be enabled or disabled. If RemotePscSpec.ssl-verify is true and and RemotePscSpec.ssl-thumbprint
        /// is unset, the CA certificate will be used for verification. If RemotePscSpec.ssl-verify is true and
        /// RemotePscSpec.ssl-thumbprint is set then the thumbprint will be used for verification. No verification will be performed
        /// if RemotePscSpec.ssl-verify value is set to false.
        /// If unset, RemotePscSpec.ssl-verify true will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_verify")]
        public bool? SslVerify { get; set; }
    }
}
