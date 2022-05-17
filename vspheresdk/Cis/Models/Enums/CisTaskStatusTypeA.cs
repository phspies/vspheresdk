using System.Runtime.Serialization;

namespace vspheresdk.Cis.Models.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum CisTaskStatusTypeA
    {
        [EnumMember(Value = "PENDING")]
        PENDING = 1,
        [EnumMember(Value = "RUNNING")]
        RUNNING = 2,
        [EnumMember(Value = "BLOCKED")]
        BLOCKED = 3,
        [EnumMember(Value = "SUCCEEDED")]
        SUCCEEDED = 4,
        [EnumMember(Value = "FAILED")]
        FAILED = 5,
    }
}
