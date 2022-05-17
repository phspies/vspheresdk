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
    public class ApplianceNetworkingInterfacesIpv4SetTypeA 
    {
        /// <summary>
        /// The IPv4 Network configuration to set.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public ApplianceNetworkingInterfacesIpv4ConfigTypeA Config { get; set; }
    }
}
