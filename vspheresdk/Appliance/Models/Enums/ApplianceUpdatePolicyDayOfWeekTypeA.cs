using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Policy.DayOfWeek enumerated type defines the set of days
    /// </summary>
    public enum ApplianceUpdatePolicyDayOfWeekTypeA
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
