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
    public class VcenterDeploymentLocationSpecType 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the container.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// The HTTPS port of the container.
        /// If unset, port 443 will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_port")]
        public long? HttpsPort { get; set; }
        /// <summary>
        /// SHA1 thumbprint of the server SSL certificate will be used for verification.
        /// This field is only relevant if LocationSpec.ssl-verify is unset or has the value true.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint")]
        public string? SslThumbprint { get; set; }
        /// <summary>
        /// SSL verification should be enabled or disabled. If LocationSpec.ssl-verify is true and and LocationSpec.ssl-thumbprint
        /// is unset, the CA certificate will be used for verification. If LocationSpec.ssl-verify is true and
        /// LocationSpec.ssl-thumbprint is set then the thumbprint will be used for verification. No verification will be performed
        /// if LocationSpec.ssl-verify value is set to false.
        /// If unset, ssl_verify true will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_verify")]
        public bool? SslVerify { get; set; }
        /// <summary>
        /// The administrator account on the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// The administrator account password.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        public string Password { get; set; }
    }
}
