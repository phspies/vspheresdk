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
    public class ApplianceHealthDatabaseMessageType 
    {
        /// <summary>
        /// Severity of the message.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "severity", Required = Required.AllowNull)]
        public ApplianceHealthDatabaseMessageSeverityType Severity { get; set; }
        /// <summary>
        /// Message describing the issue with the database.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "message", Required = Required.AllowNull)]
        public VapiStdLocalizableMessageType Message { get; set; }
    }
}
