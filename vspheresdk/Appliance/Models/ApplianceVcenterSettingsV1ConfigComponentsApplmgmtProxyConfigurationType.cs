using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Appliance.Models.Enums;

namespace vspheresdk.Appliance.Models
{
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtProxyConfigurationType 
    {
        /// <summary>
        /// The protocol for which proxy should be set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtProxyConfigurationProtocolEnumType Protocol { get; set; }
        /// <summary>
        /// URL of the proxy server
        /// Only set if server set in ProxyConfiguration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string? Server { get; set; }
        /// <summary>
        /// Port to connect to the proxy server. In a 'get' call, indicates the port connected to the proxy server. In a 'set' call,
        /// specifies the port to connect to the proxy server. A value of -1 indicates the default port.
        /// Only set if port set in ProxyConfiguration.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
        /// <summary>
        /// Username for proxy server.
        /// Only set if proxy requires username.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Password for proxy server.
        /// Only set if proxy requires password.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// In the result of the #get and #list operations this field indicates whether proxying is enabled for a particular
        /// protocol. In the input to the test and set operations this field specifies whether proxying should be enabled for a
        /// particular protocol.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
