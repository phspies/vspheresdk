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
    public class ApplianceLoggingForwardingConnectionStatusTypeA 
    {
        /// <summary>
        /// FQDN or IP address of the configured remote logging servers.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
        /// <summary>
        /// State of the configured remote logging server.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public ApplianceLoggingForwardingConnectionStatusStateEnumTypeA State { get; set; }
        /// <summary>
        /// Message associated with the state of the configured remote logging server.
        /// If unset, there is no message to be shown.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public VapiStdLocalizableMessageTypeA Message { get; set; }
    }
}
