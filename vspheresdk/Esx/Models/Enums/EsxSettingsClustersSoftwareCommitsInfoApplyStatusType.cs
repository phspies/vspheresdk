using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name ApplyStatusType} {@term structure} defines possible values regarding the application of this commit.
    /// </summary>
    public enum EsxSettingsClustersSoftwareCommitsInfoApplyStatusType
    {
        [EnumMember(Value = "APPLIED")]
        APPLIED = 1,
        [EnumMember(Value = "NOT_APPLIED")]
        NOTAPPLIED = 2,
    }
}
