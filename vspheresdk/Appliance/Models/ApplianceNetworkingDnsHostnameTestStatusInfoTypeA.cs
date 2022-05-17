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
    public class ApplianceNetworkingDnsHostnameTestStatusInfoTypeA 
    {
        /// <summary>
        /// Overall status of tests run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceNetworkingDnsHostnameTestStatusEnumTypeA Status { get; set; }
        /// <summary>
        /// messages
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceNetworkingDnsHostnameMessageTypeA> Messages { get; set; }
    }
}
