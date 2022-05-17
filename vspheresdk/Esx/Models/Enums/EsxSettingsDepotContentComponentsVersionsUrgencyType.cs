using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name UrgencyType} {@term enumerated type} defines possible values of urgencies for a component.
    /// </summary>
    public enum EsxSettingsDepotContentComponentsVersionsUrgencyType
    {
        [EnumMember(Value = "CRITICAL")]
        CRITICAL = 1,
        [EnumMember(Value = "IMPORTANT")]
        IMPORTANT = 2,
        [EnumMember(Value = "MODERATE")]
        MODERATE = 3,
        [EnumMember(Value = "LOW")]
        LOW = 4,
        [EnumMember(Value = "GENERAL")]
        GENERAL = 5,
    }
}
