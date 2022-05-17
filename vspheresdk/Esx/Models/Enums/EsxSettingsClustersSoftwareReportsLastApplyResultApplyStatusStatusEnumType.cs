using System.Runtime.Serialization;

namespace vspheresdk.Esx.Models.Enums
{
    /// <summary>
    /// The {@name Status} {@term enumerated type} contains the possible different status codes that can be returned while trying to apply the desired software specification to hosts within the cluster.
    /// </summary>
    public enum EsxSettingsClustersSoftwareReportsLastApplyResultApplyStatusStatusEnumType
    {
        [EnumMember(Value = "OK")]
        OK = 1,
        [EnumMember(Value = "SKIPPED")]
        SKIPPED = 2,
        [EnumMember(Value = "TIMED_OUT")]
        TIMEDOUT = 3,
        [EnumMember(Value = "ERROR")]
        ERROR = 4,
        [EnumMember(Value = "RETRY_PENDING")]
        RETRYPENDING = 5,
    }
}
