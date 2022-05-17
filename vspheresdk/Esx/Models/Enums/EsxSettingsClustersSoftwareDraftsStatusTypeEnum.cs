using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name StatusType} {@term enumerated type} defines possible values of status of a software draft.
    /// </summary>
    public enum EsxSettingsClustersSoftwareDraftsStatusTypeEnum
    {
        [EnumMember(Value = "VALID")]
        VALID = 1,
        [EnumMember(Value = "INVALID")]
        INVALID = 2,
    }
}
