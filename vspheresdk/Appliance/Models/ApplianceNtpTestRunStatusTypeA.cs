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
    public class ApplianceNtpTestRunStatusTypeA 
    {
        /// <summary>
        /// Server name associated with the test run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
        /// <summary>
        /// Server status
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceNtpServerStatusEnumTypeA Status { get; set; }
        /// <summary>
        /// Message associated with status
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public ApplianceNtpLocalizableMessageTypeA Message { get; set; }
    }
}
