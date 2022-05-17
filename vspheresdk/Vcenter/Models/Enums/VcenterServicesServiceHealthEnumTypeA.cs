using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Service.Health enumerated type defines the possible values for health of a service.
    /// </summary>
    public enum VcenterServicesServiceHealthEnumTypeA
    {
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 1,
        [EnumMember(Value = "HEALTHY")]
        HEALTHY = 2,
        [EnumMember(Value = "HEALTHY_WITH_WARNINGS")]
        HEALTHYWITHWARNINGS = 3,
    }
}
