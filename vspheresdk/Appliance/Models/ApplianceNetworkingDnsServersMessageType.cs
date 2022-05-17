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
    public class ApplianceNetworkingDnsServersMessageType 
    {
        /// <summary>
        /// message
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public string Message { get; set; }
        /// <summary>
        /// result of the test
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "result", Required = Required.AllowNull)]
        public ApplianceNetworkingDnsServersMessageStatusType Result { get; set; }
    }
}
