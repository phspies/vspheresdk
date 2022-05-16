using System.Runtime.Serialization;

namespace vspheresdk.Vcenter.Models.Enums
{
    /// <summary>
    /// The Pending.UpdateType enumerated type defines update type
    /// </summary>
    public enum VcenterLcmUpdatePendingUpdateType
    {
        [EnumMember(Value = "PATCH")]
        PATCH = 1,
        [EnumMember(Value = "UPDATE")]
        UPDATE = 2,
        [EnumMember(Value = "UPGRADE")]
        UPGRADE = 3,
    }
}
