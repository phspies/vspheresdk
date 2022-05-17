using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Database.Info.Status enumerated type describes the health of the database.
    /// </summary>
    public enum ApplianceHealthDatabaseInfoStatusEnumTypeA
    {
        [EnumMember(Value = "UNHEALTHY")]
        UNHEALTHY = 1,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 2,
        [EnumMember(Value = "HEALTHY")]
        HEALTHY = 3,
    }
}
