using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Monitoring.IntervalType enumerated type Defines interval between the values in hours and mins, for which aggregation will apply
    /// </summary>
    public enum ApplianceMonitoringIntervalTypeEnumA
    {
        [EnumMember(Value = "MINUTES30")]
        MINUTES30 = 1,
        [EnumMember(Value = "HOURS2")]
        HOURS2 = 2,
        [EnumMember(Value = "MINUTES5")]
        MINUTES5 = 3,
        [EnumMember(Value = "DAY1")]
        DAY1 = 4,
        [EnumMember(Value = "HOURS6")]
        HOURS6 = 5,
    }
}
