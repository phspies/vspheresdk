using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name Action} {@term enumerated type} defines the actions to be taken when entering maintenance mode fails on a single host within the cluster.
    /// </summary>
    public enum EsxSettingsClustersPoliciesApplyFailureActionActionType
    {
        [EnumMember(Value = "FAIL")]
        FAIL = 1,
        [EnumMember(Value = "RETRY")]
        RETRY = 2,
    }
}
