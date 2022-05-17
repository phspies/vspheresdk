using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Pending.SourceType enumerated type defines the supported types of sources of updates.
    /// </summary>
    public enum ApplianceUpdatePendingSourceTypeEnum
    {
        [EnumMember(Value = "LAST_CHECK")]
        LASTCHECK = 1,
        [EnumMember(Value = "LOCAL")]
        LOCAL = 2,
        [EnumMember(Value = "LOCAL_AND_ONLINE")]
        LOCALANDONLINE = 3,
    }
}
