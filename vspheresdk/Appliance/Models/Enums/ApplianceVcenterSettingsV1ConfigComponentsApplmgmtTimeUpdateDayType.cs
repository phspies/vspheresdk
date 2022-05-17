using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Time.UpdateDay enumerated type Defines days to query for updates.
    /// </summary>
    public enum ApplianceVcenterSettingsV1ConfigComponentsApplmgmtTimeUpdateDayType
    {
        [EnumMember(Value = "MONDAY")]
        MONDAY = 1,
        [EnumMember(Value = "TUESDAY")]
        TUESDAY = 2,
        [EnumMember(Value = "FRIDAY")]
        FRIDAY = 3,
        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY = 4,
        [EnumMember(Value = "THURSDAY")]
        THURSDAY = 5,
        [EnumMember(Value = "SATURDAY")]
        SATURDAY = 6,
        [EnumMember(Value = "SUNDAY")]
        SUNDAY = 7,
        [EnumMember(Value = "EVERYDAY")]
        EVERYDAY = 8,
    }
}
