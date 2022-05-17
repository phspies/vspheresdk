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
    public class ApplianceRecoveryRestoreJobRestoreJobStatusType 
    {
        /// <summary>
        /// process state
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public ApplianceRecoveryRestoreJobBackupRestoreProcessStateType State { get; set; }
        /// <summary>
        /// list of messages
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceRecoveryRestoreJobLocalizableMessageType> Messages { get; set; }
        /// <summary>
        /// percentage complete
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress", Required = Required.AllowNull)]
        public long Progress { get; set; }
    }
}
