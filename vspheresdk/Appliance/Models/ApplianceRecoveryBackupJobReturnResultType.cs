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
    public class ApplianceRecoveryBackupJobReturnResultType 
    {
        /// <summary>
        /// Status of the cancel operation.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupJobReturnStatusType Status { get; set; }
        /// <summary>
        /// List of messages.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceRecoveryBackupJobLocalizableMessageType> Messages { get; set; }
    }
}
