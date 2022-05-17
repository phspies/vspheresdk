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
    public class ApplianceNetworkingUpdateSpecType 
    {
        /// <summary>
        /// IPv6 Enabled or not
        /// If unspecified, leaves the current state of Ipv6.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "ipv6_enabled")]
        public bool? Ipv6Enabled { get; set; }
    }
}
