using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The CommonInfo.Category enumerated type defines update type
    /// </summary>
    public enum ApplianceUpdateCommonInfoCategoryTypeA
    {
        [EnumMember(Value = "SECURITY")]
        SECURITY = 1,
        [EnumMember(Value = "FIX")]
        FIX = 2,
        [EnumMember(Value = "UPDATE")]
        UPDATE = 3,
        [EnumMember(Value = "UPGRADE")]
        UPGRADE = 4,
    }
}
