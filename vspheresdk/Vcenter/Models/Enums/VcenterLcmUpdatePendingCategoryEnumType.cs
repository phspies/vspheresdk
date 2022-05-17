using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Pending.Category enumerated type defines the type of payload this release has on top of previous release
    /// </summary>
    public enum VcenterLcmUpdatePendingCategoryEnumType
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
