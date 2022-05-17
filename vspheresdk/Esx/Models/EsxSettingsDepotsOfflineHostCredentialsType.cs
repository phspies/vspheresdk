using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsDepotsOfflineHostCredentialsType 
    {
        /// <summary>
        /// The IP address or DNS resolvable name of the host.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "host_name", Required = Required.AllowNull)]
        public string HostName { get; set; }
        /// <summary>
        /// Specifies the username to be used during the {@link Offline#createFromHost} {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "user_name", Required = Required.AllowNull)]
        public string UserName { get; set; }
        /// <summary>
        /// Specifies the password to be used during the {@link Offline#createFromHost} {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password", Required = Required.AllowNull)]
        public string Password { get; set; }
        /// <summary>
        /// Specifies the port number of the host to be used during {@link Offline#createFromHost} {@term operation}.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Specifies the sslThumbPrint of the host to be used during {@link Offline#createFromHost} {@term operation} SHA1 hash of
        /// the host's SSL certificate.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ssl_thumb_print")]
        public string? SslThumbPrint { get; set; }
    }
}
