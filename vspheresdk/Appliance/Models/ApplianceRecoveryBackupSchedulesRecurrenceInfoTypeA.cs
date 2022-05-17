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
    public class ApplianceRecoveryBackupSchedulesRecurrenceInfoTypeA 
    {
        /// <summary>
        /// Minute when backup should run.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "minute", Required = Required.AllowNull)]
        public long Minute { get; set; }
        /// <summary>
        /// Hour when backup should run. The hour should be specified in 24-hour clock format.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hour", Required = Required.AllowNull)]
        public long Hour { get; set; }
        /// <summary>
        /// Day of week when the backup should be run. Days can be specified as list of days.
        /// If unset the backup will be run everyday.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        public Dictionary<string,ApplianceRecoveryBackupSchedulesDayOfWeekTypeA> Days { get; set; }
    }
}
