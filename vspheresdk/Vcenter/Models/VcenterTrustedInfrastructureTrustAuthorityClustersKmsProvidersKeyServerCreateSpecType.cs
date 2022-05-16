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
    public class VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerCreateSpecType 
    {
        /// <summary>
        /// Type of the key server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKeyServerCreateSpecTypeA Type { get; set; }
        /// <summary>
        /// Description of the key server.
        /// If unset, description will not be added.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Proxy server configuration.
        /// If unset, the key server will not use a proxy server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxy_server")]
        public VcenterTrustedInfrastructureNetworkAddressType ProxyServer { get; set; }
        /// <summary>
        /// Connection timeout in seconds.
        /// If unset, connection timeout will not be set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "connection_timeout")]
        public long? ConnectionTimeout { get; set; }
        /// <summary>
        /// Configuration information for Key Management Interoperability Protocol (KMIP) based key server.
        /// This field is optional and it is only relevant when the value of Providers.KeyServerCreateSpec.type is KMIP.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "kmip_server")]
        public VcenterTrustedInfrastructureTrustAuthorityClustersKmsProvidersKmipServerCreateSpecType KmipServer { get; set; }
    }
}
