using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name SourceType} {@term enumerated type} defines possible values of sources for the offline depot.
    /// </summary>
    public enum EsxSettingsDepotsOfflineSourceTypeEnum
    {
        [EnumMember(Value = "PULL")]
        PULL = 1,
        [EnumMember(Value = "PUSH")]
        PUSH = 2,
    }
}
