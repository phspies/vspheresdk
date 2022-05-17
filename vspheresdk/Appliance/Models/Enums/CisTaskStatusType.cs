using System.Runtime.Serialization;

namespace vspheresdk.Appliance.Models.Enums
{
    /// <summary>
    /// The Status enumerated type defines the status values that can be reported for an operation.
    /// </summary>
    public enum CisTaskStatusType
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
