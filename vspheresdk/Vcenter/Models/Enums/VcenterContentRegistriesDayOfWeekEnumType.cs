using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The {@name DayOfWeek} {@term enumerated type} describes the supported days of the week to run a specific operation for a container registry.
    /// </summary>
    public enum VcenterContentRegistriesDayOfWeekEnumType
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
