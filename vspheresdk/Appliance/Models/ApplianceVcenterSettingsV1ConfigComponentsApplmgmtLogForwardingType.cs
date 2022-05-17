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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtLogForwardingType 
    {
        /// <summary>
        /// FQDN or IP address of the logging server to which messages are forwarded.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string? Hostname { get; set; }
        /// <summary>
        /// The port on which the remote logging server is listening for forwarded log messages.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Transport protocol used to forward log messages.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtLogForwardingProtocolType Protocol { get; set; }
    }
}
