using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;
using vspheresdk.Esx.Models.Enums;

namespace vspheresdk.Esx.Models
{
    public class EsxSettingsDepotsSyncScheduleScheduleType 
    {
        /// <summary>
        /// Frequency of the schedule.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public EsxSettingsDepotsSyncScheduleRecurrenceType Type { get; set; }
        /// <summary>
        /// This determines the units of {@name Recurrence} to skip before the scheduled task runs again. For example, value of 1
        /// for HOURLY type means the scheduled task runs every 2 hours. The value must be within the range 0 to 998.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "skip")]
        public long? Skip { get; set; }
        /// <summary>
        /// Minute at which schedule should be run. The value must be within the range 0 to 59.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "minute")]
        public long? Minute { get; set; }
        /// <summary>
        /// Hour at which schedule should be run. The value must be within the range 0 to 23.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "hour")]
        public long? Hour { get; set; }
        /// <summary>
        /// Day at which schedule should be run. The value must be within the range 1 to 31. If the value exceeds the total number
        /// of days in the month, the schedule will run on the last day of the month.
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "day_of_month")]
        public long? DayOfMonth { get; set; }
        /// <summary>
        /// Day of the week when schedule should be run
        /// </summary>
        /// </summary>
        [JsonProperty(PropertyName = "day_of_week")]
        public EsxSettingsDepotsSyncScheduleDayOfWeekType DayOfWeek { get; set; }
    }
}
