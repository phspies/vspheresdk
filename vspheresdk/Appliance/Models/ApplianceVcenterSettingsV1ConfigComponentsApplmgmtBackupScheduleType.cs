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
    public class ApplianceVcenterSettingsV1ConfigComponentsApplmgmtBackupScheduleType 
    {
        /// <summary>
        /// List of optional parts to be backed up. Use the appliance.recovery.backup.Parts#list operation to get information about
        /// the supported parts.
        /// If unset all the optional parts will not be backed up.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parts")]
        public IList<string> Parts { get; set; }
        /// <summary>
        /// Password for a backup piece. The backupPassword must adhere to the following password requirements: At least 8
        /// characters, cannot be more than 20 characters in length. At least 1 uppercase letter. At least 1 lowercase letter. At
        /// least 1 numeric digit. At least 1 special character (i.e. any character not in [0-9,a-z,A-Z]). Only visible ASCII
        /// characters (for example, no space).
        /// If unset the backup piece will not be encrypted.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "backup_password")]
        public string? BackupPassword { get; set; }
        /// <summary>
        /// URL of the backup location.
        /// Only set if URL is set in BackupSchedule
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// Username for the given location.
        /// If unset authentication will not be used for the specified location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_user")]
        public string? LocationUser { get; set; }
        /// <summary>
        /// Password for the given location.
        /// If unset authentication will not be used for the specified location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_password")]
        public string? LocationPassword { get; set; }
        /// <summary>
        /// Enable or disable a schedule.
        /// If unset the schedule will be enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Recurrence information for the schedule.
        /// If unset backup job will not be scheduled. See RecurrenceInfo
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurrence_info")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtRecurrenceInfoType RecurrenceInfo { get; set; }
        /// <summary>
        /// Retention information for the schedule.
        /// If unset all the completed backup jobs will be retained forever. See RetentionInfo
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retention_info")]
        public ApplianceVcenterSettingsV1ConfigComponentsApplmgmtRetentionInfoType RetentionInfo { get; set; }
        /// <summary>
        /// Identifier of the schedule.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "schedule_id", Required = Required.AllowNull)]
        public string ScheduleId { get; set; }
    }
}
