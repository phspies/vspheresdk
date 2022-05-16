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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerUpdateSpecType 
    {
        /// <summary>
        /// List of KMIP compliant key servers.
        /// Key servers must be configured for active-active replication. If the server port is unset, a default value for KMIP's
        /// port will be used.
        /// 
        /// 
        /// 
        /// If unset, server configuration will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        public Dictionary<string,VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersServerType> Servers { get; set; }
        /// <summary>
        /// Username for authentication.
        /// 
        /// 
        /// If unset, username will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
    }
}
