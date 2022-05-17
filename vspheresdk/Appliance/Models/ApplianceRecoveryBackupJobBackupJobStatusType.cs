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
    public class ApplianceRecoveryBackupJobBackupJobStatusType 
    {
        /// <summary>
        /// TimeStamp based ID.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "id", Required = Required.AllowNull)]
        public string Id { get; set; }
        /// <summary>
        /// The state of the backup job.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "state", Required = Required.AllowNull)]
        public ApplianceRecoveryBackupJobBackupRestoreProcessStateEnumType State { get; set; }
        /// <summary>
        /// List of messages.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages", Required = Required.AllowNull)]
        public Dictionary<string,ApplianceRecoveryBackupJobLocalizableMessageType> Messages { get; set; }
        /// <summary>
        /// Progress of the job in percentage.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "progress", Required = Required.AllowNull)]
        public long Progress { get; set; }
        /// <summary>
        /// Time when the backup was started.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "start_time", Required = Required.AllowNull)]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Time when the backup was finished.
        /// If unset end time is None until backup is finished.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "end_time")]
        public DateTime? EndTime { get; set; }
    }
}
