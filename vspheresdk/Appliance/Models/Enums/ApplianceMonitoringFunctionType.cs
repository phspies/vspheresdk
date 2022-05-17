using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// Monitoring.FunctionType enumerated type Defines aggregation function
    /// </summary>
    public enum ApplianceMonitoringFunctionType
    {
        [EnumMember(Value = "COUNT")]
        COUNT = 1,
        [EnumMember(Value = "MAX")]
        MAX = 2,
        [EnumMember(Value = "AVG")]
        AVG = 3,
        [EnumMember(Value = "MIN")]
        MIN = 4,
    }
}
