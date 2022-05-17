using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name ComplianceImpact} {@term enumerated type} contains information about the impact of applying the target state in case of non compliance.
    /// </summary>
    public enum EsxSettingsComplianceImpactType
    {
        [EnumMember(Value = "NO_IMPACT")]
        NOIMPACT = 1,
        [EnumMember(Value = "MAINTENANCE_MODE_REQUIRED")]
        MAINTENANCEMODEREQUIRED = 2,
        [EnumMember(Value = "REBOOT_REQUIRED")]
        REBOOTREQUIRED = 3,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 4,
    }
}
