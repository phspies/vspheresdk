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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtSmtpType 
    {
        /// <summary>
        /// Mail server IP address.
        /// If unset then the value will be ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "mail_server")]
        public string? MailServer { get; set; }
        /// <summary>
        /// Relay port number.
        /// If unset then the value will be ignored.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "relay_port")]
        public string? RelayPort { get; set; }
    }
}
