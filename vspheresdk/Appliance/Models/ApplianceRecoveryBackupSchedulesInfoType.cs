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
    public class ApplianceRecoveryBackupSchedulesInfoType 
    {
        /// <summary>
        /// List of optional parts that will be included in backups based on this schedule details. Use the Parts.list operation to
        /// get information about the supported parts.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "parts", Required = Required.AllowNull)]
        public IList<string> Parts { get; set; }
        /// <summary>
        /// URL of the backup location.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location", Required = Required.AllowNull)]
        public string Location { get; set; }
        /// <summary>
        /// Username for the given location.
        /// If unset location user will not be used.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "location_user")]
        public string? LocationUser { get; set; }
        /// <summary>
        /// Enable or disable a schedule, by default when created a schedule will be enabled.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        public bool Enable { get; set; }
        /// <summary>
        /// Recurrence information for the schedule.
        /// If unset backup job is not scheduled. See Schedules.RecurrenceInfo
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "recurrence_info")]
        public ApplianceRecoveryBackupSchedulesRecurrenceInfoType RecurrenceInfo { get; set; }
        /// <summary>
        /// Retention information for the schedule.
        /// If unset all the completed backup jobs are retained forever. See Schedules.RetentionInfo
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "retention_info")]
        public ApplianceRecoveryBackupSchedulesRetentionInfoType RetentionInfo { get; set; }
    }
}
