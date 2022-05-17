using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The CommonInfo.Severity enumerated type defines the severity of the issues fixed in the update.
    /// </summary>
    public enum ApplianceUpdateCommonInfoSeverityTypeA
    {
        [EnumMember(Value = "CRITICAL")]
        CRITICAL = 1,
        [EnumMember(Value = "IMPORTANT")]
        IMPORTANT = 2,
        [EnumMember(Value = "MODERATE")]
        MODERATE = 3,
        [EnumMember(Value = "LOW")]
        LOW = 4,
    }
}
