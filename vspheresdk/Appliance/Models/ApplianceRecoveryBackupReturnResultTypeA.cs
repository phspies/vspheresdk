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
    public class ApplianceRecoveryBackupReturnResultTypeA 
    {
        /// <summary>
        /// Check status
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupReturnStatusTypeA Status { get; set; }
        /// <summary>
        /// List of messages
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceRecoveryBackupLocalizableMessageTypeA> Messages { get; set; }
    }
}
