using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name ComplianceAction} {@term enumerated type} enumerates the possible compliance status overrides for a storage device.
    /// </summary>
    public enum EsxSettingsClustersSoftwareReportsHardwareCompatibilityStorageDeviceOverridesComplianceStatusComplianceActionEnumType
    {
        [EnumMember(Value = "MARK_AS_VERIFIED")]
        MARKASVERIFIED = 1,
        [EnumMember(Value = "FLAG_AS_INCOMPATIBLE")]
        FLAGASINCOMPATIBLE = 2,
        [EnumMember(Value = "SUPPRESS_WARNING")]
        SUPPRESSWARNING = 3,
    }
}
