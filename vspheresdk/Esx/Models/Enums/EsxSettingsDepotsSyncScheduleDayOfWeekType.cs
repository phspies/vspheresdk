using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name DayOfWeek} {@term enumerated type} contains the supported days of the week.
    /// </summary>
    public enum EsxSettingsDepotsSyncScheduleDayOfWeekType
    {
        [EnumMember(Value = "SUNDAY")]
        SUNDAY = 1,
        [EnumMember(Value = "MONDAY")]
        MONDAY = 2,
        [EnumMember(Value = "TUESDAY")]
        TUESDAY = 3,
        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY = 4,
        [EnumMember(Value = "THURSDAY")]
        THURSDAY = 5,
        [EnumMember(Value = "FRIDAY")]
        FRIDAY = 6,
        [EnumMember(Value = "SATURDAY")]
        SATURDAY = 7,
    }
}
