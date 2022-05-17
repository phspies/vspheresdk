using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name ComplianceStatus} {@term enumerated type} contains the possible different status of compliance with respect to target version.
    /// </summary>
    public enum EsxSettingsComplianceStatusEnumType
    {
        [EnumMember(Value = "COMPLIANT")]
        COMPLIANT = 1,
        [EnumMember(Value = "NON_COMPLIANT")]
        NONCOMPLIANT = 2,
        [EnumMember(Value = "INCOMPATIBLE")]
        INCOMPATIBLE = 3,
        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE = 4,
    }
}
