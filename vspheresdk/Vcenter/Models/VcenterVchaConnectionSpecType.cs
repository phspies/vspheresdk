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
    public class VcenterVchaConnectionSpecType 
    {
        /// <summary>
        /// IP Address or DNS of the vCenter.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// Port number.
        /// If unset, port 443 will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// SHA1 hash of the server SSL certificate.
        /// If unset, empty ssl thumbprint is assumed.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumbprint")]
        public string? SslThumbprint { get; set; }
        /// <summary>
        /// Username to access the server.
        /// This field is currently required. If unset, an error is returned. In the future, if this field is unset, the system will
        /// attempt to identify the user. If a user cannot be identified, then the requested operation will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Password for the specified user.
        /// This field is currently required. If unset, an empty password is assumed. In the future, if this field is unset, the
        /// system will attempt to authenticate the user. If a user cannot be identified, then the requested operation will fail.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
    }
}
