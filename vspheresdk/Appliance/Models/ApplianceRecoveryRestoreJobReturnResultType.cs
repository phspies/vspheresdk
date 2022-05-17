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
    public class ApplianceRecoveryRestoreJobReturnResultType 
    {
        /// <summary>
        /// Check status
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceRecoveryRestoreJobReturnStatusType Status { get; set; }
        /// <summary>
        /// List of messages
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceRecoveryRestoreJobLocalizableMessageType> Messages { get; set; }
    }
}
