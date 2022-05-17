using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name Recurrence} {@term enumerated type} contains the supported values for how often to sync from online or UMDS depots.
    /// </summary>
    public enum EsxSettingsDepotsSyncScheduleRecurrenceType
    {
        [EnumMember(Value = "HOURLY")]
        HOURLY = 1,
        [EnumMember(Value = "DAILY")]
        DAILY = 2,
        [EnumMember(Value = "WEEKLY")]
        WEEKLY = 3,
        [EnumMember(Value = "MONTHLY_BY_DAY")]
        MONTHLYBYDAY = 4,
    }
}
