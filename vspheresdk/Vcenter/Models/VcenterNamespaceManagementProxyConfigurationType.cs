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
    public class VcenterNamespaceManagementProxyConfigurationType 
    {
        /// <summary>
        /// The source of the proxy settings. If VC_INHERITED or NONE is specified, then the other configuration in
        /// ProxyConfiguration will be ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "proxy_settings_source", Required = Required.AllowNull)]
        public VcenterNamespaceManagementProxySettingsSourceEnumType ProxySettingsSource { get; set; }
        /// <summary>
        /// HTTPS proxy configuration. Examples:
        /// - http://username:password@proxy.vmware.com:8080
        /// - https://proxy.vmware.com:4443
        /// This will be used if CLUSTER_CONFIGURED is used for the source, otherwise this will be ignored.
        /// If unset no HTTPS proxy will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "https_proxy_config")]
        public string? HttpsProxyConfig { get; set; }
        /// <summary>
        /// HTTP proxy configuration. Examples:
        /// - http://username:password@proxy.vmware.com:8080
        /// - https://proxy.vmware.com:4443
        /// This will be used if CLUSTER_CONFIGURED is used for the source, otherwise this will be ignored.
        /// If unset no HTTP proxy will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "http_proxy_config")]
        public string? HttpProxyConfig { get; set; }
        /// <summary>
        /// List of addresses that should be accessed directly. This will be used if CLUSTER_CONFIGURED is used for the source,
        /// otherwise this will be ignored.
        /// If unset there won't be any excluded addresses.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "no_proxy_config")]
        public IList<string> NoProxyConfig { get; set; }
        /// <summary>
        /// Proxy TLS root CA bundle which will be used to verify the proxies certificates. Every certificate in the bundle is
        /// expected to be in PEM format. This will be used if CLUSTER_CONFIGURED is used for the source, otherwise this will be
        /// ignored.
        /// If unset only the vCenter certificates applied in VECS (VMware Endpoint Certificate Store) will be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "tls_root_ca_bundle")]
        public string? TlsRootCaBundle { get; set; }
    }
}
