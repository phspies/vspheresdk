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
    public class ApplianceNetworkingNoProxySetTypeA 
    {
        /// <summary>
        /// List of strings representing servers to bypass proxy. A server can be a FQDN, IP address, FQDN:port or IP:port
        /// combinations.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "servers", Required = Required.AllowNull)]
        public IList<string> Servers { get; set; }
    }
}
