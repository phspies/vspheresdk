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
    public class ApplianceNetworkingProxySetTypeA 
    {
        /// <summary>
        /// Proxy configuration for the specific protocol.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public ApplianceNetworkingProxyConfigTypeA Config { get; set; }
    }
}
