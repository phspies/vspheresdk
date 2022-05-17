using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name ComplianceStatus} {@term enumerated type} contains the possible different status of compliance with respect to target version.
    /// </summary>
    public enum EsxSettingsClustersSoftwareReportsComplianceStatusType
    {
        [EnumMember(Value = "COMPATIBLE")]
        COMPATIBLE = 1,
        [EnumMember(Value = "INCOMPATIBLE")]
        INCOMPATIBLE = 2,
        [EnumMember(Value = "HCL_DATA_UNAVAILABLE")]
        HCLDATAUNAVAILABLE = 3,
        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE = 4,
        [EnumMember(Value = "NO_FIRMWARE_PROVIDER")]
        NOFIRMWAREPROVIDER = 5,
    }
}
