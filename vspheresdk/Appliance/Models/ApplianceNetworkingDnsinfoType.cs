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
    public class ApplianceNetworkingDnsinfoType 
    {
        /// <summary>
        /// DNS mode.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mode", Required = Required.AllowNull)]
        public ApplianceNetworkingDnsinfoDnsmodeType Mode { get; set; }
        /// <summary>
        /// Hostname.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// Servers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "servers", Required = Required.AllowNull)]
        public IList<string> Servers { get; set; }
    }
}
