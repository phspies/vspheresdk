using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name CompatibilityStatus} {@term enumerated type} defines compatibility status of a given server or PCI device against a specific release of ESXi.
    /// </summary>
    public enum EsxHclCompatibilityStatusEnumType
    {
        [EnumMember(Value = "COMPATIBLE")]
        COMPATIBLE = 1,
        [EnumMember(Value = "INCOMPATIBLE")]
        INCOMPATIBLE = 2,
        [EnumMember(Value = "UNAVAILABLE")]
        UNAVAILABLE = 3,
        [EnumMember(Value = "CERTIFIED")]
        CERTIFIED = 4,
        [EnumMember(Value = "NOT_CERTIFIED")]
        NOTCERTIFIED = 5,
    }
}
