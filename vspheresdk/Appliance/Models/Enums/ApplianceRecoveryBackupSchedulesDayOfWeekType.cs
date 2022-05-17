using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Schedules.DayOfWeek enumerated type defines the set of days when backup can be scheduled. The days can be specified as a list of individual days. You specify the days when you set the recurrence for a schedule. See Schedules.RecurrenceInfo.days.
    /// </summary>
    public enum ApplianceRecoveryBackupSchedulesDayOfWeekType
    {
        [EnumMember(Value = "MONDAY")]
        MONDAY = 1,
        [EnumMember(Value = "TUESDAY")]
        TUESDAY = 2,
        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY = 3,
        [EnumMember(Value = "THURSDAY")]
        THURSDAY = 4,
        [EnumMember(Value = "FRIDAY")]
        FRIDAY = 5,
        [EnumMember(Value = "SATURDAY")]
        SATURDAY = 6,
        [EnumMember(Value = "SUNDAY")]
        SUNDAY = 7,
    }
}
