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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerUpdateSpecType 
    {
        /// <summary>
        /// Type of the key server.
        /// 
        /// 
        /// If unset, key server type and configuration information will remain unchanged. In this case all key server configuration
        /// information fields (e.g KMIP) should be unset.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerUpdateSpecTypeA Type { get; set; }
        /// <summary>
        /// Description of the key server.
        /// 
        /// 
        /// If unset, description will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Proxy server configuration.
        /// 
        /// 
        /// If unset, proxy server configuration will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxy_server")]
        public VcenterTrustedInfrastructureNetworkAddressType ProxyServer { get; set; }
        /// <summary>
        /// Connection timeout in seconds.
        /// 
        /// 
        /// If unset, connection timeout will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_timeout")]
        public long? ConnectionTimeout { get; set; }
        /// <summary>
        /// Configuration information for KMIP based key server.
        /// 
        /// 
        /// If unset, kmip server configuration will remain unchanged.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "kmip_server")]
        public VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerUpdateSpecType KmipServer { get; set; }
    }
}
